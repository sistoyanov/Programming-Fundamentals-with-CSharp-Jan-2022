using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
  
            int people = int.Parse(Console.ReadLine());
            string group = Console.ReadLine();
            string day = Console.ReadLine();

            //action
            double price = 0;

            switch (day)
            {
                case "Friday":
                    if (group == "Students")
                    {
                        price = 8.45;

                        if (people >= 30)
                        {
                            price *= 0.85;
                        }
                    }
                    else if (group == "Business")
                    {
                        price = 10.90;

                        if (people >= 100)
                        {
                            people -= 10;
                        }
                    }
                    else if (group == "Regular")
                    {
                        price = 15;

                        if (people > 9 && people < 21)
                        {
                            price *= 0.95;
                        }
                    }
                    break;
                case "Saturday":
                    if (group == "Students")
                    {
                        price = 9.80;

                        if (people >= 30)
                        {
                            price *= 0.85;
                        }
                    }
                    else if (group == "Business")
                    {
                        price = 15.60;

                        if (people >= 100)
                        {
                            people -= 10;
                        }
                    }
                    else if (group == "Regular")
                    {
                        price = 20;

                        if (people > 9 && people < 21)
                        {
                            price *= 0.95;
                        }
                    }
                    break;
                case "Sunday":
                    if (group == "Students")
                    {
                        price = 10.46;

                        if (people >= 30)
                        {
                            price *= 0.85;
                        }
                    }
                    else if (group == "Business")
                    {
                        price = 16;

                        if (people >= 100)
                        {
                            people -= 10;
                        }
                    }
                    else if (group == "Regular")
                    {
                        price = 22.50;

                        if (people > 9 && people < 21)
                        {
                            price *= 0.95;
                        }
                    }
                    break;
            }
            //output
            Console.WriteLine($"Total price: {people * price:f2}");
        }
    }
}
