using System;
using Uso_de_enumeracoes.Entities;
using Uso_de_enumeracoes.Entities.Enum;

namespace Uso_de_enumeracoes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter Client Data:");
            Console.Write("Name:");
            string name = Console.ReadLine();

            Console.Write("Email:");
            string email = Console.ReadLine();

            Console.Write("BirthDate:");
            DateTime birth = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birth);

            Console.WriteLine("Enter Order Data:");

            Console.Write("Status:");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.Write("How many items to this order?");
            int qtd = int.Parse(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine("Enter " + i + " item data: ");
                Console.Write("Product:");
                string product = Console.ReadLine();

                Console.Write("Price:");
                double price = double.Parse(Console.ReadLine());

                Console.Write("Quantity:");
                int quantity = int.Parse(Console.ReadLine());

                Product product1 = new Product(product, price);
                OrderItem orderItem = new OrderItem(quantity, price, product1);
                Console.WriteLine();
                Console.WriteLine();

                order.Additem(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}