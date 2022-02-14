using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] currentArg = command.Split(' ').ToArray();
                string currentCommand = currentArg[0];
                int index1, index2, num1, num2;

                if (currentCommand == "swap")
                {
                    TakeNumberOnIndex(numbers, currentArg, out index1, out index2, out num1, out num2);

                    numbers.RemoveAt(index1);
                    numbers.Insert(index1, num2);

                    numbers.RemoveAt(index2);
                    numbers.Insert(index2, num1);
                }
                else if (currentCommand == "multiply")
                {
                    TakeNumberOnIndex(numbers, currentArg, out index1, out index2, out num1, out num2);

                    int newElement = num1 * num2;
                    numbers.RemoveAt(index1);
                    numbers.Insert(index1, newElement); 
                }
                else if (currentCommand == "decrease")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i] -= 1;
                    }
                }
            }

            Console.WriteLine(String.Join(", ", numbers));
        }

         static void TakeNumberOnIndex(List<int> numbers, string[] currentArg, out int index1, out int index2, out int num1, out int num2)
        {
            index1 = int.Parse(currentArg[1]);
            index2 = int.Parse(currentArg[2]);

            num1 = numbers[index1];
            num2 = numbers[index2];
        }
    }
}
