using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] array = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] currentComand = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                //Console.WriteLine(String.Join("", currentComand));
                //Console.WriteLine(String.Join("", array));
                
                if (currentComand[0] == "exchange")
                {
                    long splitIndex = long.Parse(currentComand[1]);

                    if (splitIndex == array.Length - 1)
                    {
                        continue;
                    }

                    if (splitIndex >= 0 && splitIndex < array.Length)
                    {
                        int[] splitedArr = new int[array.Length];

                        //if (splitIndex == 0)
                        //{
                        //    splitedArr[splitedArr.Length - 1] = array[0];
                        //}

                        var firstSplitArray = splitIndex + 1;
                        var secondSplitArray = array.Length - firstSplitArray;

                        for (long i = splitIndex + 1; i < splitedArr.Length; i++)
                        {
                            splitedArr[i - (splitIndex + 1)] = array[i];
                        }

                        for (long j = 0; j < firstSplitArray; j++)
                        {
                            splitedArr[] = array[j];

                        }

                        array = splitedArr;


                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (currentComand[0] == "max" || currentComand[0] == "min")
                {

                }
                else if (currentComand[0] == "first" || currentComand[0] == "last")
                {

                }

                Console.WriteLine($"[{String.Join(" " + ",", array)}]");
            }

            Console.WriteLine($"[{String.Join(" " + ",", array)}]");
        }
    }
}
