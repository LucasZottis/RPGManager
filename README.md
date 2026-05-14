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

### Etapa Sistema

Uma lista de sistemas cadastrados será exibida e o usuário deve selecionar um. Caso tenha apenas um sistema disponível para o usuário será selecionado automaticamente, assim pulando para próxima etapa.

### Etapa Classe

O jogador escolhe entre as classes disponíveis para o usuário dentro daquele sistema. Cada classe deve ter uma descrição curta, dificuldade de jogo com a classe e atributos principais.

### Etapa Antecedente

O jogador escolhe um dos antecedentes disponíveis. Cada antecedente define:
- Três atributos com bônus de +2/+1/+1 (Três atributos listados — aumenta um em +2 e outro em +1, ou aumenta os três em +1. Nenhum pode ultrapassar 20.)

- Um feat específico do tipo Origin
- Duas proficiências de perícia
- Uma proficiência ferramenta específica ou uma à escolha da categoria de Ferramentas de Artesão
- Escolha entre um pacote de equipamentos ou 50 PO (Pontos de Ouro)

Os antecedentes disponíveis são: 
- Acólito
- Criminoso
- Sábio
- Soldado

Cada antecedente deve ter uma descrição curta.

### Etapa Espécie

O jogador escolhe uma das espécies disponíveis para o usuário. Uma espécie pode ter sub-espécie ou um ancestral e caso a espécie selecionada esteja em um dos casos, o usuário também deve escolher uma opção disponível para aquela espécie.

### Etapa Idiomas

O jogador escolhe os idiomas conforme as regras da espécie e do antecedente escolhidos.

### Etapa Alinhamento

Se tiver alinhamento cadastrado para o sistema selecionado, será exibido nessa etapa. O usuário deve selecionar um dos disponíveis.

### Etapa Atributos

O jogador informa manualmente os seis valores de atributo obtidos por rolagem física de dados. O app calcula e exibe os modificadores correspondentes.

Os seis atributos são: Força, Destreza, Constituição, Inteligência, Sabedoria e Carisma.

### Etapa Detalhes

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

Um personagem tem HP máximo, HP atual e HP temporário. O HP máximo é a quantidade de vida do personagem. Quando o HP atual chegar a zero, o personagem fica inconsciente e começará o Death Saving Throws.

O HP atual deve ser reduzido informando a quantidade de dano e tipo de dano. Quando o personagem tiver resistencia e não deve receber dano algum quando for invulnerável.

O HP atual pode ser aumentado ao curar o personagem.

**Death Saving Throws**

Exibidos quando o personagem está com 0 HP. O jogador registra manualmente os sucessos e falhas. Três sucessos estabilizam o personagem. Três falhas resultam em morte.

O manager não deve permitir o jogador fazer nada além dos Death Saving Throws quando a vida estiver zerada.

Os Death Saving Throws funcionaram da seguinte forma: O usuário joga o dado manualmente e informa se foi sucesso ou não. Se o personagem morrer, desabilita toda a ficha dele não permitindo realizar nada dentro do app.

**Hit Dice**

Exibe o total de Hit Dice e quantos estão disponíveis para uso. Hit Dice é a quantidade de dados que podem ser utilizados para restaurar a vida durante o descanso curto.

**AC (Armor Class) ou CA (Classe de Armadura)**

É o valor utilizado para determinar se o personagem recebe dano ou não no momento do combate. Um personagem começa com um valor mínimo de CA conforme a montagem do personagem.

**Iniciativa**

É determinado pelo atributo de Destreza, mas pode haver exceções.

**Velocidade**

É um valor determinado uma unidade de medida de distância, por padrão é metros, mas deve haver configuração para isso. É a quantidade de espaços que o personagem pode se movimentar durante o combate. Isso é determinado na espécie do personagem.

<!-- **Condições**

O jogador registra as condições ativas no personagem. -->

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
