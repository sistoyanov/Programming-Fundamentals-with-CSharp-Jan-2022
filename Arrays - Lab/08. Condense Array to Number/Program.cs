using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //for (int i = 0; i < nums.Length - 1; i++)
            //{

            //    for (int j = 0; j < nums.Length -1; j++)
            //    {
            //        nums[j] = nums[j] + nums[j + 1];
            //        Console.WriteLine(nums[j]);
            //    }

            //    Console.WriteLine(nums[i]);
            //}

            //Console.WriteLine(nums[0]);

            while (nums.Length != 1)
            {
                int[] condensed = new int[nums.Length - 1];
                
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    condensed[i] = nums[i] + nums[i + 1];
                }

                nums = condensed;

            }

            Console.WriteLine(nums[0]);

        }
    }
}
