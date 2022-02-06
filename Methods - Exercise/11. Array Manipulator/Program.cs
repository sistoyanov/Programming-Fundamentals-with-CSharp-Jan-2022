using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] array = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] currentComand = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                
                if (currentComand[0] == "exchange")
                {
                    int splitIndex = int.Parse(currentComand[1]);

                    if (splitIndex >= 0 && splitIndex < array.Length)
                    {
                        int[] splitedArr = new int[array.Length];

                        for (int i = 0; i < array.Length; i++)
                        {
                            if (i < array.Length - (splitIndex + 1))
                            {
                                splitedArr[i] = array[splitIndex + 1 + i];
                            }
                            else
                            {
                                splitedArr[i] = array[i - (array.Length - (splitIndex + 1))];
                            }
                        }

                        array = splitedArr;

                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (currentComand[0] == "max" || currentComand[0] == "min")
                {
                    int ouput = 0;
                    bool isMaxEvenOrOddFound = false;
                    int maxEven = int.MinValue;
                    int maxOdd = int.MinValue;
                    int minEven = int.MaxValue;
                    int minOdd = int.MaxValue;

                    for (int i = 0; i < array.Length; i++)
                    {
                        
                        
                        if (currentComand[0] == "max" && currentComand[1] == "even" && array[i] % 2 == 0)
                        {
                            
                            if (array[i] >= maxEven)
                            {
                                maxEven = array[i];
                                ouput = i;
                            }
                            
                            isMaxEvenOrOddFound = true;
                        }
                        else if (currentComand[0] == "max" && currentComand[1] == "odd" && array[i] % 2 != 0)
                        {
                            
                            if (array[i] >= maxOdd)
                            {
                                maxOdd = array[i];
                                ouput = i;
                            }

                            isMaxEvenOrOddFound = true;
                        }
                        else if (currentComand[0] == "min" && currentComand[1] == "even" && array[i] % 2 == 0)
                        {

                            if (array[i] <= minEven)
                            {
                                minEven = array[i];
                                ouput = i;
                            }

                            isMaxEvenOrOddFound = true;
                        }
                        else if (currentComand[0] == "min" && currentComand[1] == "odd" && array[i] % 2 != 0)
                        {
                            
                            if (array[i] <= minOdd)
                            {
                                minOdd = array[i];
                                ouput = i;
                            }

                            isMaxEvenOrOddFound = true;
                        }
                    }

                    Console.WriteLine(isMaxEvenOrOddFound ? $"{ouput}" : "No matches");
                }
                else if (currentComand[0] == "first" || currentComand[0] == "last")
                {
                    int counter = int.Parse(currentComand[1]);
                    List<int> evens = new List<int>();
                    List<int> odds = new List<int>();

                    for (int i = 0; i < array.Length; i++)
                    {
                        
                        if (array[i] % 2 == 0)
                        {
                            evens.Add(array[i]);
                        }
                        else
                        {
                            odds.Add(array[i]);
                        }
                    }

                    bool isCounterGreater = true;
                    List<int> output = new List<int>();

                    if (counter <= array.Length)
                    {
                        isCounterGreater = false;

                        if (currentComand[0] == "first")
                        {
                            if (currentComand[2] == "even" && evens.Count > 0)
                            {
                           
                                if (counter >= evens.Count)
                                {
                                    for (int i = 0; i < evens.Count; i++)
                                    {
                                        output.Add(evens[i]);

                                    }
                                }
                                else
                                {
                                    for (int j = 0; j < counter; j++)
                                    {
                                        output.Add(evens[j]);
                                    }
                                }

                            }
                            else if (currentComand[2] == "odd" && odds.Count > 0)
                            {

                                if (counter >= odds.Count)
                                {
                                    for (int i = 0; i < odds.Count; i++)
                                    {
                                        output.Add(odds[i]);
                                    }
                                }
                                else
                                {
                                    for (int j = 0; j < counter; j++)
                                    {
                                        output.Add(odds[j]);
                                    }
                                }
                            }
                        }
                        else if (currentComand[0] == "last")
                        {
                            if (currentComand[2] == "even" && evens.Count > 0)
                            {

                                if (counter == evens.Count)
                                {
                                    for (int i = 0 ; i < evens.Count; i++)
                                    {
                                        output.Add(evens[(evens.Count - counter) + i]);
                                    }
                                }
                                else if (counter > evens.Count)
                                {
                                    for (int i = 0; i < evens.Count; i++)
                                    {
                                        output.Add(evens[i]);
                                    }
                                }
                                else
                                {
                                    for (int j = 0; j < counter; j++)
                                    {
                                        output.Add(evens[(evens.Count - counter) + j]);
                                    }
                                }


                            }
                            else if (currentComand[2] == "odd" && odds.Count > 0)
                            {
                                if (counter == odds.Count)
                                {
                                    for (int i = 0; i < odds.Count; i++)
                                    {
                                        output.Append(odds[(odds.Count - counter) + i]);
                                    }
                                }
                                else if (counter > odds.Count)
                                {
                                    for (int i = 0; i < odds.Count; i++)
                                    {
                                        output.Add(odds[i]);
                                    }
                                }
                                else
                                {
                                    for (int j = 0; j < counter; j++)
                                    {
                                        output.Add(odds[(odds.Count - counter) + j]);
                                    }
                                }

                            }
                        }
                    }

                    if (isCounterGreater)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        if (output.Count > 0)
                        {

                            Console.WriteLine($"[{String.Join(", ", output)}]");
                        }
                        else
                        {
                            Console.WriteLine($"[]");
                        }
                    }

                }

              
            }

            Console.WriteLine($"[{String.Join(", ", array)}]");
        }
    }
}
