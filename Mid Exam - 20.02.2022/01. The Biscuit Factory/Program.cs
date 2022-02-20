using System;

namespace _01._The_Biscuit_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int biscuitsPerDay = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());
            int competingNumber = int.Parse(Console.ReadLine());
            
            int totalBiscuits = 0;

            for (int i = 1; i <= 30; i++)
            {

                int totalBiscuitPerDay = biscuitsPerDay * workersCount;

                if (i % 3 == 0)
                {
                    double currentNum = totalBiscuitPerDay * 0.75;
                    totalBiscuitPerDay = (int)Math.Floor(currentNum);
 
                }

                totalBiscuits += totalBiscuitPerDay;
            }

            double difference = competingNumber - totalBiscuits;
            double differencePercentage = 0;
            
            if (difference < 0)
            {
                difference = Math.Abs(difference);
                differencePercentage = (difference / competingNumber) * 100;
                Console.WriteLine($"You have produced {totalBiscuits} biscuits for the past month.");
                Console.WriteLine($"You produce {differencePercentage:f2} percent more biscuits.");

            }
            else
            {
                differencePercentage = (difference / competingNumber) * 100;
                Console.WriteLine($"You have produced {totalBiscuits} biscuits for the past month.");
                Console.WriteLine($"You produce {differencePercentage:f2} percent less biscuits.");
            }

            
        }
    }
}
