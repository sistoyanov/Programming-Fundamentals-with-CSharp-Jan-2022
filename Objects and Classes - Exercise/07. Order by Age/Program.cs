using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Person> persons = new List<Person>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] personArg = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = personArg[0];
                string id = personArg[1];
                int age = int.Parse(personArg[2]);

                bool isPersonExists = persons.Any(p => p.ID == id);

                if (isPersonExists)
                {
                    Person existingPerson = persons.First(p => p.ID == id);
                    existingPerson.Name = name;
                    existingPerson.Age = age;
                }
                else
                {
                    persons.Add(new Person(name, id, age));
                }
            }

            foreach (Person person in persons.OrderBy(p => p.Age))
            {
                Console.WriteLine(person);
            }
        }
    }

    class Person
    {
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.ID = id;
            this.Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age{ get; set; }

        public override string ToString()
        {
            return $"{this.Name} with ID: {this.ID} is {this.Age} years old.".ToString();
        }
    }

}
