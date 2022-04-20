using System;
using System.Globalization;
using S4_Exercicio_Classes_6.Entities;

namespace S4_Exercicio_Classes_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double dq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double da = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            CurrencyConverter cc = new CurrencyConverter(dq);
            Console.WriteLine($"Valor a ser pago em reais = {cc.FinalValue(da).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
