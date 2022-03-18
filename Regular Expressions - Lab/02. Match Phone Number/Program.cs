using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\+359( |-)2\1\d{3}\1\d{4}\b";
            string phones = Console.ReadLine();
            MatchCollection matches = Regex.Matches(phones, regex);
            string[] output = matches.Select(a => a.Value).ToArray();
            Console.WriteLine(string.Join(", ",output));
        }
    }
}
