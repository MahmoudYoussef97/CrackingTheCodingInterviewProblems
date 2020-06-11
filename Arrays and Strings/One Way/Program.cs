using System;

namespace One_Way
{
    class Program
    {
        static void OneWay(string[] args)
        {
            var input1 = Console.ReadLine();
            var input2 = Console.ReadLine();
            var output = IsOneWayEdit(input1, input2);
            Console.WriteLine(output);
        }
        private static bool IsOneWayEdit(string input1, string input2)
        {
            int[] charFreq = new int[129];
            int changes = 0;
            foreach (var ch in input1)
            {
                charFreq[ch - 'a']++;
                if (charFreq[ch - 'a'] % 2 == 1) changes++;
                else changes--;
            }
            foreach (var ch in input2)
            {
                charFreq[ch - 'a']++;
                if (charFreq[ch - 'a'] % 2 == 1) changes++;
                else changes--;
            }

            if (Math.Abs(input1.Length - input2.Length) == 1 && changes == 1) return true;
            else if (input1.Length - input2.Length == 0 && changes == 2) return true;
            else return false;
        }
    }
}
