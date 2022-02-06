using System;

namespace _01._Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string secondInput = Console.ReadLine();
            Console.WriteLine(Output(input, secondInput));
        }

        static string Output(string input, string secondInput)
        {
            string output = string.Empty;

            switch (input)
            {
                case "int":
                    output = (double.Parse(secondInput) * 2).ToString();
                    break;
                case "real":
                    double result = double.Parse(secondInput) * 1.5;
                    output = $"{result:f2}".ToString();
                    
                    break;
                case "string":
                    output = $"${secondInput}$";
                    break;
                default:
                    break;
            }

            return output;
        }
    }
}
