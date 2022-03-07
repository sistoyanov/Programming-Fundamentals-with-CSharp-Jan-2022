using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for(int i = 0; i < count; i++)
            {
                string currentStudent = Console.ReadLine();
                double currentStudentGrade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(currentStudent))
                {
                    students.Add(currentStudent, new List<double>());
                }

                students[currentStudent].Add(currentStudentGrade);
            }

            Dictionary<string, double> bestStudents = new Dictionary<string, double>();
            const double BESTRESULT = 4.50;

            foreach (var kvp in students)
            {
                double avarageGrade = kvp.Value.Average();

                if (avarageGrade >= BESTRESULT)
                {
                    bestStudents.Add(kvp.Key, avarageGrade);
                }
            }

            foreach (var sgp in bestStudents)
            {
                Console.WriteLine($"{sgp.Key} –> {sgp.Value:f2}");
            }
        }
    }
}
