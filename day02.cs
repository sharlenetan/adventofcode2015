using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode2015
{
    class Day2
    {
        static void Main()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\sharlenet\source\repos\AdventOfCode2015\WriteText.txt");
            int total = 0, ribbon = 0;

            foreach (string line in lines)
            {
                string[] digits = Regex.Split(line, @"\D+");
                int l = int.Parse(digits[0]);
                int w = int.Parse(digits[1]);
                int h = int.Parse(digits[2]);

                int[] sides = new int[3];
                sides[0] = l * w;
                sides[1] = w * h;
                sides[2] = l * h;

                total = total + 2 * sides[0] + 2 * sides[1] + 2 * sides[2] + sides.Min();

                int[] perimeter = new int[3];
                perimeter[0] = 2 * l + 2 * w;
                perimeter[1] = 2 * w + 2 * h;
                perimeter[2] = 2 * l + 2 * h;

                ribbon = ribbon + perimeter.Min() + l * w * h;
            }
            Console.WriteLine("Wrapping paper: " + total);
            Console.WriteLine("Ribbon: " + ribbon);
        }
    }
}