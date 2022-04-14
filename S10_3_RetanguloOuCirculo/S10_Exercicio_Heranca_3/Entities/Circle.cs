using System;
using S10_Exercicio_Heranca_3.Entities.Enums;

namespace S10_Exercicio_Heranca_3.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(Color color, double radius) : base(color)
        {
            Color = color;
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2.0);
        }
    }
}
