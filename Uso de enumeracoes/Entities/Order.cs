using System;
using System.Collections.Generic;
using System.Text;
using Uso_de_enumeracoes.Entities.Enum;

namespace Uso_de_enumeracoes.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }
        public Product Product { get; set; }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void Additem(OrderItem item)
        {
            Items.Add(item);
        }

        public void AddRemove(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in Items)
            {
                sum += item.Subtotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("Order Summary:");
            str.Append("Order moment: ");
            str.Append(Moment);
            str.Append("Order status: ");
            str.Append(Status);
            str.AppendLine();
            str.Append("Client: ");
            str.Append(Client.Name);
            str.Append(" (");
            str.Append(Client.BirthDate);
            str.Append(") - ");
            str.Append(Client.Email);
            str.AppendLine();
            str.AppendLine("Order Items:");
            foreach (OrderItem item in Items)
            {
                str.AppendLine(item.ToString());
            }
            str.AppendLine("Total price: $" + Total());
            return str.ToString();
        }
    }
}