using System;

namespace Exercicio3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dias de Vida");
            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            int diasDeVida = idade * 365;
            Console.WriteLine(nome + ", você já viveu " + diasDeVida + " dias!");
            Console.ReadLine();
        }
    }
}
