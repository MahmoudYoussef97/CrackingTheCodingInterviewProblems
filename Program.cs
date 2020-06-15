using CrackingCodingInterviewsProblems.LinkedList;
using System;

namespace CrackingTheCodingInterviewsProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            // This Project contains all Crack The Coding Interview Problem Solutions
            // in C# for preparing coding interviews 
            // Author : Mahmoud Youssef
            Console.WriteLine("----------Coding Interviews Practicing---------------");
            Console.WriteLine("----------Author: Mahmoud Youssef ---------------");
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AppendFront(1);
            linkedList.AppendFront(2);
            linkedList.AppendFront(3);
            linkedList.AppendFront(4);
            linkedList.AppendFront(4);
            linkedList.AppendFront(5);
            linkedList.Print();
            int count = 2;
            Console.WriteLine(linkedList.GetKthElement(linkedList.GetHead(), 3, ref count));
        }
    }
}
