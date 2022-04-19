using System;
using System.Globalization;
using S11_Exercicio_Interface_1.Entities;
using S11_Exercicio_Interface_1.Services;

namespace S11_Exercicio_Interface_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data:");
            Console.Write("Car model: ");
            string vModel = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime crStart = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime crFinish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Enter price per hour: ");
            double rsPPH = double.Parse(Console.ReadLine());
            Console.Write("Enter price per day: ");
            double rsPPD = double.Parse(Console.ReadLine());

            //Entities
            Vehicle vehicle = new Vehicle(vModel);
            CarRental carRental = new CarRental(crStart, crFinish, vehicle);
            //Services
            BrazilTaxService taxService = new BrazilTaxService();
            RentalService rentalService = new RentalService(rsPPH, rsPPD, taxService);

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("\n" + carRental.Invoice);
        }
    }
}
