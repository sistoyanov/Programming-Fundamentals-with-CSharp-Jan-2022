using System;

namespace _01._Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int counter = 0;
            string input = string.Empty;
            bool isEngergyEnough = true;

            while ((input = Console.ReadLine()) != "End of battle")
            {
                int distance = int.Parse(input);

                if (energy > 0)
                {
                    if (energy >= distance)
                    {
                        energy -= distance;
                        counter++;

                        if (counter % 3 == 0)
                        {
                            energy += counter;
                        }
                    }
                    else
                    {
                        isEngergyEnough = false;
                        break;
                    }
                }
                else
                {
                    isEngergyEnough = false;
                    break;
                }
               
            }

            Console.WriteLine(isEngergyEnough ? $"Won battles: {counter}. Energy left: {energy}" : $"Not enough energy! Game ends with {counter} won battles and {energy} energy");
        }
    }
}
