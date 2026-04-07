## CP01-JOGO-DE-CARTAS

- Augusto Ferreira Rogel de Souza / RM 557709
- Heitor Prestes / RM 554823
- Lucca Ribeiro / RM 556668


# CardGameLib
Esta biblioteca foi desenvolvida para modelar estruturas genéricas comuns a jogos de cartas, com foco em simplicidade, reutilização e baixo acoplamento.

O objetivo é fornecer uma base mínima para representar elementos fundamentais de jogos de cartas, permitindo fácil adaptação para diferentes tipos de jogos (como Poker, Truco, Blackjack, entre outros).

---

# Estrutura da Solução
A biblioteca é composta pelas seguintes classes principais:

# Card<TSuit, TRank>
Representa uma carta genérica.

- Suit: naipe (genérico)
- Rank: valor da carta (genérico)

Permite flexibilidade para diferentes tipos de baralho.

---

# Deck<TSuit, TRank>
Representa o baralho de cartas.

- Armazena cartas em uma estrutura de pilha (Stack)
- Permite:

  - Comprar carta (Draw)
  - Embaralhar (Shuffle)

---

# Player<TSuit, TRank>
Representa um jogador.

-  Name: nome do jogador
-  Hand: mão de cartas do jogador

---

# Hand<TSuit, TRank>
Representa a mão de um jogador.

- Armazena uma lista de cartas
- Permite: 
  - Adicionar carta
  - Remover carta
  - Exposição controlada via IReadOnlyList

---

# Round<TSuit, TRank>
Representa uma rodada do jogo.

- Number: número da rodada
- Plays: jogadas realizadas (jogador → carta)

Responsável por registrar o que cada jogador jogou na rodada.

---

# Game<TSuit, TRank>
Representa a partida.

- Players: lista de jogadores
- Deck: baralho utilizado
- Rounds: histórico de rodadas

Gerencia o fluxo básico do jogo e mantém histórico.

---

# Modelagem de Dados
A solução contempla:

- Estrutura de jogadores
- Estrutura de partida
- Histórico completo de rodadas
- Associação entre jogadores e suas jogadas

---

# Princípios adotados
- Generalização: uso de generics para permitir reutilização em diferentes jogos
- Baixo acoplamento: classes independentes entre si
- Responsabilidade única: cada classe possui um papel bem definido
- Minimalismo: apenas funcionalidades essenciais foram implementadas

---

# Fora do escopo
Para manter a solução simples e genérica, os seguintes itens não foram implementados:

- Regras específicas de jogo
- Sistema de pontuação
- Controle de turnos avançado
- Validação de jogadas
- Interface de usuário

Esses elementos devem ser implementados na camada de aplicação que utilizar a biblioteca.

---

# Possíveis extensões
A biblioteca pode ser facilmente expandida com:

- Sistema de pontuação (Score)
- Interfaces de regras (IGameRule)
- Gerenciamento de turnos
- Eventos (ex: jogada realizada, rodada finalizada)
- Persistência de histórico

---

# Conclusão
A CardGameLib fornece uma base simples e extensível para modelagem de jogos de cartas, permitindo que desenvolvedores implementem regras específicas conforme a necessidade do jogo.
