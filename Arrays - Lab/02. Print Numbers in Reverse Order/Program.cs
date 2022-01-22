using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int [] array = new int[num];

            for (int i = 0; i < num; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                array[i] = currentNum;
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
