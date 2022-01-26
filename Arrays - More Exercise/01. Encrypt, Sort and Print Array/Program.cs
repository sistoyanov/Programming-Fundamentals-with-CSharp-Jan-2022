using System;

namespace _01._Encrypt__Sort_and_Print_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] array = new int[count];

            for (int i = 0; i < count; i++)
            {
                string currentName = Console.ReadLine();
                int currentNameSum = 0;

                for (int j = 0; j < currentName.Length; j++)
                {

                    if (currentName[j] == 'a' || currentName[j] == 'e' || currentName[j] == 'i' || currentName[j] == 'o' || currentName[j] == 'u' ||
                        currentName[j] == 'A' || currentName[j] == 'E' || currentName[j] == 'I' || currentName[j] == 'O' || currentName[j] == 'U')
                    {
                        currentNameSum += (int)currentName[j] * currentName.Length;

                    }
                    else
                    {
                        currentNameSum += (int)currentName[j] / currentName.Length;
                    }

                }

                array[i] = currentNameSum;
            }

            Array.Sort(array);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

        }
    }
}
