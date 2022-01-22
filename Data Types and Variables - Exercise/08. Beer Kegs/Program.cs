using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double bigestSize = 0;
            string bigetsModel = string.Empty;

            for (int i = 1; i <= count; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double size = Math.PI * Math.Pow(radius, 2) * height;

                if (size > bigestSize)
                {
                    bigestSize = size;
                    bigetsModel = model;
                }
            }

            Console.WriteLine(bigetsModel);
        }
    }
}
