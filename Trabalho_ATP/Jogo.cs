using ConsoleApp1;
using System;

namespace Trabalho_ATP
{
    public class Jogo
    {
        private Jogador jogador;
<<<<<<< HEAD
        private int[,] tabuleiro;
=======
        private Tabuleiro tabuleiro;   
        private Peca pecaAtual;
>>>>>>> 197ddba4a148b99f8ed0b748ad7ada3e067afc16
        private bool jogoAtivo;

        public Jogo(Jogador jogador)
        {
            this.jogador = jogador;
<<<<<<< HEAD
            tabuleiro = new int[20, 10];
            jogoAtivo = true;
        }
        public void Iniciar()
        {
=======
            tabuleiro = new Tabuleiro();
            jogoAtivo = true;
        }

        public void Iniciar()
        {

>>>>>>> 197ddba4a148b99f8ed0b748ad7ada3e067afc16
            while (jogoAtivo)
            {
                Console.Clear();
                ExibirTabuleiro();
<<<<<<< HEAD
                LerEntrada();
=======

                Console.WriteLine("Comandos: ← → ↓  a(rotacionar anti-horário)  h(rotacionar horário)  q(sair)");
                Console.Write("Digite um comando: ");
                string comando = Console.ReadLine();

                ProcessarComando();
>>>>>>> 197ddba4a148b99f8ed0b748ad7ada3e067afc16
                AtualizarJogo();
            }

            jogador.Salvar("pontuacoes.txt");
        }
<<<<<<< HEAD
        private void ExibirTabuleiro()
        {
        }

        private void LerEntrada()
        {
        }

        private void AtualizarJogo()
        {
        }
=======

        private void ExibirTabuleiro()
        {

        }

        private void ProcessarComando()
        {
            ConsoleKeyInfo tecla = Console.ReadKey(true); 

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
            VerificarFimDeJogo();
        }

        private void VerificarFimDeJogo()
        {
            Peca novaPeca = new Peca('T', 3, 0);

            if (!tabuleiro.PodeInserir(novaPeca))
            {
                Console.WriteLine("Fim de jogo! Não foi possível inserir nova peça.");
                jogoAtivo = false;
            }
            else
            {
                pecaAtual = novaPeca;
                tabuleiro.InserirPeca(pecaAtual);
            }
        }

>>>>>>> 197ddba4a148b99f8ed0b748ad7ada3e067afc16
    }
}
