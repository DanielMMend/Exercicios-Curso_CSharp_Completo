using System;
using System.Globalization;

namespace S14_Exercicio_Interface_3.Entities
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{Name},{Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(object obj)
        {
            if (obj is Employee == false)
            {
                throw new ArgumentException("Comparing error: argument is not an Employee");
            }
            Employee other = obj as Employee;
            return Name.CompareTo(other.Name);
        }
    }
}
