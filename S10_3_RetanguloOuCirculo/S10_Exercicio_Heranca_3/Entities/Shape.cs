using S10_Exercicio_Heranca_3.Entities.Enums;

namespace S10_Exercicio_Heranca_3.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
