using System;
using System.Globalization;
using System.Collections.Generic;
using S14_Exercicio_Interface_2.Entities;
using S14_Exercicio_Interface_2.Services;

namespace S14_Exercicio_Interface_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data:");
            Console.Write("Number: ");
            int cNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime cDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double cValue = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(cNumber, cDate, cValue);
            contract.Installments = new List<Installment>();
            PaypalService paymentService = new PaypalService();
            ContractService contractService = new ContractService(paymentService);

            contractService.ProcessContract(contract, installments);

            Console.WriteLine("\nInstallments:");
            foreach (Installment inst in contract.Installments)
            {
                Console.WriteLine(inst);
            }
        }
    }
}
