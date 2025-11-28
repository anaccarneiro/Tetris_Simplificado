using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Jogador
    {
        public string nome { get; set; }
        public int pontuacaoFinal { get; set; }

        public Jogador(string nome)
        {
            this.nome = nome;
            this.pontuacaoFinal = 0;
        }

        public void AdicionarPontos(int pontos)
        {
            pontuacaoFinal += pontos;
        }

        public void Salvar(string caminho)
        {
            using (StreamWriter sw = new StreamWriter(caminho, true))
            {
                sw.WriteLine($"{nome}:{pontuacaoFinal}");
            }
        }
    }
}
