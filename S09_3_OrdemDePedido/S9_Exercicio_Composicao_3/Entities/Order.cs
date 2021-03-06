using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using S9_Exercicio_Composicao_3.Entities.Enums;

namespace S9_Exercicio_Composicao_3.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double total = 0;
            foreach (OrderItem oi in Items)
            {
                total = total + oi.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Order moment: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine($"Order status: {Status}");
            sb.AppendLine($"Client: {Client.Name} ({Client.BirthDate:d}) - {Client.Email}");
            sb.AppendLine("Order items:");
            foreach (OrderItem oi in Items)
            {
                sb.AppendLine(
                    $"{oi.Product.Name}," +
                    $" ${oi.Price.ToString("F2", CultureInfo.InvariantCulture)}," +
                    $" Quantity: {oi.Quantity}," +
                    $" Subtotal: ${oi.SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");
            }
            sb.AppendLine($"Total price: ${Total().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
