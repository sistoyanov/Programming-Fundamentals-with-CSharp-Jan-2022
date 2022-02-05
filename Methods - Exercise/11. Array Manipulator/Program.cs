using System;
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
                            
                            if (array[i] > maxEven)
                            {
                                maxEven = array[i];
                                ouput = i;
                            }
                            
                            isMaxEvenOrOddFound = true;
                        }
                        else if (currentComand[0] == "max" && currentComand[1] == "odd" && array[i] % 2 != 0)
                        {
                            
                            if (array[i] > maxOdd)
                            {
                                maxOdd = array[i];
                                ouput = i;
                            }

                            isMaxEvenOrOddFound = true;
                        }
                        else if (currentComand[0] == "min" && currentComand[1] == "even" && array[i] % 2 == 0)
                        {

                            if (array[i] < minEven)
                            {
                                minEven = array[i];
                                ouput = i;
                            }

                            isMaxEvenOrOddFound = true;
                        }
                        else if (currentComand[0] == "min" && currentComand[1] == "odd" && array[i] % 2 != 0)
                        {
                            
                            if (array[i] < minOdd)
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
                    StringBuilder evens = new StringBuilder();
                    StringBuilder odds = new StringBuilder();

                    for (int i = 0; i < array.Length; i++)
                    {
                        
                        if (array[i] % 2 == 0)
                        {
                            evens.Append(array[i]);
                        }
                        else
                        {
                            odds.Append(array[i]);
                        }
                    }

                    bool isCounterGreater = true;
                    StringBuilder output = new StringBuilder();

                    if (counter <= array.Length)
                    {
                        isCounterGreater = false;
                        int[] evensArray = new int[evens.Length];
                        int[] oddsArray = new int[odds.Length];

                        for (int h = 0; h < evensArray.Length; h++)
                        {
                            evensArray[h] = int.Parse(evens[h].ToString());
                        }

                        for (int k = 0; k < oddsArray.Length; k++)
                        {
                            oddsArray[k] = int.Parse(odds[k].ToString());
                        }


                        if (currentComand[0] == "first")
                        {
                            if (currentComand[2] == "even" && evens.Length > 0)
                            {
                           
                                if (counter >= evensArray.Length)
                                {
                                    for (int i = 0; i < evensArray.Length; i++)
                                    {
                                        output.Append(int.Parse(evensArray[i].ToString()));
                                    }
                                }
                                else
                                {
                                    for (int j = 0; j < counter; j++)
                                    {
                                        output.Append(int.Parse(evensArray[j].ToString()));
                                    }
                                }

                            }
                            else if (currentComand[2] == "odd" && odds.Length > 0)
                            {

                                if (counter >= oddsArray.Length)
                                {
                                    for (int i = 0; i < oddsArray.Length; i++)
                                    {
                                        output.Append(int.Parse(oddsArray[i].ToString()));
                                    }
                                }
                                else
                                {
                                    for (int j = 0; j < counter; j++)
                                    {
                                        output.Append(int.Parse(oddsArray[j].ToString()));
                                    }
                                }
                            }
                        }
                        else if (currentComand[0] == "last")
                        {
                            if (currentComand[2] == "even" && evens.Length > 0)
                            {

                                if (counter == evensArray.Length)
                                {
                                    for (int i = 0 ; i < evensArray.Length; i++)
                                    {
                                        output.Append(int.Parse(evensArray[(evensArray.Length - counter) + i].ToString()));
                                    }
                                }
                                else if (counter > evensArray.Length)
                                {
                                    for (int i = 0; i < evensArray.Length; i++)
                                    {
                                        output.Append(int.Parse(evensArray[i].ToString()));
                                    }
                                }
                                else
                                {
                                    for (int j = 0; j < counter; j++)
                                    {
                                        output.Append(int.Parse(evensArray[(evensArray.Length - counter) + j].ToString()));
                                    }
                                }


                            }
                            else if (currentComand[2] == "odd" && odds.Length > 0)
                            {
                                if (counter == oddsArray.Length)
                                {
                                    for (int i = 0; i < oddsArray.Length; i++)
                                    {
                                        output.Append(int.Parse(oddsArray[(oddsArray.Length - counter) + i].ToString()));
                                    }
                                }
                                else if (counter > oddsArray.Length)
                                {
                                    for (int i = 0; i < oddsArray.Length; i++)
                                    {
                                        output.Append(int.Parse(oddsArray[i].ToString()));
                                    }
                                }
                                else
                                {
                                    for (int j = 0; j < counter; j++)
                                    {
                                        output.Append(int.Parse(oddsArray[(oddsArray.Length - counter) + j].ToString()));
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
                        if (output.Length > 0)
                        {
                            string[] consoleOuput = new string[output.Length];

                            for (int i = 0; i < output.Length; i++)
                            {
                                consoleOuput[i] = output[i].ToString();
                            }

                            Console.WriteLine($"[{string.Join(", ", consoleOuput)}]");
                        }
                        else
                        {
                            Console.WriteLine($"[]");
                        }
                    }

                }

              
            }

            Console.WriteLine($"[{String.Join("," + " ", array)}]");
        }
    }
}
