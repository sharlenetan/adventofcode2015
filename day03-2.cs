using System;
using System.Collections.Generic;

namespace AdventOfCode2015
{
    class Day3
    {
        static void Main()
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\sharlenet\source\repos\AdventOfCode2015\WriteText.txt");
            int santa_x = 0, santa_y = 0;
            int robo_x = 0, robo_y = 0;
            bool santa = true;
            List<(int, int)> list = new List<(int, int)>();
            list.Add((0, 0));

            foreach (char c in text)
            {
                if (santa)
                {
                    switch (c)
                    {
                        case '^':
                            santa_y++;
                            break;
                        case '>':
                            santa_x++;
                            break;
                        case 'v':
                            santa_y--;
                            break;
                        case '<':
                            santa_x--;
                            break;
                    }
                    if (!list.Contains((santa_x, santa_y)))
                    {
                        list.Add((santa_x, santa_y));
                    }
                    santa = false;
                }
                else
                {
                    switch (c)
                    {
                        case '^':
                            robo_y++;
                            break;
                        case '>':
                            robo_x++;
                            break;
                        case 'v':
                            robo_y--;
                            break;
                        case '<':
                            robo_x--;
                            break;
                    }
                    if (!list.Contains((robo_x, robo_y)))
                    {
                        list.Add((robo_x, robo_y));
                    }
                    santa = true;
                }
            }
            Console.WriteLine("House count: " + list.Count);
        }
    }
}