using System;

namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            Console.WriteLine(GetMax(type, first, second));

        }

        static string GetMax(string type, string first, string second)
        {
            string output = string.Empty;

            if (type == "int")
            {
                output = int.Parse(first) >= int.Parse(second) ? first : second;

            }
            else if (type == "char")
            {
                output = char.Parse(first) >= char.Parse(second) ? first : second;
            }
            else
            {
                output = first.CompareTo(second) > 0 ? first : second;
            }

            return output;
        }
    }
}
