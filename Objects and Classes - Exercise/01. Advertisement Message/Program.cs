using System;

namespace _01._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            string[] phrases = 
                {"Excellent product.", 
                "Such a great product.", 
                "I always use that product.", 
                "Best product of its category.", 
                "Exceptional product.", 
                "I can’t live without this product."};
            string[] events = 
                {"Now I feel good.", 
                "I have succeeded with this product.", 
                "Makes miracles. I am happy of the results!", 
                "I cannot believe but now I feel awesome.", 
                "Try it yourself, I am very satisfied.", 
                "I feel great!"};
            string[] authors = 
                {"Diana", 
                "Petya", 
                "Stella", 
                "Elena", 
                "Katya", 
                "Iva", 
                "Annie", 
                "Eva"};
            string[] cities = 
                {"Burgas", 
                "Sofia", 
                "Plovdiv", 
                "Varna", 
                "Ruse"};

            Random randomPhrase = new Random();
            Random randomEvent = new Random();
            Random randomAuthor = new Random();
            Random randomCity = new Random();

            for (int i = 1; i <= count; i++)
            {
                
                int prasesIdx = randomPhrase.Next(0, phrases.Length - 1);
                int eventsIdx = randomEvent.Next(0, events.Length - 1);
                int authorsIdx = randomAuthor.Next(0, authors.Length - 1);
                int cityIdx = randomCity.Next(0, cities.Length - 1);

                Console.WriteLine($"{phrases[prasesIdx]} {events[eventsIdx]} {authors[authorsIdx]} – {cities[cityIdx]}.");
            }
        }
    }
}
