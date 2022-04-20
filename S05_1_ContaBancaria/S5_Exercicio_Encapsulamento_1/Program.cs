using System;
using System.Globalization;
using S5_Exercicio_Encapsulamento_1.Entities;

namespace S5_Exercicio_Encapsulamento_1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bAcc;

            Console.Write("Entre o número da conta: ");
            int accNumber = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string accHolder = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            string sn = Console.ReadLine();
            if (sn == "s")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double initDep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                bAcc = new BankAccount(accNumber, accHolder, initDep);
            }
            else
            {
                bAcc = new BankAccount(accNumber, accHolder, 0.0);
            }

            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(bAcc);

            Console.Write("\nEntre um valor para depósito: ");
            double deposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados da conta atualizados: ");
            bAcc.Deposit(deposit);
            Console.WriteLine(bAcc);

            Console.Write("\nEntre um valor para saque: ");
            double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados da conta atualizados: ");
            bAcc.Withdraw(withdraw);
            Console.WriteLine(bAcc);
        }
    }
}
