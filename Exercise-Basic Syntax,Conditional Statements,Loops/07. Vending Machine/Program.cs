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

                if (currentCoin == 0.1 || currentCoin == 0.2 || currentCoin == 0.5 || currentCoin == 1 || currentCoin == 2)
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
                if (input == "Nuts" || input == "Water" || input == "Crisps" || input == "Soda" || input == "Coke")
                {
                    bool isBought = false;
                    switch (input)
                    {
                        case "Nuts":
                            if (money >= 2)
                            {
                                isBought = true;
                                money -= 2;
                            }
                            break;
                        case "Water":
                            if (money >= 0.7)
                            {
                                isBought = true;
                                money -= 0.7;
                            }
                            break;
                        case "Crisps":
                            if (money >= 1.5)
                            {
                                isBought = true;
                                money -= 1.5;
                            }
                            break;
                        case "Soda":
                            if (money >= 0.8)
                            {
                                isBought = true;
                                money -= 0.8;
                            }
                            break;
                        case "Coke":
                            if (money >= 1)
                            {
                                isBought = true;
                                money -= 1;
                            }
                            break; 
                    }
                    Console.WriteLine(isBought ? $"Purchased {input.ToLower()}" : "Sorry, not enough money");
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                input = Console.ReadLine();
            }
            //ouput
            Console.WriteLine($"Change: {money:f2}");
        } 
    }

}
