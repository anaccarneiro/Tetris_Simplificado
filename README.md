# Trabalho_ATP

## 🧱 Resumo do Trabalho Prático: Tetris Simplificado 🎮

Este projeto consiste no desenvolvimento de uma versão simplificada do jogo **Tetris** para aplicar conceitos fundamentais de programação, como matrizes, manipulação de arquivos, controle de fluxo e modularização. O desenvolvimento deve seguir estritamente as regras e instruções fornecidas no caderno de instruções.

---

## 📝 Regras e Instruções Principais

### 🎯 Objetivo do Jogo

O jogador deve controlar peças que caem, movendo-as horizontalmente e rotacionando-as para formar e remover linhas completas no tabuleiro.

### 🕹️ Controles

A movimentação e rotação são manuais, feitas por comandos de teclado.

| Ação | Tecla |
| :--- | :--- |
| Mover para a direita | **→** (Seta para a Direita) |
| Mover para a esquerda | **←** (Seta para a Esquerda) |
| Mover para baixo | **↓** (Seta para Baixo) |
| Rotacionar 90º anti-horário | **'a'** |
| Rotacionar 90º horário | **'h'** |

### 📏 Especificações Técnicas

* **Tabuleiro:** Matriz bidimensional **$20\times10$**.
* **Peças:** Implementar os formatos clássicos **I**, **L**, e **T**. Cada peça é representada por uma matriz $3\times3$.

### 🏆 Pontuação e Fim de Jogo

* **Pontos por Linha:** Cada linha completa removida concede **300 pontos**.
* **Pontos por Peça:** A pontuação por encaixar cada peça é diferente: **I = 3**, **L = 4**, **T = 5**.
* **Fim de Jogo:** O jogo termina se uma nova peça não puder ser inserida na posição inicial (topo e centro do tabuleiro) por falta de espaço.
* **Registro:** O nome e a pontuação final do jogador devem ser salvos no arquivo **`pontuacoes.txt`** no formato `NomeJogador; Pontuação`.