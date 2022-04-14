using S10_Exercicio_Heranca_3.Entities.Enums;

namespace S10_Exercicio_Heranca_3.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(Color color, double width, double height) : base(color)
        {
            Color = color;
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
