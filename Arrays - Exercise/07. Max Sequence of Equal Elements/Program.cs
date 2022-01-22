using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 0;
            int repetable = 0;
            int currentCounter = 0;
            

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    currentCounter++;
                    
                    if (currentCounter > counter)
                    {
                        repetable = numbers[i];
                        counter++;
                    }
                    
                }
                else
                {
                    currentCounter = 0;
                }
            }

            for (int j = 1; j <= counter + 1; j++)
            {
                Console.Write($"{repetable} ");
            }
        }

            
    }
}
