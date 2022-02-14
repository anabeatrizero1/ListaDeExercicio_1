using System;

namespace Exercicio4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tempCeusius, tempFahrenheit;
            Console.WriteLine("Conversor de Graus Celsius para Fahrenheit");
            Console.Write("Digite a temperatura Celsius: ");
            tempCeusius = Convert.ToDouble(Console.ReadLine());

            tempFahrenheit = (tempCeusius * 1.8) + 32;
            Console.WriteLine("Temperatura em Fahrenheit: °{0}", tempFahrenheit);
            Console.ReadKey();
        }
    }
}
