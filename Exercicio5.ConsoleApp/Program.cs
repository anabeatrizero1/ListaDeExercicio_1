using System;

namespace Exercicio5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioInicial, salarioComAumento, salarioFinal;

            Console.Write("Digite o salário: ");
            salarioInicial = Convert.ToDouble(Console.ReadLine());

            salarioComAumento = salarioInicial + (salarioInicial * 0.15);
            salarioFinal = salarioComAumento - (salarioComAumento * 0.08);

            Console.WriteLine("Salário Inicial: R${0} ",  salarioInicial);
            Console.WriteLine("Salário com Aumento: R${0}", salarioComAumento);
            Console.WriteLine("Salário final (com os descontos dos impostos): R${0}", salarioFinal);

            Console.ReadKey();
        }
    }
}
