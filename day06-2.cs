using System;
using System.Text.RegularExpressions;

namespace AdventOfCode2015
{
    class Day6
    {
        static void Main()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\sharlenet\source\repos\AdventOfCode2015\WriteText.txt");
            int[,] grid = new int[1000, 1000];
            int i, j, start_x, start_y, end_x, end_y;
            int count = 0;

            //Turn all lights in the grid off
            for (i = 0; i < 1000; i++)
            {
                for (j = 0; j < 1000; j++)
                {
                    grid[i, j] = 0;
                }
            }

            foreach (string line in lines)
            {
                Match instruction = Regex.Match(line, @"(\D*)");
                string action = instruction.Value; // read in action and convert it to a string
                MatchCollection digits = Regex.Matches(line, @"(\d+)");
                string[] strArray = new string[digits.Count];
                
                for (int n = 0; n < digits.Count; n++)
                {
                    strArray[n] = digits[n].Groups[0].Value; // read in numbers as strings
                }
                
                start_x = int.Parse(strArray[0]);
                start_y = int.Parse(strArray[1]);
                end_x = int.Parse(strArray[2]);
                end_y = int.Parse(strArray[3]);

                if (action == "turn on ")
                {
                    for (i = start_x; i <= end_x; i++)
                    {
                        for (j = start_y; j <= end_y; j++)
                        {
                            grid[i, j]++;
                        }
                    }
                }
                else if (action == "turn off ")
                {
                    for (i = start_x; i <= end_x; i++)
                    {
                        for (j = start_y; j <= end_y; j++)
                        {
                            if (grid[i, j] > 0)
                                grid[i, j]--;
                        }
                    }
                }
                else if (action == "toggle ")
                {
                    for (i = start_x; i <= end_x; i++)
                    {
                        for (j = start_y; j <= end_y; j++)
                        {
                            grid[i, j] += 2;
                        }
                    }
                }
            }

            //Count the number of lights turned on
            for (i = 0; i < 1000; i++)
            {
                for (j = 0; j < 1000; j++)
                {
                    count += grid[i, j];
                }
            }
            Console.WriteLine(count);
        }
    }
}