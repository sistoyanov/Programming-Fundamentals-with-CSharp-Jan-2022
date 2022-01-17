using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int orders = int.Parse(Console.ReadLine());
            //action
            double totalPrice = 0;
            for (int i = 1; i <= orders; i++)
            {
                double price = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                double count = double.Parse(Console.ReadLine());
                double dayPrice = ((days * count) * price);
                totalPrice += dayPrice;
                Console.WriteLine($"The price for the coffee is: ${dayPrice:f2}");
            }
            //output
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
