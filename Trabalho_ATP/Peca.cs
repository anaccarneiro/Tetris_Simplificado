using System;

namespace Trabalho_ATP
{
    internal class Peca
    {
        private int[,] forma;
        private char tipo;
        private int posX, posY;
        private int pontos;

        public Peca(char tipo, int posX, int posY)
        {
            setForma(tipo);
            setTipo(tipo);
            setPos(posX, posY);
            setPontos(tipo);
        }

        // MÉTODOS
        public void RotacionarAntiHorario()
        {
            int[,] formaTemp = new int[3, 3];
            for (int minF = 0, maxF = this.forma.GetLength(0) - 1; minF < this.forma.GetLength(0); minF++, maxF--)
            {
                for (int minD = 0; minD < this.forma.GetLength(1); minD++)
                {
                    formaTemp[minF, minD] = this.forma[minD, maxF];
                }
            }
            this.forma = formaTemp;
        }
        public void RotacionarHorario()
        {
            int[,] formaTemp = new int[3, 3];
            for (int minF = 0, maxF = this.forma.GetLength(0) - 1; minF < this.forma.GetLength(0); minF++, maxF--)
            {
                for (int minD = 0, maxD = this.forma.GetLength(1) - 1; minD < this.forma.GetLength(1); minD++, maxD--)
                {
                    formaTemp[minF, minD] = this.forma[maxD, minF];
                }
            }
            this.forma = formaTemp;
        }

        public void MoverEsquerda()
        {

        }
        public void MoverDireita()
        {

        }
        public void MoverBaixo()
        {

        }

        // SET
        public void setForma(char tipo)
        {
            if (tipo == 'I')
                this.forma = new int[,] { { 0, 1, 0 }, { 0, 1, 0 }, { 0, 1, 0 } };
            else if (tipo == 'T')
                this.forma = new int[,] { { 1, 1, 1 }, { 0, 1, 0 }, { 0, 1, 0 } };
            else if (tipo == 'L')
                this.forma = new int[,] { { 0, 1, 0 }, { 0, 1, 0 }, { 1, 1, 1 } };
        }
        public void setTipo(char tipo)
        {
            this.tipo = tipo;
        }
        public void setPos(int posX, int posY)
        {
            this.posX = posX;
            this.posY = posY;
        }
        public void setPontos(char tipo)
        {
            if (tipo == 'I')
                this.pontos = 3;
            else if (tipo == 'L')
                this.pontos = 4;
            else if (tipo == 'T')
                this.pontos = 5;
        }
        // GET
        public int[,] getForma()
        {
            return this.forma;
        }
        public int getPontos()
        {
            return this.pontos;
        }
        public int getPosX()
        {
            return this.posX;
        }
        public int getPosY()
        {
            return this.posY;
        }
        public char getTipo()
        {
            return this.tipo;
        }
    }
}
