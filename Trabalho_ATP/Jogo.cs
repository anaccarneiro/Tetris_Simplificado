using ConsoleApp1;
using System;

namespace Trabalho_ATP
{
    public class Jogo
    {
        private Jogador jogador;
        private int[,] tabuleiro;
        private bool jogoAtivo;

        public Jogo(Jogador jogador)
        {
            this.jogador = jogador;
            tabuleiro = new int[20, 10];
            jogoAtivo = true;
        }

        public void Iniciar()
        {
            while (jogoAtivo)
            {
                Console.Clear();
                ExibirTabuleiro();
                LerEntrada();
                AtualizarJogo();
            }

            jogador.Salvar("pontuacoes.txt");
        }

        private void ExibirTabuleiro()
        {
        }

        private void LerEntrada()
        {
        }

        private void AtualizarJogo()
        {
        }

    }
}
