namespace S10_Exercicio_Heranca_4.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures)
        {
            Name = name;
            AnualIncome = anualIncome;
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000.00)
            {
                return (AnualIncome * 0.15) - (HealthExpenditures / 2.0);
            }
            else
            {
                return (AnualIncome * 0.25) - (HealthExpenditures / 2.0);
            }
        }
    }
}
