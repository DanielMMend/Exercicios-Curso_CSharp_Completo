using System.Collections.Generic;
using S9_Exercicio_Composicao_1.Entities.Enums;

namespace S9_Exercicio_Composicao_1.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int year, int month)
        {
            double contractsIncome = 0;
            foreach (HourContract hc in Contracts)
            {
                if (hc.Date.Year == year && hc.Date.Month == month)
                {
                    contractsIncome = contractsIncome + hc.TotalValue();
                }
            }

            return contractsIncome + BaseSalary;
        }
    }
}
