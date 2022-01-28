using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            char operant = char.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine(Calculator(num1, operant, num2));
        }

        static double Calculator(double num1, char operant, double num2)
        {
            double sum = 0;

            switch (operant)
            {
                case '/':
                    sum = num1 / num2;
                    break;
                case '*':
                    sum = num1 * num2;
                    break;
                case '+':
                    sum = num1 + num2;
                    break;
                case '-':
                    sum = num1 - num2;
                    break;

            }

            return sum;
        }
    }
}
