using System;
using System.Globalization;
using order_summary_generator.Entities.Enum;
using order_summary_generator.Entities;
using System.ComponentModel;
namespace orderSumaryGenerator
{
    class Program { 
      static void Main(String[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime bithDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, bithDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.WriteLine("How many items to this order?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                
                Product product = new Product(productName,price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());  

                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.Items.Add(orderItem);
            
            
            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);




        }
      
     
    }

}