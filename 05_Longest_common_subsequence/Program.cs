using System;

namespace _05_Longest_common_subsequence
{
    class Program
    {
        private const string S1 = "abcdefg";
        private const string S2 = "lakbpc";
        static void Main(string[] args)
        {
            var length = LongestCommonSubsequence(S1, S2, out var subSequence);

            Console.WriteLine($"LCS: {subSequence} with length {length}");
        }

		private static int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public static int LongestCommonSubsequence(string s1, string s2, out string output) //output returned de effectieve longes subsequence
        {
            int s1Len = s1.Length; //length of string 1
            int s2Len = s2.Length; //length of string 2
            int[] totalLengthOfStrings = new int[(s1Len + 1) * (s2Len + 1)];
            int[,] memo = new int[(s1Len + 1), (s2Len + 1)];

            //fill 2D array with 0's
            for (var i = 0; i <= s1Len; ++i)
            {
                memo[i, 0] = totalLengthOfStrings[i * (s2Len + 1)];
            }

            for (var i = 1; i <= s1Len; ++i)
            {
                for (var j = 1; j <= s2Len; ++j)
                {
                    if (s1[i - 1] == s2[j - 1]) //als beide letters hetzelfde zijn haal deze dan alletwee weg
                        memo[i, j] = memo[i - 1, j - 1] + 1;
                    else
                        memo[i, j] = Max(memo[i - 1, j], memo[i, j - 1]); //als letters verschillend zijn kijk dan welke string de langste subsequence geeft
                }
            }

            var lengthOfLongestCommonSubsequence = memo[s1Len, s2Len];

            char[] outputSB = new char[lengthOfLongestCommonSubsequence]; //array of chars met de lengte van de gevonden subsequence

            for (int i = s1Len, j = s2Len, k = lengthOfLongestCommonSubsequence - 1; k >= 0;) // over alle letters van achter naar voor
            {
                if (s1[i - 1] == s2[j - 1]) //als de letters hetzelfde zijn
                {
                    outputSB[k] = s1[i - 1]; // zet de letter in de output
                    --i; //lengte van string1 -1 dus verwijder de laatste letter
                    --j; //lengte van string2 -1 dus verwijder de laatste letter
                    --k; //juiste letter gevonden dus schuif een plaats op naar voor in het eindresultaat
                }
                else if (memo[i, j - 1] > memo[i - 1, j]) // als de 2e string min de laatste letter de langste substring geeft haal die letter dan weg
                    --j;
                else
                    --i; //anders haal de andere letter weg
            }

            output = new string(outputSB); //maak string van de array of chars

            return lengthOfLongestCommonSubsequence; //return de lengte van de subsequence
        }
	}
}
