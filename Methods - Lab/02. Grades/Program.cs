using System;

namespace _02._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            Print(number);
        }

        static void Print(double number)
        {
            string output = string.Empty;

            if (number >= 2 && number < 3)
            {
                output = "Fail";
            }
            else if (number >= 3 && number < 3.50)
            {
                output = "Poor";
            }
            else if (number >= 3.50 && number < 4.50)
            {
                output = "Good";
            }
            else if (number >= 4.50 && number < 5.50)
            {
                output = "Very good";
            }
            else if (number >= 5.50 && number <= 6)
            {
                output = "Excellent";
            }

            Console.WriteLine(output);
        }
    }
}
