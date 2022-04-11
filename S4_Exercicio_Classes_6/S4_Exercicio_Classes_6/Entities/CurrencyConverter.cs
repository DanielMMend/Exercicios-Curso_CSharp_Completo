namespace S4_Exercicio_Classes_6.Entities
{
    class CurrencyConverter
    {
        public double DollarQuote { get; set; }
        public static double IOF = 1.06;

        public CurrencyConverter(double dollarQuote)
        {
            DollarQuote = dollarQuote;
        }

        public double FinalValue(double dollarAmount)
        {
            return (dollarAmount * DollarQuote) * IOF;
        }
    }
}
