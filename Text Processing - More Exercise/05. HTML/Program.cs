using System;
using System.Collections.Generic;
using System.Text;

namespace _05._HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string content = Console.ReadLine();
            string comment = string.Empty;
            List<string> comments = new List<string>();

            while ((comment = Console.ReadLine()) != "end of comments")
            {
                comments.Add(comment);
            }
            
            Console.WriteLine("<h1>");
            Console.WriteLine($"    {title}");
            Console.WriteLine("</h1>");
            Console.WriteLine("<article>");
            Console.WriteLine($"    {content}");
            Console.WriteLine("</article>");

            foreach (string item in comments)
            {
                Console.WriteLine("<div>");
                Console.WriteLine($"    {item}");
                Console.WriteLine("</div>");
            }
        }
    }
}
