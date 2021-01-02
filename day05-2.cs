using System;

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
            bool twice = false;
            string pair, remainder;
            int i = 0;

            while ((i < (input.Length - 3)) && !twice)
            {
                pair = input.Substring(i, 2);
                remainder = input.Remove(i, 2);
                if (remainder.Contains(pair))
                {
                    twice = true;
                }
                i++;
            }
            return twice;
        }

        public static bool RepeatLetter(string input)
        {
            bool repeat = false;
            int n = 0;

            while ((n < (input.Length - 2)) && !repeat)
            {
                if (input[n] == input[n + 2])
                {
                    repeat = true;
                }
                n++;
            }
            return repeat;
        }
    }
}