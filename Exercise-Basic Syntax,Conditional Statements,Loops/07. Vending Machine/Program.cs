using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            string input = Console.ReadLine();
            //actions
            double money = 0;
            while (input != "Start")
            {
                double currentCoin = double.Parse(input);

                if (currentCoin == 0.1 || currentCoin == 0.2 || currentCoin == 0.5 || currentCoin== 1 || currentCoin == 2)
                {
                    money += currentCoin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {currentCoin}");
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                switch (input)
                {
                    case "Nuts":
                        if (money >= 2)
                        {
                            Console.WriteLine($"Purchased {input.ToLower()}");
                            money -= 2;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (money >= 0.7)
                        {
                            Console.WriteLine($"Purchased {input.ToLower()}");
                            money -= 0.7;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (money >= 1.5)
                        {
                            Console.WriteLine($"Purchased {input.ToLower()}");
                            money -= 1.5;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (money >= 0.8)
                        {
                            Console.WriteLine($"Purchased {input.ToLower()}");
                            money -= 0.8;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (money >= 1)
                        {
                            Console.WriteLine($"Purchased {input.ToLower()}");
                            money -= 1;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                input = Console.ReadLine();
            }
            //ouput
            Console.WriteLine($"Change: {money:f2}");
        }
    }
}
