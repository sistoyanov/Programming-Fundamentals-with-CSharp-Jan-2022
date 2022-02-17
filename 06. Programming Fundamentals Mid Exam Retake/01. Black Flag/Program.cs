using System;

namespace _01._Black_Flag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double plunderPerDay = double.Parse(Console.ReadLine());
            double plunderTarget = double.Parse(Console.ReadLine());
            double plunderSum = 0;

            for (int i = 1; i <= days; i++)
            {
                plunderSum += plunderPerDay;
                
                if (i % 3 == 0)
                {
                    double additionalPlunder = plunderPerDay / 2;
                    plunderSum += additionalPlunder;
                }

                if (i % 5 == 0)
                {
                    double plunderLost = plunderSum * 0.30;
                    plunderSum -= plunderLost;
                }
            }

            if (plunderSum >= plunderTarget)
            {
                Console.WriteLine($"Ahoy! {plunderSum:f2} plunder gained.");
            }
            else
            {
                double persentageCollected = (plunderSum / plunderTarget) * 100;
                Console.WriteLine($"Collected only {persentageCollected:f2}% of the plunder.");
            }
        }
    }
}
