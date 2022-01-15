using System;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                int factorial = 1;
                for (int j = 1; j <= int.Parse(num[i].ToString()); j++)
                {
                    factorial *= j;
                }
                sum += factorial;

            }

            if (sum == int.Parse(num))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
