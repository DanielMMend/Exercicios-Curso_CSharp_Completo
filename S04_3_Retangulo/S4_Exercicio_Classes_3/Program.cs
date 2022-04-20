using System;
using System.Globalization;
using S4_Exercicio_Classes_3.Entities;

namespace S4_Exercicio_Classes_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre a largura e altura do retângulo: ");
            double rWidth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double rHeight = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Rectangle ret = new Rectangle(rWidth, rHeight);

            Console.WriteLine($"AREA = {ret.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERIMETRO = {ret.Perimeter().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL = {ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
