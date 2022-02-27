using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string title = input[0];
            string content = input[1];
            string author = input[2];

            Article article = new Article(title, content, author);
            
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                string[] commandArg = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries);
                string command = commandArg[0].Trim();

                if (command == "Edit")
                {
                    string newContent = commandArg[1].Trim();
                    article.Edit(newContent);
                }
                else if (command == "ChangeAuthor")
                {
                    string newAuthor = commandArg[1].Trim();
                    article.ChangeAuthor(newAuthor);
                }
                else if (command == "Rename")
                {
                    string newTitle = commandArg[1].Trim();
                    article.Rename(newTitle);
                }
            }

            Console.WriteLine(article);
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public string Title{ get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit (string content)
        {
            this.Content = content;
        }

        public void ChangeAuthor(string author)
        {
            this.Author = author;
        }

        public void Rename(string title)
        {
            this.Title = title;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}".ToString();
        }
    }
}
