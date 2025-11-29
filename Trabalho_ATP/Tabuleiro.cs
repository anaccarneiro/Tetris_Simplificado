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
                    if (tabuleiro[i,j] == 0)
                    {
                        Console.Write(" ");
                    }
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
        public void InserirPeca(Peca peca)
        {
            int[,] forma = peca.getForma();
            peca.setPos(0,3);

            for (int linhaT = 0; linhaT < 3; linhaT++)
            {
                for (int colunaT = 3, colunaF = 0; colunaT < 6; colunaT++, colunaF++)
                {
                    tabuleiro[linhaT, colunaT] = forma[linhaT,colunaF];
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

            for (int linha = posY; linha < 20; linha++)
            {
                for (int coluna = posX; coluna < 10; coluna++)
                {
                    if (forma[linha, coluna] == 1)
                        return false;
                    else
                        return true;
                }
            }
        }
        public void VerificarLinhas()
        {
            
        }
    }
}
