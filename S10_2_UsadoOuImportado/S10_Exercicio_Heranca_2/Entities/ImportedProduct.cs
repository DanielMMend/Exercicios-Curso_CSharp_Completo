﻿namespace S10_Exercicio_Heranca_2.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double customsFee)
        {
            Name = name;
            Price = price;
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
        public override string PriceTag()
        {
            return $"{Name} ${TotalPrice():F2} (Customs fee: ${CustomsFee})";
        }
    }
}
