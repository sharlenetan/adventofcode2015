using System;

namespace AdventOfCode2015
{
    class Day5
    {
        static void Main()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\sharlenet\source\repos\AdventOfCode2015\WriteText.txt");
            int n = 0;

            foreach (string line in lines)
            {
                if ((ThreeVowels(line)) && (ConsecutiveChars(line)) && (GoodStrings(line)))
                    n++;
            }

            Console.WriteLine(n);
        }

        public static bool ThreeVowels(string input)
        {
            int count = 0;

            foreach (char c in input)
            {
                switch (c)
                {
                    case 'a':
                        count++;
                        break;
                    case 'e':
                        count++;
                        break;
                    case 'i':
                        count++;
                        break;
                    case 'o':
                        count++;
                        break;
                    case 'u':
                        count++;
                        break;
                }
            }

            if (count > 2)
                return true;
            else
                return false;
        }

        public static bool ConsecutiveChars(string input)
        {
            bool twice = false;
            char first = '\0', second = '\0';

            foreach (char c in input)
            {
                second = c;
                if (first == second)
                    twice = true;
                first = c;
            }

            return twice;
        }

        public static bool GoodStrings(string input)
        {
            bool good = true;

            if (input.ToLower().Contains("ab"))
                good = false;
            if (input.ToLower().Contains("cd"))
                good = false;
            if (input.ToLower().Contains("pq"))
                good = false;
            if (input.ToLower().Contains("xy"))
                good = false;

            return good;
        }
    }
}