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

                Console.WriteLine("Comandos: ← → ↓  a(rotacionar anti-horário)  h(rotacionar horário)  q(sair)");
                Console.Write("Digite um comando: ");
                string comando = Console.ReadLine();

                ProcessarComando();
                AtualizarJogo();
            }

            jogador.Salvar("pontuacoes.txt");
        }

        private void ExibirTabuleiro()
        {

        }

        private void ProcessarComando()
        {
            ConsoleKeyInfo tecla = Console.ReadKey(true); // true = não mostrar no console

            switch (tecla.Key)
            {
                case ConsoleKey.LeftArrow:
                    break;

                case ConsoleKey.RightArrow:
                    break;

                case ConsoleKey.DownArrow:
                    break;

                case ConsoleKey.A:
                    break;

                case ConsoleKey.H:
                    break;

                case ConsoleKey.Q:
                    jogoAtivo = false;
                    break;
            }
        }


        private void AtualizarJogo()
        {
        }
    }
}
