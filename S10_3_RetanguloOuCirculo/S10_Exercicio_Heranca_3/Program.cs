using System;
using System.Collections.Generic;
using S10_Exercicio_Heranca_3.Entities;
using S10_Exercicio_Heranca_3.Entities.Enums;

namespace S10_Exercicio_Heranca_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nShape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                string rc = Console.ReadLine();
                Console.Write("Color (Black/Blue/Red): ");
                Color sColor = Enum.Parse<Color>(Console.ReadLine());
                if (rc == "r")
                {
                    Console.Write("Width: ");
                    double rWidth = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double rHeight = double.Parse(Console.ReadLine());
                    Rectangle rec = new Rectangle(sColor, rWidth, rHeight);
                    list.Add(rec);
                }
                else if (rc == "c")
                {
                    Console.Write("Radius: ");
                    double cRadius = double.Parse(Console.ReadLine());
                    Circle circ = new Circle(sColor, cRadius);
                    list.Add(circ);
                }
                else
                {
                    Console.WriteLine("Unexpected error: Shape must be classified as rectangle(r) or circle(c);");
                    Environment.Exit(0);
                }
            }

            Console.WriteLine("\nSHAPE AREAS:");
            foreach (Shape s in list)
            {
                Console.WriteLine(s.Area().ToString("F2"));
            }
        }
    }
}
