using System;

namespace Arrays_and_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read input as a string
            string input = Console.ReadLine();
            var output = HasAllUniqueCharactersUsingSortingApproach(input);
            output = HasAllUniqueCharactersUsingFrequencyArray(input);
            Console.WriteLine(output);
        }
        private static bool HasAllUniqueCharactersUsingFrequencyArray(string input)
        {
            if (input.Length > 128) return false;

            bool[] freq = new bool[129];
            for(int i=0;i<input.Length;++i)
            {
                if (freq[input[i]])
                    return false;
                freq[input[i]] = true;
            }
            return true;
        }
        private static bool HasAllUniqueCharactersUsingSortingApproach(string input)
        {
            if (input.Length > 128) return false;

            char[] s = new char[input.Length];
            for (int i = 0; i < input.Length; ++i)
                s[i] = input[i];

            // Sort the array
            Array.Sort(s);
            char previous = ' ';
            foreach (var ch in s)
            {
                if (previous == ch)
                    return false;
                previous = ch;
            }
            return true;
        }
    }
}
