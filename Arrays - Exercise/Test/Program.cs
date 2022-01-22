using System;
using System.Linq;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool isNotFound = false;
            
            for (int i = 0; i < nums.Length; i++)
            {
                int sumLeft = 0;
                int sumRight = 0;
                isNotFound = false;

                if (nums.Length == 1)
                {
                    Console.WriteLine(0);
                    break;
                }

                for (int j = 0; j < i; j++)
                {
                    sumLeft += nums[j];
                }
                
                for (int j = i + 1; j < nums.Length; j++)
                {
                    sumRight += nums[j];
                }
                
                if (sumLeft == sumRight)
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
