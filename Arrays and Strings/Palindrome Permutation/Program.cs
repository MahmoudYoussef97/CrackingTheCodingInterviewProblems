using System;

namespace Palindrome_Permutation
{
    class Program
    {
        static void PalindromePermutation(string[] args)
        {
            var input = Console.ReadLine();
            var output = IsPalindromePermutation(input);
            Console.WriteLine(output);
        }
        private static bool IsPalindromePermutation(string input)
        {
            int[] charFreq = new int[129];
            int oddCounts = 0;
            foreach (var ch in input)
            {
                if (ch == ' ') continue;
                charFreq[ch - 'a']++;
                if (charFreq[ch - 'a'] % 2 == 1)
                    oddCounts++;
                else
                    oddCounts--;
            }
            return oddCounts <= 1;
        }
    }
}
