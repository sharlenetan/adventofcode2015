using System;
using System.Text.RegularExpressions;

namespace AdventOfCode2015
{
    class Day5
    {
        static void Main()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\sharlenet\source\repos\AdventOfCode2015\WriteText.txt");
            int count = 0;

            foreach (string line in lines)
            {
                if ((TwoLettersTwice(line)) && (RepeatLetter(line)))
                {
                    count++;
                }
                    
            }

            Console.WriteLine(count);
        }

        public static bool TwoLettersTwice(string input)
        {
            var matches = Regex.Matches(input, @"([a-z][a-z]).*\1");
            if (matches.Count > 0)
                return true;
            else
                return false;
        }

        public static bool RepeatLetter(string input)
        {
            var matches = Regex.Matches(input, @"(.).\1");
            if (matches.Count > 0)
                return true;
            else
                return false;
        }
    }
}