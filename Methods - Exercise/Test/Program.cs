using System;
using System.Linq;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
           string commmand;
            
            while ((commmand = Console.ReadLine()) != "end")
            {
                string[] cmdArg = commmand.Split(' ');

                string cmdType = cmdArg[0];

                if (cmdType == "exchange")
                {
                    int exchangeIndex = int.Parse(cmdArg[1]);

                    if (exchangeIndex < 0 || exchangeIndex >= numbers.Length)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers = ExchangeArrayParts(numbers, exchangeIndex);
                }
                
                else if (cmdType == "max" || cmdType == "min")
                {
                    string oddOrEven = cmdArg[1];

                    int maxIndex = MaxElementOfTypeIndex(numbers, oddOrEven);
                    int minIndex = MinElementOfTypeIndex(numbers, oddOrEven);

                    if (maxIndex == -1 || minIndex == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        if (cmdType == "max")
                        {
                            Console.WriteLine(maxIndex);
                        }
                        else
                        {
                            Console.WriteLine(minIndex);
                        }
                        
                    }
                }

                else if (cmdType == "first" || cmdType == "last")
                {
                    int count = int.Parse(cmdArg[1]);
                    string oddOrEven =cmdArg[2];

                    if (count > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    if (cmdType == "first")
                    {
                        PrintsFirstElementsOfType(numbers, count, oddOrEven);
                    }
                    else
                    {
                        PrintsLastElementsOfType(numbers, count, oddOrEven);
                    }

                }
            }

            Console.WriteLine(ArrayToStringFormat(numbers, numbers.Length));
        }

        static int[] ExchangeArrayParts(int[] numbers, int index)
        {
            int[] exchangedNumbers = new int[numbers.Length];
            int exchangedNumbersIndex = 0;

            for (int i = index + 1; i < numbers.Length; i++)
            {
                exchangedNumbers[exchangedNumbersIndex] = numbers[i];
                exchangedNumbersIndex++;
            }

            for (int i = 0; i <= index; i++)
            {
                exchangedNumbers[exchangedNumbersIndex] = numbers[i];
                exchangedNumbersIndex++;
            }

            return exchangedNumbers;
        }

        static int MaxElementOfTypeIndex(int[] numbers, string oddOrEevn)
        {
            int index = -1;
            int maxValue = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];
                
                if (oddOrEevn == "even")
                {
                    if (currentNum % 2 == 0 && currentNum >= maxValue)
                    {
                        maxValue = currentNum;
                        index = i;
                    }
                }
                else if (oddOrEevn == "odd")
                {
                    if (currentNum % 2 != 0 && currentNum >= maxValue)
                    {
                        maxValue = currentNum;
                        index = i;
                    }
                }
            }

            return index;
        }

        static int MinElementOfTypeIndex(int[] numbers, string oddOrEevn)
        {
            int index = -1;
            int minValue = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];

                if (oddOrEevn == "even")
                {
                    if (currentNum % 2 == 0 && currentNum <= minValue)
                    {
                        minValue = currentNum;
                        index = i;
                    }
                }
                else if (oddOrEevn == "odd")
                {
                    if (currentNum % 2 != 0 && currentNum <= minValue)
                    {
                        minValue = currentNum;
                        index = i;
                    }
                }
            }

            return index;
        }

        static void PrintsFirstElementsOfType(int[] numbers, int count, string oddOrEven)
        {
            int[] firstElements = new int[count];
            int firstElementsIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currNum = numbers[i];

                if (oddOrEven == "even")
                {
                    if (currNum % 2 == 0 && firstElementsIndex < count)
                    {
                        
                        firstElements[firstElementsIndex] = currNum;
                        firstElementsIndex++;
                    }
                }
                else if (oddOrEven == "odd")
                {
                    if (currNum % 2 != 0 && firstElementsIndex < count)
                    {
                        
                        firstElements[firstElementsIndex] = currNum;
                        firstElementsIndex++;
                    }
                }
            }

            Console.WriteLine(ArrayToStringFormat(firstElements, firstElementsIndex));
        }

        static void PrintsLastElementsOfType(int[] numbers, int count, string oddOrEven)
        {
            int[] lastElements = new int[count];
            int lastElementsIndex = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int currNum = numbers[i];

                if (oddOrEven == "even")
                {
                    if (currNum % 2 == 0 && lastElementsIndex < count)
                    {

                        lastElements[lastElementsIndex] = currNum;
                        lastElementsIndex++;
                    }
                }
                else if (oddOrEven == "odd")
                {
                    if (currNum % 2 != 0 && lastElementsIndex < count)
                    {

                        lastElements[lastElementsIndex] = currNum;
                        lastElementsIndex++;
                    }
                }
            }

            int[] reverseArray = new int[lastElementsIndex];
            int reverseArrayIndex = 0;

            for (int i = lastElementsIndex - 1; i >= 0; i--)
            {
                reverseArray[reverseArrayIndex] = lastElements[i];
                reverseArrayIndex++;
            }

            Console.WriteLine(ArrayToStringFormat(reverseArray, reverseArrayIndex));
        }

        static string ArrayToStringFormat(int[] arr, int elementsCount)
        {

            string output = string.Empty;
            output += "[";

            for (int i = 0; i < elementsCount; i++)
            {
                if (i == elementsCount - 1)
                {
                    output += $"{arr[i]}";
                }
                else
                {
                    output += $"{arr[i]}, ";
                }
            }

            output += "]";

            return output;
        }
    }
  
}
