using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            Print(product, quantity);
        }

        static void Print(string product, int quantity)
        {
            double output = 0;

            switch (product)
            {
                case "coffee":
                    output = quantity * 1.50;
                    break;
                case "water":
                    output = quantity * 1;
                    break;
                case "coke":
                    output = quantity * 1.40;
                    break;
                case "snacks":
                    output = quantity * 2;
                    break;
            }

            Console.WriteLine($"{output:f2}");
        }
    }
}
