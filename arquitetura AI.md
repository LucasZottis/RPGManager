# Arquitetura — IA Mestre de RPG

## Visão Geral

Sistema desktop instalável onde uma IA treinada conduz sessões de RPG (D&D 5e) de forma autônoma, rodando inteiramente na máquina do usuário, sem dependência de serviços externos.

---

## Princípios Fundamentais

- **Local first** — tudo roda na máquina do usuário, sem cloud, sem internet obrigatória
- **IA como narrador** — o modelo cuida do improviso e da narrativa
- **Aplicação como sistema** — regras, estado e dados factuais são responsabilidade do código
- **Sem alucinação factual** — dados do D&D vêm sempre do banco de dados, nunca da memória do modelo

---

## Componentes

### 1. Modelo de Linguagem (IA)

- **Base:** Qwen 3 (open source, Alibaba)
- **Tamanho:** 8B para testes e fase 1 — 14B candidato para produção devido ao contexto longo
- **Motivo da escolha:** Melhor suporte a português entre os modelos open source de tamanho equivalente, contexto de 128k tokens, suporte oficial no Unsloth
- **Treinamento:** Fine-tuning com QLoRA usando dataset curado de RPG
- **Formato para testes:** GGUF quantizado em Q4_K_M (~5 GB para 8B, ~10 GB para 14B)
- **Servidor de inferência (testes):** Ollama (roda local, expõe API REST)
- **Responsabilidades:**
  - Narração de cenas e situações
  - Improviso criativo dentro do contexto injetado
  - Tom e voz de NPCs
  - Decisões narrativas (quando uma ação tem consequência dramática)

> ⚠️ Tamanho definitivo (8B ou 14B) e forma de distribuição ainda não decididos. Testes serão conduzidos localmente.

---

### 2. Banco de Dados de Regras (RAG)

Repositório local de todos os dados factuais do D&D 5e. O modelo nunca precisa memorizar esses dados — a aplicação os injeta no contexto quando relevante.

```
Tabelas:
├── racas           → atributos, habilidades, velocidade, sentidos
├── classes         → características por nível, proficiências
├── magias          → alcance, duração, componentes, efeito exato
├── monstros        → CA, HP, ataques, resistências, imunidades
├── itens           → bônus, propriedades, requisitos
├── condicoes       → envenenado, agarrado, inconsciente, etc.
└── habilidades     → descrição, gatilhos de ativação
```

---

### 3. Sistema de Contexto em Camadas

A cada turno, a aplicação monta o prompt dinamicamente combinando camadas por prioridade:

```
┌─────────────────────────────────────┐  SEMPRE (~300 tokens)
│  ESTADO ATUAL                       │
│  Personagens ativos, HP, condições  │
├─────────────────────────────────────┤  CONDICIONAL (~400 tokens)
│  DADOS INJETADOS                    │
│  Stats de inimigos, magias usadas,  │
│  habilidades relevantes, local      │
├─────────────────────────────────────┤  SEMPRE (~300 tokens)
│  MEMÓRIA DA SESSÃO                  │
│  Resumo comprimido dos eventos      │
├─────────────────────────────────────┤  SEMPRE (~200 tokens)
│  FATOS PERMANENTES                  │
│  Decisões críticas, traumas,        │
│  inimizades, segredos revelados     │
├─────────────────────────────────────┤  JANELA DESLIZANTE (~1000 tokens)
│  HISTÓRICO RECENTE                  │
│  Últimas 5–10 trocas da sessão      │
├─────────────────────────────────────┤  ENTRADA (~100 tokens)
│  AÇÃO DO JOGADOR                    │
└─────────────────────────────────────┘
Total típico: ~2300 tokens
```

---

### 4. Sistema de Injeção Automática

Responsável por detectar o que é relevante em cada turno e injetar do banco de dados.

**Três mecanismos:**

#### 4.1 — Injeção por evento estruturado
Eventos que passam pela aplicação antes de chegar ao modelo:
- Criação de personagem → injeta ficha completa da raça e classe
- Início de combate → injeta stats dos inimigos
- Uso de magia → injeta descrição exata da magia
- Adição de item → injeta propriedades do item

#### 4.2 — Injeção por gatilhos contextuais
Mapeamento de palavras-chave para habilidades:

```json
{
  "Sentidos Aguçados":     ["escuro", "invisível", "emboscada", "furtivo"],
  "Visão no Escuro":       ["escuro", "noite", "caverna", "sem luz"],
  "Resistência a Veneno":  ["veneno", "toxina", "gás", "picada"],
  "Pés Leves":             ["furtivo", "silêncio", "armadilha"]
}
```

A aplicação verifica a ação do jogador contra os gatilhos das habilidades do personagem ativo.

#### 4.3 — Injeção preventiva de habilidades passivas
Habilidades sempre ativas ficam permanentemente no contexto enquanto o personagem estiver em jogo. São poucas por personagem e somam pouco ao contexto total.

---

### 5. Gerenciamento de Memória de Longo Prazo

Sessões longas são comprimidas automaticamente para não estourar o contexto:

```
A cada 10 turnos
        ↓
Aplicação chama o modelo com o histórico acumulado
        ↓
Modelo gera resumo em até 200 palavras
        ↓
Resumo substitui o histórico antigo
        ↓
Histórico recente reinicia com os últimos turnos
```

**Fatos permanentes** são extraídos manualmente pelo jogador ou automaticamente por regras:
- Personagem morreu/quase morreu
- Aliança ou inimizade formada
- Segredo revelado
- Local destruído ou conquistado

---

### 6. Aplicação Desktop

- **Stack:** .NET + interface desktop (MAUI, WPF ou Avalonia)
- **Distribuição:** instalador único que configura Ollama, baixa o modelo e instala a aplicação
- **Responsabilidades:**
  - Interface do jogador (narrativa, entrada de ação, ficha)
  - Gerenciamento de estado da campanha
  - Montagem do contexto a cada turno
  - Comunicação com Ollama via API local
  - Persistência de sessões e campanhas

---

## Fluxo de um Turno

```
Jogador digita a ação
        ↓
Aplicação analisa a ação:
  → Detecta gatilhos de habilidades
  → Verifica eventos estruturados
  → Injeta dados relevantes do BD
        ↓
Aplicação monta o contexto completo:
  → Estado atual + dados injetados
  → Memória da sessão + fatos permanentes
  → Histórico recente + ação atual
        ↓
Envia para Ollama (API local)
        ↓
Modelo retorna a narração
        ↓
Aplicação exibe ao jogador
        ↓
Aplicação atualiza o estado:
  → HP, condições, itens, localização
  → Adiciona ao histórico recente
  → Verifica se precisa comprimir memória
```

---

## Gerenciamento do Dataset

### Armazenamento

Os exemplos do dataset são persistidos em banco de dados, não em arquivos. Isso permite filtrar, editar e gerenciar os exemplos com mais facilidade.

```
Tabela: dataset_exemplos
├── id
├── categoria          → combate, exploracao, social, magia, descanso
├── local              → descrição do ambiente
├── personagens        → JSON com nome, classe, nível, HP, condições
├── inimigos           → JSON com nome, CA, HP (opcional)
├── npcs               → JSON com nome, atitude (opcional)
├── condicoes_ativas   → lista de condições (opcional)
├── acao               → o que o jogador fez
├── resultado_rolagem  → resultado dos dados (opcional)
├── output             → resposta ideal do mestre
├── origem             → manual, transcricao, feedback
└── status             → ativo, revisao, descartado
```

### Geração do JSONL

A aplicação monta o campo `input` automaticamente a partir dos campos do banco, seguindo o formato padrão, e exporta o arquivo JSONL na hora de treinar:

```
Local: {local}
Personagens: {personagens formatados}
[Condições ativas: {condicoes}]     ← omitido se vazio
[Inimigos: {inimigos}]              ← omitido se vazio
[NPCs presentes: {npcs}]            ← omitido se vazio
Ação: {acao}
[Resultado da rolagem: {resultado}] ← omitido se vazio
```

### Tela de cadastro

Interface com campos separados seguindo a estrutura acima. A aplicação cuida de formatar e salvar no banco — o usuário só preenche os campos relevantes para cada situação.

---

## Fluxo de Treinamento do Modelo

```
Exemplos no banco de dados
        ↓
Exportação para JSONL (gerado pela aplicação)
        ↓
Fine-tuning com QLoRA
        ↓
Exportação em formato GGUF Q4_K_M
        ↓
Validação manual das respostas
        ↓
Modelo disponível para uso
```

### Onde treinar

O treinamento é feito na cloud, sob demanda. O Google Colab é a opção principal — comprovadamente funciona para fine-tuning de modelos 7B com QLoRA, inclusive no plano gratuito.

**Plataformas:**

| Plataforma | GPU | VRAM | Custo | Quando usar |
|---|---|---|---|---|
| Google Colab gratuito | T4 | 15 GB | Gratuito | Testes rápidos, datasets pequenos |
| Google Colab Pro | T4 / A100 | 15–40 GB | ~$10/mês | Fase 1 e 2 do projeto |
| Google Colab Pro+ | A100 | 40 GB | ~$50/mês | Datasets grandes, mais estabilidade |
| RunPod | A100 / H100 | 40–80 GB | ~$1–2/hora | Alternativa para treinos muito longos |
| Vast.ai | Variado | Variado | ~$0.50–1/hora | Opção mais barata, GPUs de terceiros |

**Recomendação por fase:**

- **Fase 1 (validação)** — Google Colab gratuito ou Pro com Qwen 3 8B: dataset ~300 exemplos treina em menos de 1 hora
- **Fase 2 (refinamento)** — Google Colab Pro com Qwen 3 8B: dataset ~2000+ exemplos, confortável com A100

**Ferramenta recomendada: Unsloth**

Biblioteca que torna o processo direto — 2–4x mais rápido e 40–70% menos memória que o fluxo padrão. Tem notebooks prontos para Colab cobrindo LLaMA 3, Mistral, Gemma e Qwen. O fluxo é:

```
1. Abre o notebook do Unsloth no Colab
2. Aponta para seu dataset
3. Clica em Run All
4. Exporta direto para GGUF
```

### O que é gerado

Com QLoRA o fine-tuning produz um **adapter** — arquivo menor contendo apenas as diferenças em relação ao modelo base:

```
modelo-base.gguf  +  adapter-rpg.bin
        ↓
Mesclagem (feita uma vez)
        ↓
modelo-rpg-final.gguf
(arquivo único com todo o conhecimento)
```

O arquivo final contém tudo — processamento linguístico do modelo base mais o conhecimento de mestre de RPG adquirido no fine-tuning. É esse arquivo que é distribuído ou instalado via Ollama.

---

## Coleta de Feedback e Melhoria Contínua

Durante o uso real, a aplicação coleta dados que enriquecem o dataset para ciclos futuros de treinamento.

### Como funciona

Após cada resposta do modelo, o jogador pode avaliá-la:

```
[Resposta do mestre aparece na tela]

👍  👎  ✏️ Reescrever
```

- **👍** — resposta boa, vira exemplo positivo no dataset
- **👎** — resposta ruim, marcada para revisão
- **✏️ Reescrever** — jogador corrige a resposta; o par (errada + correta) vira exemplo de alta qualidade

### O que é salvo

```
Tabela: feedback_turnos
├── contexto_enviado     → o prompt completo daquele turno
├── resposta_gerada      → o que o modelo respondeu
├── avaliacao            → positivo / negativo
└── resposta_corrigida   → versão corrigida (se houver)
```

### Ciclo de melhoria

```
Uso real + coleta de feedback
        ↓
Acumula 200–500 avaliações
        ↓
Exporta exemplos avaliados
        ↓
Adiciona ao dataset existente
        ↓
Novo ciclo de fine-tuning
        ↓
Nova versão do modelo distribuída
```

### Por que isso é valioso

- Os exemplos vêm de situações reais que aconteceram no jogo
- Cobrem casos que não foram previstos na escrita manual do dataset
- Refletem o estilo e preferências do grupo específico
- Com o tempo o modelo aprende o tom que aquele grupo prefere

---

## Divisão de Responsabilidades

| Responsabilidade | Quem resolve |
|---|---|
| Narração, improviso, criatividade | Modelo fine-tunado |
| Aplicação de regras procedurais | Modelo fine-tunado (aprendido no dataset) |
| Dados factuais (stats, magias, raças) | Banco de dados + injeção automática |
| Estado da campanha | Aplicação |
| Memória de longo prazo | Aplicação (compressão automática) |
| Habilidades contextuais | Aplicação (sistema de gatilhos) |
| Distribuição e instalação | A definir |

---

## Requisitos Mínimos de Hardware (estimativa)

| Componente | Mínimo | Recomendado |
|---|---|---|
| RAM | 16 GB | 32 GB |
| VRAM (GPU dedicada) | 6 GB | 8 GB+ |
| Armazenamento | 10 GB livres | 20 GB livres |
| CPU | Quad-core moderno | — |

> Sem GPU dedicada o modelo ainda roda via CPU, mas com latência maior (~15–30s por resposta).

---

## Fases do Projeto

### Fase 1 — Validação de ideia
- Dataset pequeno (~300 exemplos)
- Fine-tuning básico no Colab
- Interface mínima funcional
- Teste com grupo fechado

### Fase 2 — Refinamento
- Dataset expandido (~2000+ exemplos)
- Banco de dados completo do D&D 5e SRD
- Sistema de gatilhos robusto
- Gerenciamento de campanha completo

### Fase 3 — Distribuição
- Forma de distribuição a definir
- Modelo definitivo a definir conforme distribuição escolhida
- Suporte a múltiplos sistemas de RPG
- Expansão além do D&D 5e

---

## Persistência do Histórico

### Estrutura das tabelas

```
Tabela: campanhas
├── id
├── nome
├── sistema              → ex: D&D 5e
├── descricao
└── criado_em

Tabela: sessoes
├── id
├── campanha_id
├── numero
├── resumo               → gerado automaticamente ao encerrar a sessão
└── criado_em

Tabela: turnos
├── id
├── sessao_id
├── ordem
├── acao_jogador
├── resposta_mestre
├── contexto_enviado     → o prompt completo daquele turno
└── criado_em

Tabela: fatos_permanentes
├── id
├── campanha_id
├── sessao_id            → em qual sessão aconteceu
├── tipo                 → alianca, inimizade, morte, conquista, segredo
└── descricao            → "O grupo destruiu a torre de Selvorn"
```

### Ao encerrar uma sessão

```
Jogador encerra a sessão
        ↓
Aplicação pega todos os turnos da sessão
        ↓
Chama o modelo para gerar um resumo
        ↓
Salva o resumo na tabela sessoes
        ↓
Turnos permanecem no banco para consulta do jogador
```

### Ao iniciar uma nova sessão

```
Aplicação busca:
  → Resumos das últimas N sessões
  → Fatos permanentes ativos da campanha
  → Estado atual dos personagens
        ↓
Monta o contexto histórico inicial
        ↓
Sessão começa com o modelo ciente do que aconteceu
```

### Distinção entre consulta humana e contexto do modelo

| Finalidade | O que usa |
|---|---|
| Jogador rever o que aconteceu | Tabela turnos completa |
| Modelo continuar a narrativa | Resumos + fatos permanentes + últimos N turnos |

O histórico completo fica salvo para consulta — mas o modelo nunca recebe tudo de uma vez, só o que cabe no contexto.