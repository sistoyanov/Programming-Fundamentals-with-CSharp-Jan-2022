using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isNotFound = false;


            for (int i = 0; i < nums.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                isNotFound = false;

                if (nums.Length == 1)
                {
                    Console.WriteLine(0);
                    break;
                }

                for (int j = 0; j < i; j++)
                {
                    leftSum += nums[j];
                }

                for (int k = i + 1; k < nums.Length; k++)
                {
                    rightSum += nums[k];
                }

                if (leftSum == rightSum)
                {

                    Console.WriteLine(i);
                    break;

                }
                else
                {
                    isNotFound = true;
                }

            }

            if (isNotFound)
            {
                Console.WriteLine("no");
            }

        }
    }
}
