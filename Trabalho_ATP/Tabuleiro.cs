using System;

namespace Trabalho_ATP
{
    internal class Tabuleiro
    {
        public int[,] tabuleiro;

        public Tabuleiro()
        {
            tabuleiro = new int[20, 10];
            for (int i = 0; i < 20; i++)
                for (int j = 0; j < 10; j++)
                    tabuleiro[i, j] = 0;
        }

        public void Renderizar()
        {
            Console.Clear();
            Console.WriteLine("TABULEIRO:");
            Console.WriteLine("------------");

            for (int i = 0; i < 20; i++)
            {
                Console.Write("|"); 
                for (int j = 0; j < 10; j++)
                {
                    if (tabuleiro[i, j] == 0)
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write("1"); 
                    }
                }
                Console.WriteLine("|"); 
            }
            Console.WriteLine("------------");
        }

        public void Limpar(Peca peca)
        {
            int[,] forma = peca.getForma();
            int posX = peca.getPosX();
            int posY = peca.getPosY();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (forma[i, j] == 1)
                    {
                        if (posY + i < 20 && posX + j < 10 && posX + j >= 0)
                            tabuleiro[posY + i, posX + j] = 0;
                    }
                }
            }
        }

        public void InserirPeca(Peca peca)
        {
            int[,] forma = peca.getForma();
            int posX = peca.getPosX();
            int posY = peca.getPosY();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (forma[i, j] == 1)
                    {
                        if (posY + i < 20 && posX + j < 10 && posX + j >= 0)
                            tabuleiro[posY + i, posX + j] = 1;
                    }
                }
            }
        }

        public void Atualizar(Peca peca)
        {
            InserirPeca(peca);
            Renderizar();
        }

        public bool PodeInserir(Peca peca)
        {
            int[,] forma = peca.getForma();
            int posX = peca.getPosX();
            int posY = peca.getPosY();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (forma[i, j] == 1)
                    {
                        int linhaAtual = posY + i;
                        int colAtual = posX + j;

                        if (colAtual < 0 || colAtual >= 10 || linhaAtual >= 20)
                            return false;

                        if (linhaAtual >= 0 && tabuleiro[linhaAtual, colAtual] == 1)
                            return false;
                    }
                }
            }
            return true;
        }

        public void VerificarLinhas(Jogador jogador)
        {
            int linhasEliminadas = 0;

            for (int linha = 0; linha < 20; linha++)
            {
                bool linhaCheia = true;
                for (int col = 0; col < 10; col++)
                {
                    if (tabuleiro[linha, col] == 0)
                    {
                        linhaCheia = false;
                    }
                }

                if (linhaCheia)
                {
                    linhasEliminadas++;
                    for (int l = linha; l > 0; l--)
                    {
                        for (int c = 0; c < 10; c++)
                        {
                            tabuleiro[l, c] = tabuleiro[l - 1, c];
                        }
                    }
                    for (int c = 0; c < 10; c++)
                        tabuleiro[0, c] = 0;
                }
            }

            if (linhasEliminadas > 0)
            {
                jogador.AdicionarPontos(linhasEliminadas, 0);
            }
        }
    }
}