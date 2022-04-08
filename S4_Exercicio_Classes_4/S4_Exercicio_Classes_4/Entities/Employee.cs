namespace S4_Exercicio_Classes_4.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public double GrossSalary { get; set; }
        public double Tax { get; set; }

        public Employee(string name, double grossSalary, double tax)
        {
            Name = name;
            GrossSalary = grossSalary;
            Tax = tax;
        }

        public double NetSalary()
        {
            return GrossSalary - Tax;
        }
        public void IncreaseSalary(double percentage)
        {
            GrossSalary = GrossSalary + ((GrossSalary * percentage) / 100);
        }

        public override string ToString()
        {
            return $"{Name}, $ {NetSalary():F2}";
        }
    }
}
