using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();

            while (command != "course start")
            {
                string[] commandArg = command.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = commandArg[0];
                string lessonTitle = commandArg[1];

                if (currentCommand == "Add")
                {
                    
                    if (!lessons.Contains(lessonTitle))
                    {
                        lessons.Add(lessonTitle);
                    }

                }
                else if (currentCommand == "Insert")
                {
                    int index = int.Parse(commandArg[2]);

                    if (!lessons.Contains(lessonTitle))
                    {
                        lessons.Insert(index, lessonTitle);
                    }

                }
                else if (currentCommand == "Remove")
                {
                    string exerciseTitle = $"{lessonTitle}-Exercise";
                    
                    if (lessons.Contains(lessonTitle))
                    {
                        lessons.Remove(lessonTitle);
                    }

                    if (lessons.Contains(exerciseTitle))
                    {
                        lessons.Remove(exerciseTitle);
                    }
                }
                else if (currentCommand == "Swap")
                {
                    string lessonsTitleSecond = commandArg[2];
                    string exerciseTitle = $"{lessonTitle}-Exercise";
                    string exerciseTitleSecond = $"{lessonsTitleSecond}-Exercise";

                    if (lessons.Contains(lessonTitle) && lessons.Contains(lessonsTitleSecond))
                    {
                        int lessonsTitleIndex = lessons.IndexOf(lessonTitle);
                        int lessonsTitleSecondIndex = lessons.IndexOf(lessonsTitleSecond);

                        lessons.RemoveAt(lessonsTitleIndex);
                        lessons.Insert(lessonsTitleIndex, lessonsTitleSecond);

                        lessons.RemoveAt(lessonsTitleSecondIndex);
                        lessons.Insert(lessonsTitleSecondIndex, lessonTitle);

                        if (lessons.Contains(exerciseTitleSecond))
                        {
                            int exerciseTitleSecondIndex = lessons.IndexOf(exerciseTitleSecond);
                            lessons.RemoveAt(exerciseTitleSecondIndex);
                            lessons.Insert(lessonsTitleIndex + 1, exerciseTitleSecond);
                        }

                        if (lessons.Contains(exerciseTitle))
                        {
                            int exerciseTitleIndex = lessons.IndexOf(exerciseTitle);
                            lessons.RemoveAt(exerciseTitleIndex);
                            lessons.Insert(lessonsTitleSecondIndex + 1, exerciseTitle);
                        }

                    }
                }
                else if (currentCommand == "Exercise")
                {
                    string exerciseTitle = $"{lessonTitle}-Exercise";

                    if (lessons.Contains(lessonTitle))
                    {
                        int lessonTitleIndex = lessons.IndexOf(lessonTitle);

                        if (!lessons.Contains(exerciseTitle))
                        {
                            lessons.Insert(lessonTitleIndex + 1, exerciseTitle);
                        }
       
                    }
                    else
                    {
                        lessons.Add(lessonTitle);
                        lessons.Add(exerciseTitle);
                    }
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }
        }
    }
}
