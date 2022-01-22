using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal eps = (decimal)0.000001;
            decimal difference = (Math.Abs(a - b));

            Console.WriteLine(eps <= difference ? "False" : "True");
        }
    }
}
