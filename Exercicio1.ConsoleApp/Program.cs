using System;

namespace Exercicio1.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Imobiliária Imóbilis");

            Console.WriteLine("Digite o comprimento do terreno: ");
            double comprimento = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o altura do terreno: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            if (comprimento > altura && altura > 0)
            {
                double area = comprimento * altura;
                Console.WriteLine("A area do terreno é de " + area + "m²");
            }
            else
            {
                Console.WriteLine("ERRO!");
            }
            Console.ReadLine();
        }
    }
}
