using System;
using System.Globalization;
using S11_Exercicio_Excecoes_1.Entities;
using S11_Exercicio_Excecoes_1.Entities.Exceptions;

namespace S11_Exercicio_Excecoes_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int rRN = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime rCI = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime rCO = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Reservation res = new Reservation(rRN, rCI, rCO);

                Console.WriteLine("\n" + res);

                Console.WriteLine("\nEnter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime newCI = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime newCO = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                res.UpdateDates(newCI, newCO);

                Console.WriteLine("\n" + res);
            }
            catch (DomainExecption e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
