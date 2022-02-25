using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
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
            List<Student> students = new List<Student>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] currentArg = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = currentArg[0];
                string lastName = currentArg[1];
                int age = int.Parse(currentArg[2]);
                string homeTown = currentArg[3];

                Student currentStudent = new Student(name, lastName, age, homeTown);

                if (IsStudentExists(students, currentStudent))
                {
                    Student student = GetStudent(students, currentStudent);

                    student.Age = age;
                    student.HomeTown = homeTown;
                }
                else
                {
                    students.Add(currentStudent);
                }
                
            }

            string cityName = Console.ReadLine();
            List<Student> filterdStudents = students.Where(s => s.HomeTown == cityName).ToList();

            foreach (Student student in filterdStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }

        }

        static bool IsStudentExists(List<Student> students, Student currentStudent)
        {
            string fisrtName = currentStudent.FirstName;
            string lastName = currentStudent.LastName;

            foreach (Student student in students)
            {
                if (student.FirstName == fisrtName && student.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }

        static Student GetStudent(List<Student> students, Student currentStudent)
        {
            string fisrtName = currentStudent.FirstName;
            string lastName = currentStudent.LastName;
            Student existingStudent = null;

            foreach (Student student in students)
            {
                if (student.FirstName == fisrtName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }

            return existingStudent;
        }
    }
}
