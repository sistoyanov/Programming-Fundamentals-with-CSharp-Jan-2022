using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //for (int i = 0; i < array.Length; i++)
            //{
            //    bool isBigger = true;

            //    for (int j = i + 1; j < array.Length; j++)
            //    {
            //        if (array[i] <= array[j])
            //        {
            //            isBigger = false;
            //        }
            //    }

            //    if (isBigger)
            //    {
            //        Console.Write(array[i] + " ");
            //    }
            //}

            for (int i = 0; i < array.Length; i++)
            {
                int topNumber = 0;

                if (i == array.Length - 1)
                {
                    Console.Write(array[i]);
                }

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        topNumber = array[i];
                    }
                    else
                    {
                        break;
                    }
                }

                if (topNumber != 0)
                {
                    Console.Write($"{topNumber} ");
                }
            }
        }
    }
}
