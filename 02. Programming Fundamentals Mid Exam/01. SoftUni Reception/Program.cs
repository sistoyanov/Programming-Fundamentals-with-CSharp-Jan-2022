using System;

namespace _01._SoftUni_Reception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumbersPerHour = int.Parse(Console.ReadLine());
            int secondNumbersPerHour = int.Parse(Console.ReadLine());
            int thirdNumbersPerHour = int.Parse(Console.ReadLine());
            int studenstCount = int.Parse(Console.ReadLine());

            int totalNumbersPerHour = firstNumbersPerHour + secondNumbersPerHour + thirdNumbersPerHour;
            int hourCounter = 0;

            while (studenstCount > 0)
            {
                hourCounter++;
                studenstCount -= totalNumbersPerHour;

                if (hourCounter % 4 == 0)
                {
                    hourCounter++;
                }
            }

            Console.WriteLine($"Time needed: {hourCounter}h.");
        }
    }
}
