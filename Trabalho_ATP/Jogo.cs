using ConsoleApp1;
using System;

namespace Trabalho_ATP
{
    public class Jogo
    {
        private Jogador jogador;
        private Tabuleiro tabuleiro;   
        private Peca pecaAtual;
        private bool jogoAtivo;

        public Jogo(Jogador jogador)
        {
            this.jogador = jogador;
            tabuleiro = new Tabuleiro();
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

    }
}
