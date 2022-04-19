using System;
namespace S14_Exercicio_Interface_2.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; } = new List<Installment>();

        public void AddInstalment(Installment installment)
        {
            Installments.Add(installment);
        }
        public void RemoveInstalment(Installment installment)
        {
            Installments.Remove(installment);
        }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }
    }
}
