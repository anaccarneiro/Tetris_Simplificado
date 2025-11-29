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
            {
                for (int j = 0; j < 10; j++)
                    tabuleiro[i, j] = 0;
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
                }
                Console.WriteLine();
            }
        }
        public void Limpar(Peca peca)
        {
            int[,] forma = peca.getForma();
            int posX = peca.getPosX();
            int posY = peca.getPosY();

            for (int i = 0; i < forma.GetLength(0); i++)
            {
                for (int j = 0; j < forma.GetLength(1); j++)
                {
                    if (forma[i, j] == 1)
                    {
                        tabuleiro[posY + i, posX + j] = 0;
                    }
                }
            }
        } 
        public void InserirPeca()
        {

        }
        public void Atualizar()
        {

        }
        public void PodeInserir()
        {

        }
        public void VerificarLinhas()
        {

        }
    }
}
