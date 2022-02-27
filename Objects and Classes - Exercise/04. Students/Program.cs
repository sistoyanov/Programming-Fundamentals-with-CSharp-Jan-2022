﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 1; i <= studentsCount; i++)
            {
                string[] studentDetails = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstName = studentDetails[0];
                string lastName = studentDetails[1];
                double grade = double.Parse(studentDetails[2]);

                students.Add(new Student(firstName, lastName, grade));
            }

            foreach (Student student in students.OrderByDescending(g => g.Grade))
            {
                Console.WriteLine(student);
            }
        }
    }

    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:f2}".ToString();
        }
    }
}
