using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_ATP
{
    public class Jogador
    {
        public string Nome { get; set; }
        public int PontuacaoFinal { get; set; }

        public Jogador(string nome)
        {
            Nome = nome;
            PontuacaoFinal = 0;
        }

        public void AdicionarPontos(int linhasEliminadas, int pontosDaPeca)
        {
            int pontosPorLinhas = CalcularPontosLinhas(linhasEliminadas);
            PontuacaoFinal += pontosPorLinhas + pontosDaPeca;
        }

        private int CalcularPontosLinhas(int linhas)
        {
            switch (linhas)
            {
                case 1: return 100;
                case 2: return 300;
                case 3: return 500;
                case 4: return 800;
                default: return 0;
            }
        }

        public void Salvar(string caminho)
        {
            using (StreamWriter sw = new StreamWriter(caminho, true))
            {
                sw.WriteLine($"{Nome};{PontuacaoFinal}");
            }
        }
    }

}