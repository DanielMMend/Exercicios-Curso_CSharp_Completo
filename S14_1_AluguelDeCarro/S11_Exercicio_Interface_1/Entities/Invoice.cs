using System.Globalization;

namespace S11_Exercicio_Interface_1.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment()
        {
            return BasicPayment + Tax;
        }

        public override string ToString()
        {
            return 
                $"INVOICE:" +
                $"\nBasic payment: {BasicPayment.ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\nTax: {Tax.ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\nTotal payment: {TotalPayment().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
