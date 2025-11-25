using System;

namespace Trabalho_ATP
{
    internal class Tabuleiro
    {
        public char[,] tabuleiro;

        public Tabuleiro()
        {
            tabuleiro = new char[20, 10];

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 10; j++)
                    tabuleiro[i, j] = '.';
            }
        }

        public void Renderizar()
        {
            Console.Clear();

            for (int i = 0; i < 20; i++)
            {


                for (int j = 0; j < 10; j++)
                {
                    Console.Write(tabuleiro[i, j]);
                    int posY = j;
                }
                Console.WriteLine();
            }
        }
        public void Limpar(int posX, int posY, int[,] forma)
        {
            for (int i = 0; i < forma.GetLength(0); i++)
            {
                for (int j = 0; j < forma.GetLength(1); j++)
                {
                    if (forma[i, j] == 1)
                    {
                        tabuleiro[posY + i, posX + j] = '.';
                    }
                }
            }
        }
    }
}
