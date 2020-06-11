using String_Rotation.ExtensionMethod;
using System;
using System.Text;

namespace String_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = Console.ReadLine();
            var s2 = Console.ReadLine();
            bool output = IsStringRotation(s1, s2);
            Console.WriteLine(output);
        }
        private static bool IsStringRotation(string s1, string s2)
        {
            StringBuilder s1s2 = new StringBuilder();
            s1s2.Append(s1);
            s1s2.Append(s1);
            return s1s2.IsSubstring(s2);
        }
    }
}
