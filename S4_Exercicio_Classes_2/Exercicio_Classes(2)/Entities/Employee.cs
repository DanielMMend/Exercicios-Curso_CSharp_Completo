namespace Exercicio_Classes_2_.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public double AverageSalary(Employee otherEmployee)
        {
            return (Salary + otherEmployee.Salary) / 2;
        }
    }
}
