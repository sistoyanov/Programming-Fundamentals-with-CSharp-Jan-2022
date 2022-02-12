using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string[] bombAndPower = Console.ReadLine().Split();
            int bomb = int.Parse(bombAndPower[0]);
            int power = int.Parse(bombAndPower[1]);

            bool isBombExist = numbers.Exists(x => x == bomb);

            while (isBombExist)
            {
                int bombIndex = numbers.FindIndex(x => x == bomb);
                int leftStart = bombIndex - power;

                if (leftStart < 0)
                {
                    leftStart = 0;
                }

                for (int i = leftStart; i < bombIndex; i++)
                {
                    numbers.RemoveAt(i);
                    i--;
                    bombIndex--;
                }

                int rightEnd = bombIndex + power;

                if (rightEnd > numbers.Count - 1)
                {
                    rightEnd = numbers.Count - 1;
                }

                for (int i = bombIndex; i <= rightEnd; i++)
                {
                    numbers.RemoveAt(i);
                    i--;
                    rightEnd--;
                }

                isBombExist = numbers.Exists(x => x == bomb);
            }

           int sum = numbers.Sum();

           Console.WriteLine(sum);

        }
    }
}
