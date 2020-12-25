using System;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Text;

namespace AdventOfCode2015
{
    class Day4
    {
        static void Main()
        {
            string input = "yzbqklnj";
            int n = 1;
            bool found = false;

            while (!found)
            {
                string input_n = input + n.ToString();
                string output = CreateMD5(input_n);
                if (output.Substring(0,6) == "000000")
                {
                    found = true;
                    Console.WriteLine(n); // lowest positive number that produces hash beginning with "00000"
                }
                n++;
            }
        }
        
	//CreateMD5 code taken from stackoverflow.com
        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}