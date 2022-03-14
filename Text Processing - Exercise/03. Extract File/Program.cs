using System;
using System.Linq;
using System.Text;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] filePath = Console.ReadLine()
                .Split(@"\", StringSplitOptions.RemoveEmptyEntries)
                .Last()
                .Split('.')
                .ToArray();

            string fileName = String.Join(".", filePath.Take(filePath.Length - 1));
            string extenion = filePath.Last();

            StringBuilder ouput = new StringBuilder();
            ouput.AppendLine($"File name: {fileName}");
            ouput.AppendLine($"File extension: {extenion}");

            Console.WriteLine(ouput);
        }
    }
}
