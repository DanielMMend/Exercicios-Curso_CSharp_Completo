namespace S10_Exercicio_Heranca_4.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees)
        {
            Name = name;
            AnualIncome = anualIncome;
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
