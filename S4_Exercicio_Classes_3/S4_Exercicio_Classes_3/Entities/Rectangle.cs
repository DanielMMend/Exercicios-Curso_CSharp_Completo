using System;

namespace S4_Exercicio_Classes_3.Entities
{
    class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Area()
        {
            return Width * Height;
        }
        public double Perimeter()
        {
            return (Width * 2) + (Height * 2);
        }
        public double Diagonal()
        {
            return Math.Sqrt(Width * Width + Height * Height);
        }
    }
}
