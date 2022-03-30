using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Extract_Person_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();

                int idxBeforeName = input.IndexOf('@');
                int idxAfterOfName = input.IndexOf('|');

                string name = input.Substring(idxBeforeName + 1, (idxAfterOfName - idxBeforeName) - 1);

                int idxBeforeAge = input.IndexOf('#');
                int idxAfterAge = input.IndexOf('*');

                string age = input.Substring(idxBeforeAge + 1, (idxAfterAge - idxBeforeAge) - 1);

                Console.WriteLine($"{name} is {age} years old.");
            }

        }
    }
}
