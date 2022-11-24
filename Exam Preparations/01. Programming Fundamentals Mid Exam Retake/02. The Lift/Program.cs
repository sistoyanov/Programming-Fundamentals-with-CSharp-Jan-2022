using System;
using System.Linq;

namespace _02._The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int capacity = (lift.Length * 4) - lift.Sum();

            for (int i = 0; i < lift.Length; i++)
            {
                int maxWagonCapacity = 4 - lift[i];

                if (maxWagonCapacity > 0 && people > 0 && capacity > 0)
                {
                    for (int j = 0; j < maxWagonCapacity; j++)
                    {
                        lift[i]++;
                        people--;
                        capacity--;

                        if (people == 0 || capacity == 0)
                        {
                            break;
                        }
                    }
                }
            }

            if (people == 0 && capacity > 0)
            {
                Console.WriteLine("The lift has empty spots!");
            }
            else if (people > 0 && capacity <= 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
            }

            Console.WriteLine(String.Join(" ", lift));
        }
    }
}
