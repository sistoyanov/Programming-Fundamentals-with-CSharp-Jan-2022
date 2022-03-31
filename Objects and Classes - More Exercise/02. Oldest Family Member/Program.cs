using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Oldest_Family_Member
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Person> Family = new List<Person>();

            for (int i = 0; i < count; i++)
            {
                string[] personDetails = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = personDetails[0];
                int age = int.Parse(personDetails[1]);

                Family.Add(new Person(name, age));
            }

            Person oldestPerson = Family.OrderByDescending(a => a.Age).First();
            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
            
        }
    }

    class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
