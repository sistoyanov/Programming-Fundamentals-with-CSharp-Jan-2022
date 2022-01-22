using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                long sum = 0;
                string[] input = Console.ReadLine().Split(' ');
                long maxValue = long.MinValue;

                foreach (var item in input)
                {
                    long current = long.Parse(item);

                    if (current > maxValue)
                    {
                        maxValue = current;
                    }
                }

                while (maxValue != 0)
                {
                    sum += maxValue % 10;
                    maxValue /= 10;
                }

                Console.WriteLine(Math.Abs(sum));
            }
        }
    }
    
}