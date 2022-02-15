using System;

namespace _01._Guinea_Pig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double food = double.Parse(Console.ReadLine());
            double hay = double.Parse(Console.ReadLine());
            double cover = double.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());

            double foodGrams = food * 1000;
            double hayGrams = hay * 1000;
            double coverGrams = cover * 1000;
            double weightGrams = weight * 1000;

            bool isSupliesEnough = true;

            for (int i = 1; i <= 30; i++)
            {

                foodGrams -= 300;

                if (i % 2 == 0)
                {
                    double currentHay = foodGrams * 0.05;
                    hayGrams -= currentHay;
                }

                if (i % 3 == 0)
                {
                    double currentCover = weightGrams / 3;
                    coverGrams -= currentCover;
                }

                if (foodGrams <= 0 || hayGrams <= 0 || coverGrams <= 0)
                {
                    isSupliesEnough = false;
                    break;
                }

            }

            if (isSupliesEnough)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {(foodGrams / 1000):f2}, Hay: {(hayGrams / 1000):f2}, Cover: {(coverGrams / 1000):f2}.");
            }
            else
            {
                Console.WriteLine("Merry must go to the pet store!");
            }
        }
    }
}
