namespace S6_Exercicio_Listas_2.Entities
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage)
        {
            double rise = (Salary * percentage) / 100;
            Salary = Salary + rise;
        }

        public override string ToString()
        {
            return $"{Id}: {Name}, {Salary:F2}";
        }
    }
}
