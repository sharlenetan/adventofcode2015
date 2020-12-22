using System;
using System.Collections.Generic;

namespace AdventOfCode2015
{
    class Day3
    {
        static void Main()
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\sharlenet\source\repos\AdventOfCode2015\WriteText.txt");
            int x = 0, y = 0;
            List<(int, int)> list = new List<(int, int)>();
            list.Add((x, y));

            foreach (char c in text)
            {
                switch(c)
                {
                    case '^':
                        y++;
                        break;
                    case '>':
                        x++;
                        break;
                    case 'v':
                        y--;
                        break;
                    case '<':
                        x--;
                        break;
                }
                
                if (!list.Contains((x, y)))
                {
                    list.Add((x, y));
                }
            }
            
            Console.WriteLine("House count: " + list.Count);
        }
    }
}