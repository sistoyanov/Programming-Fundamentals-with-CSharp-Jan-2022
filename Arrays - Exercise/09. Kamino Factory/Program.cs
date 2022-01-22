using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            
            int[] bestDNS = new int[num];
            int sampleCounter = 0;
            int bestSampleNumber = 0;

            int bestSampOnesCount = 0;

            while (input != "Clone them!")
            {
                int currentOnesCounter = 0;
                sampleCounter++;
                int[] numbers = new int[num];
                numbers = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] == 1)
                    {
                        currentOnesCounter++;
                    }
                }

                for (int i = 0; i < numbers.Length - 1; i++)
                {

                    if (numbers[i] == numbers[i + 1] && numbers[i] == 1 && numbers[i + 1] == 1)
                    {
                     
                        bestDNS = numbers;
                        bestSampleNumber = sampleCounter;
                        bestSampOnesCount = currentOnesCounter;

                    }

                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSampleNumber} with sum: {bestSampOnesCount}.");
            Console.WriteLine(String.Join(" ", bestDNS));
        }
    }
}
