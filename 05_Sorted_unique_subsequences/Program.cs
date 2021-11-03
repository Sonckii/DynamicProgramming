using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Sorted_unique_subsequences
{
    public class Program
    {
        static void Main()
        {

            // output is set to null before passing
            // in as a parameter
            string output = "*";
            string input = "abc";

            printSubsequence(input, output);
        }
        static void printSubsequence(string input, string output)
        {

            // Base Case
            // If the input is empty print the output string
            if (input.Length == 0)
            {
                Console.WriteLine(output);
                return;
            }

            // Output is passed with including
            // the Ist character of
            // Input string
            printSubsequence(input.Substring(1), output + input[0]);

            // Output is passed without
            // including the Ist character
            // of Input string
            printSubsequence(input.Substring(1), output);
        }
    }
}

