using System;

namespace Trabalho_ATP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do jogador:");
            string nome = Console.ReadLine();

            Jogador jogador = new Jogador(nome);

            Jogo jogo = new Jogo(jogador);

            jogo.Iniciar();

            Console.WriteLine("Jogo encerrado. Pontuação salva.");
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}