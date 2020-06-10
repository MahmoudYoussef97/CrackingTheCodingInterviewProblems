using System;

namespace CheckPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().TrimEnd().Split(' ');
            var str1 = inputs[0];
            var str2 = inputs[1];
            var output = CheckPermutationWithSorting(str1, str2);
            output = CheckPermutationWithCountingChars(str1, str2);
            Console.WriteLine(output);
        }
        private static bool CheckPermutationWithCountingChars(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;

            int[] freq = new int[129];
            foreach (var ch in str1)
                freq[ch - 'a']++;

            foreach (var ch in str2)
            {
                freq[ch - 'a']--;
                if (freq[ch - 'a'] < 0) return false;
            }

            return true;
        }
        private static bool CheckPermutationWithSorting(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;

            char[] firstString = new char[str1.Length];
            char[] secondString = new char[str2.Length];
            for (int i = 0; i < str1.Length; ++i) firstString[i] = str1[i];
            for (int i = 0; i < str1.Length; ++i) secondString[i] = str2[i];
            Array.Sort(firstString);
            Array.Sort(secondString);
            for (int i = 0; i < firstString.Length; ++i)
                if (firstString[i] != secondString[i]) return false;

            return true;
        }
    }
}
