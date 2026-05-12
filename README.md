# RPGManager

App mobile para criação e gerenciamento de fichas de personagem de RPG.

## Plataforma

```
Interface:    Flutter
Banco:        SQLite local
Distribuição: APK direto (sem Play Store)
Custo:        Zero
```

## Criação de personagem

O fluxo de criação segue a ordem definida pelo manual.

### Etapa 1 — Classe

O jogador escolhe uma das 12 classes disponíveis: 

- Bárbaro
- Bardo
- Clérigo
- Druida
- Guerreiro
- Monge
- Paladino
- Patrulheiro
- Ladino
- Feiticeiro
- Bruxo
- Mago

O nível inicial é 1. O XP inicial é 0.

### Etapa 2 — Origem

A origem é composta por três escolhas:

**Antecedente**

O jogador escolhe um dos antecedentes disponíveis. Cada antecedente define:
- Três atributos com bônus de +2/+1/+1
- Um Feat de origem
- Duas proficiências de perícia
- Uma proficiência de ferramenta
- Equipamento inicial ou 50 PO

Os antecedentes disponíveis são: Acólito, Criminoso, Sábio e Soldado.

**Espécie**

O jogador escolhe uma das espécies disponíveis: Draconato, Anão, Elfo, Gnomo, Goliath, Halfling, Humano, Orc e Tiefling.

**Idiomas**

O jogador escolhe os idiomas conforme as regras da espécie e do antecedente escolhidos.

### Etapa 3 — Atributos

O jogador informa manualmente os seis valores de atributo obtidos por rolagem física de dados. O app calcula e exibe os modificadores correspondentes.

Os seis atributos são: Força, Destreza, Constituição, Inteligência, Sabedoria e Carisma.

### Etapa 4 — Alinhamento

O jogador escolhe um dos nove alinhamentos:

- Leal e Bom
- Neutro e Bom
- Caótico e Bom
- Leal e Neutro
- Neutro
- Caótico e Neutro
- Leal e Mau
- Neutro e Mau
- Caótico e Mau

### Etapa 5 — Detalhes

O jogador preenche os dados narrativos do personagem:

- Nome
- Idade
- Aparência
- Traços de personalidade
- Ideais
- Vínculos
- Defeitos

## Gerenciamento durante o jogo

### Combate

**Hit Points**

HP atual, HP máximo e HP temporário. HP temporário é perdido primeiro ao receber dano e não acumula com novo HP temporário recebido.

**Death Saving Throws**

Exibidos quando o personagem está com 0 HP. O jogador registra manualmente os sucessos e falhas. Três sucessos estabilizam o personagem. Três falhas resultam em morte.

**Hit Dice**

Exibe o total de Hit Dice e quantos foram gastos. O jogador registra o gasto durante descansos curtos.

**AC, Iniciativa e Velocidade**

Valores calculados automaticamente com base nas escolhas da criação. O jogador pode ajustar manualmente caso haja modificadores situacionais.

**Condições**

O jogador registra as condições ativas no personagem.

### Atributos e perícias

Exibe os seis atributos com seus valores e modificadores. Para cada atributo, exibe os saving throws correspondentes com indicação de proficiência.

Exibe as 18 perícias com seus modificadores e indicação de proficiência. Exibe a Percepção Passiva calculada automaticamente.

### Ataques

Exibe as armas do personagem com bônus de ataque e dano calculados automaticamente com base nos atributos e proficiências.

### Magia

Exibido apenas para classes com Spellcasting ou Pact Magic.

Exibe o DC de resistência de magia e o bônus de ataque de magia, calculados automaticamente.

Exibe os spell slots por nível com controle de uso. O jogador registra os slots gastos e os recupera ao descansar.

Exibe os cantrips conhecidos e as magias preparadas.

### Recursos de classe

Cada classe possui recursos específicos. O jogador controla a quantidade disponível e gasta durante o jogo.

- Bárbaro — Rages
- Bardo — Bardic Inspiration
- Clérigo — Channel Divinity
- Druida — Wild Shape
- Guerreiro — Action Surge, Second Wind
- Monge — Ki
- Paladino — Lay on Hands, Channel Divinity
- Feiticeiro — Sorcery Points
- Mago — Arcane Recovery

### Inventário

Exibe os itens e equipamentos do personagem. O jogador adiciona, remove e ajusta quantidades manualmente.

Exibe o dinheiro do personagem por tipo de moeda: PC, PP, PE, PO e PL.

### Progressão

Exibe o XP atual e o nível do personagem. O jogador registra o XP ganho manualmente. O nível avança automaticamente ao atingir o XP necessário.

## Fora do MVP

- Mestre e gerenciamento de campanhas
- Métodos de atributos: array padrão e compra de pontos
- Multiclasse
- Sincronização em nuvem
- Mobile para iOS
