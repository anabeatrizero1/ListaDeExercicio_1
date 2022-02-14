using System;

namespace Exercicio2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Padaria Hotpão");

            Console.WriteLine("Digite quantos pães franceses foram vendidos: ");
            int paesFranceses = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digire quentas broas foram vendidas: ");
            int broas = Convert.ToInt32(Console.ReadLine());

            double poupanca = (0.12 * paesFranceses + 1.50 * broas) * 0.10;
            Console.WriteLine("O valor de 10% direcionado á poupança é de R$ " + Math.Round(poupanca, 2).ToString());

            Console.ReadLine();
        }
    }
}
