using System;

namespace Trabalho_ATP
{
    public class Jogo
    {
        private Jogador jogador;
        private Tabuleiro tabuleiro;
        private Peca pecaAtual;
        private bool jogoAtivo;
        private Random random;

        public Jogo(Jogador jogador)
        {
            this.jogador = jogador;
            tabuleiro = new Tabuleiro();
            jogoAtivo = true;
            random = new Random();
        }

        public void Iniciar()
        {
            GerarNovaPeca();

            while (jogoAtivo)
            {
                tabuleiro.Renderizar();
                Console.WriteLine($"Jogador: {jogador.Nome} | Pontos: {jogador.PontuacaoFinal}");
                Console.WriteLine("Comandos: Setas (Mover) | A/H (Rotacionar) | Q (Sair)");

                ProcessarComando();
            }

            jogador.Salvar("pontuacoes.txt");
            Console.WriteLine("Fim de Jogo!");
        }

        private void GerarNovaPeca()
        {
            int tipoNum = random.Next(0, 3);
            char tipoChar = 'T';

            if (tipoNum == 0) tipoChar = 'I';
            else if (tipoNum == 1) tipoChar = 'L';
            else if (tipoNum == 2) tipoChar = 'T';

            pecaAtual = new Peca(tipoChar, 3, 0);

            if (!tabuleiro.PodeInserir(pecaAtual))
            {
                jogoAtivo = false;
                Console.WriteLine("Game Over: Sem espaço para nova peça.");
            }
            else
            {
                tabuleiro.InserirPeca(pecaAtual);
            }
        }

        private void ProcessarComando()
        {
            ConsoleKeyInfo tecla = Console.ReadKey(true);

            tabuleiro.Limpar(pecaAtual);

            int oldX = pecaAtual.getPosX();
            int oldY = pecaAtual.getPosY();
            bool houveRotacao = false;

            switch (tecla.Key)
            {
                case ConsoleKey.LeftArrow:
                    pecaAtual.MoverEsquerda();
                    break;
                case ConsoleKey.RightArrow:
                    pecaAtual.MoverDireita();
                    break;
                case ConsoleKey.DownArrow:
                    pecaAtual.MoverBaixo();
                    break;
                case ConsoleKey.A:
                    pecaAtual.RotacionarAntiHorario();
                    houveRotacao = true;
                    break;
                case ConsoleKey.H:
                    pecaAtual.RotacionarHorario();
                    houveRotacao = true;
                    break;
                case ConsoleKey.Q:
                    jogoAtivo = false;
                    return;
            }

            if (tabuleiro.PodeInserir(pecaAtual))
            {
                tabuleiro.InserirPeca(pecaAtual);
            }
            else
            {
                if (houveRotacao)
                {
                    if (tecla.Key == ConsoleKey.A) pecaAtual.RotacionarHorario();
                    else pecaAtual.RotacionarAntiHorario();
                }
                else
                {
                    pecaAtual.setPos(oldX, oldY);
                }

                tabuleiro.InserirPeca(pecaAtual);

                if (tecla.Key == ConsoleKey.DownArrow)
                {
                    FixarPeca();
                }
            }
        }

        private void FixarPeca()
        {
            jogador.AdicionarPontos(0, pecaAtual.getPontos());

            tabuleiro.VerificarLinhas(jogador);

            GerarNovaPeca();
        }
    }
}