using System;

namespace S10_Exercicio_Heranca_2.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufactureDate)
        {
            Name = name;
            Price = price;
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return $"{Name} (used) ${Price:F2} (Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}
