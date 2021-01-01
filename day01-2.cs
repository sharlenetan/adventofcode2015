using System;

namespace AdventOfCode2015
{
    class Day1
    {
        static void Main()
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\sharlenet\source\repos\AdventOfCode2015\WriteText.txt");
            int n = 0, x = 0, y = 0;
            bool found = false;

            foreach (char c in text)
            {
                x++;
                
                if (c == '(')
                {
                    n++;
                    if (!found && n == -1)
                    {
                        y = x;
                        found = true;
                    }
                }
                else if (c == ')')
                {
                    n--;
                    if (!found && n == -1)
                    {
                        y = x;
                        found = true;
                    }
                }
            }
            
            Console.WriteLine("Result: " + n);
            Console.WriteLine("Position: " + y);
        }
    }
}