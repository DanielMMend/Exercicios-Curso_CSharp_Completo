using System;
using System.Globalization;
using S9_Exercicio_Composicao_3.Entities;
using S9_Exercicio_Composicao_3.Entities.Enums;

namespace S9_Exercicio_Composicao_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string cName = Console.ReadLine();
            Console.Write("Email: ");
            string cEmail = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime cBirth = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Client client = new Client(cName, cEmail, cBirth);

            Console.WriteLine("\nEnter order data:");
            Console.Write("Status: ");
            OrderStatus os = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, os, client);

            Console.Write("\nHow many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nEnter #{i} item data:");
                Console.Write("Product name: ");
                string pName = Console.ReadLine();
                Console.Write("Product price: ");
                double pPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int pQuantity = int.Parse(Console.ReadLine());

                Product product = new Product(pName, pPrice);
                OrderItem orderItem = new OrderItem(pQuantity, pPrice, product);
                order.Items.Add(orderItem);
            }

            Console.WriteLine("\nORDER SUMMARY:");
            Console.WriteLine(order);
            
        }
    }
}
