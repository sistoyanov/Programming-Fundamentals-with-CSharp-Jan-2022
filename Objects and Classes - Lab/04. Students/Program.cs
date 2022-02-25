using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Students
    {
        public Students(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

    }

     class Program
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] currentArg = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = currentArg[0];
                string lastName = currentArg[1];
                int age = int.Parse(currentArg[2]);
                string homeTown = currentArg[3];

               Students currentStudent = new Students(name, lastName, age, homeTown);
               students.Add(currentStudent);
            }

            string cityName = Console.ReadLine();
            List<Students> filterdStudents = students.Where(s => s.HomeTown == cityName).ToList();

            foreach (Students student in filterdStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }

        }
    }
}
