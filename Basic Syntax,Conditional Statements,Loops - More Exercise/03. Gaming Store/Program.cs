using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double totalPrice = 0;

            while (command != "Game Time")
            {
                double price = 0;

                if (command == "OutFall 4")
                {
                    price = 39.99;
                }
                else if (command == "CS: OG")
                {
                    price = 15.99;
                }
                else if (command == "Zplinter Zell")
                {
                    price = 19.99;
                }
                else if (command == "Honored 2")
                {
                    price = 59.99;
                }
                else if (command == "RoverWatch")
                {
                    price = 29.99;
                }
                else if (command == "RoverWatch Origins Edition")
                {
                    price = 39.99;
                }
                else
                {
                    Console.WriteLine("Not Found");
                    command = Console.ReadLine();
                    continue;
                }

                if (money >= price)
                {
                    totalPrice += price;
                    money -= price;
                    Console.WriteLine($"Bought {command}");

                    if (money <= 0)
                    {
                        break;
                    }

                    command = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                    command = Console.ReadLine();
                }
                 
            }

            if (money > 0)
            {
                Console.WriteLine($"Total spent: ${totalPrice:f2}. Remaining: ${money:f2}");
            }
            else
            {
                Console.WriteLine("Out of money!");
            }


        }
    }
}
