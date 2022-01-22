using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int sum = 0;
            int days = 0;

            while (yield >= 100)
            {
                sum += yield - 26;
                days++;
                yield -= 10;
            }

            if (days > 0)
            {
                sum -= 26;
            }
            
            Console.WriteLine(days);
            Console.WriteLine(sum);
        }
    }
}
