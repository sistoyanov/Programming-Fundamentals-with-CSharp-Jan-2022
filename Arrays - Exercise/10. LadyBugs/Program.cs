using System;
using System.Linq;

namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int filedSize = int.Parse(Console.ReadLine());

            int[] filed = new int[filedSize];

            int[] initialIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < initialIndexes.Length; i++)
            {
                for (int j = 0; j < filed.Length; j++)
                {
                    if (initialIndexes[i] == j)
                    {
                        filed[j] = 1;
                    }
                }
            }

            //Console.WriteLine(String.Join(" ", filed));

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] currentComand = input.Split().ToArray();
                int ladyBugIndex = int.Parse(currentComand[0]);
                string ladyBugDirection = currentComand[1].ToString();
                int ladyBugFlyLength = int.Parse(currentComand[2]);


                //Console.WriteLine(ladyBugIndex);
                //Console.WriteLine(ladyBugDirection);
                //Console.WriteLine(ladyBugFlyLength);



                input = Console.ReadLine();
            }

        }
    }
}
