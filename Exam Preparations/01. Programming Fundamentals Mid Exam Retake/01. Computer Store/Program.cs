using System;

namespace _01._Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            decimal sum = 0;

            while (input != "special" && input != "regular")
            {
                decimal currentPrice = decimal.Parse(input);

                if (currentPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                    input = Console.ReadLine();
                    continue;
                }

                sum += currentPrice;

                input = Console.ReadLine();
            }

            if (sum > 0)
            {
                decimal tax = sum * (decimal)0.20;
                decimal price = sum + tax;

                if (input == "special")
                {
                    price *= (decimal)0.90;
                }

                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {sum:f2}$");
                Console.WriteLine($"Taxes: {tax:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {price:f2}$");
            }
            else
            {
                Console.WriteLine("Invalid order!");
            }
        }
    }
}
