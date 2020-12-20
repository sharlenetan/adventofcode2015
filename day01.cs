using System;

namespace AdventOfCode2015
{
    class Day1
    {
        static void Main()
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\sharlenet\source\repos\AdventOfCode2015\WriteText.txt");
            int n = 0;
            foreach (char c in text)
            {
                if (c == '(')
                    n++;
                else if (c == ')')
                    n--;
            }
            Console.WriteLine("Result: " + n);
        }
    }
}