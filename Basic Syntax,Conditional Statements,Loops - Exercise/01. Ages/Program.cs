using System;

namespace _01._Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int age = int.Parse(Console.ReadLine());
           string person = string.Empty;

            if (age >= 66)
            {
                person = "elder";
            }
            else if (age >= 20)
            {
                person = "adult";
            }
            else if (age >= 14)
            {
                person = "teenager";
            }
            else if (age >= 3)
            {
                person = "child";
            }
            else if (age >= 0)
            {
                person = "baby";
            }

            Console.WriteLine(person);
        }
    }
}
