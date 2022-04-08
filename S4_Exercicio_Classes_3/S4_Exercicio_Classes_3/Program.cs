using System;
using S4_Exercicio_Classes_3.Entities;

namespace S4_Exercicio_Classes_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre a largura e altura do retângulo: ");
            double rWidth = double.Parse(Console.ReadLine());
            double rHeight = double.Parse(Console.ReadLine());
            Rectangle ret = new Rectangle(rWidth, rHeight);

            Console.WriteLine($"AREA = {ret.Area():F2}");
            Console.WriteLine($"PERIMETRO = {ret.Perimeter():F2}");
            Console.WriteLine($"DIAGONAL = {ret.Diagonal():F2}");
        }
    }
}
