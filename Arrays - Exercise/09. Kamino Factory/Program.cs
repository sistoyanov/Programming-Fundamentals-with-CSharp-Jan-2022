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

            int sampleCounter = 0;

            int[] bestDNA = new int[num];
            int bestLenght = 1;
            int bestStartIndex = 0;
            int bestDNASum = 0;
            int bestSampleCount = 0;

            while (input != "Clone them!")
            {
                sampleCounter++;
                
                int[] currentDNA = new int[num];
                currentDNA = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int lenght = 1;
                int bestCurrentLenght = 1;
                int startIndex = 0;
                int currentDNASum = 0;

                for (int i = 0; i < currentDNA.Length - 1; i++)
                {

                    if (currentDNA[i] == currentDNA[i + 1])
                    {
                        lenght++;
                    }
                    else
                    {
                        lenght = 1;
                    }

                    if (lenght > bestCurrentLenght)
                    {
                        bestCurrentLenght = lenght;
                        startIndex = i;
                    }

                    currentDNASum += currentDNA[i];
                }

                currentDNASum += currentDNA[num - 1];

                if (bestCurrentLenght > bestLenght)
                {
                    bestLenght = bestCurrentLenght;
                    bestStartIndex = startIndex;
                    bestDNASum = currentDNASum;
                    bestSampleCount = sampleCounter;
                    bestDNA = currentDNA;
                }
                else if (bestCurrentLenght == bestLenght)
                {
                    if (startIndex < bestStartIndex)
                    {
                        bestLenght = bestCurrentLenght;
                        bestStartIndex = startIndex;
                        bestDNASum = currentDNASum;
                        bestSampleCount = sampleCounter;
                        bestDNA = currentDNA;
                    }
                    else if (startIndex == bestStartIndex)
                    {
                        if (currentDNASum > bestDNASum)
                        {
                            bestLenght = bestCurrentLenght;
                            bestStartIndex = startIndex;
                            bestDNASum = currentDNASum;
                            bestSampleCount = sampleCounter;
                            bestDNA = currentDNA;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSampleCount} with sum: {bestDNASum}.");
            Console.WriteLine(String.Join(" ", bestDNA));
        }
    }
}
