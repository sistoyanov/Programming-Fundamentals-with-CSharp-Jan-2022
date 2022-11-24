using System;

namespace _01._Bonus_Scoring_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double students = double.Parse(Console.ReadLine());
            double lectures = double.Parse(Console.ReadLine());
            double bonus = double.Parse(Console.ReadLine());

            double maxBonus = 0;
            int maxAttendance = 0;

            for (int i = 1; i <= students; i++)
            {
                int currentAttendances = int.Parse(Console.ReadLine());
                double currentBonus = ((currentAttendances / lectures) * (5 + bonus));

                if (currentBonus >= maxBonus)
                {
                    maxBonus = currentBonus;
                    maxAttendance = currentAttendances;
                }
            }

            
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttendance} lectures.");
        }
    }
}
