using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingCodingInterviewsProblems.LinkedList
{
    public static class LinkedListExtensions
    {
        public static void RemoveDuplicates<T>(this LinkedList<T> source, LinkedList<T>.Node node)
        {
            HashSet<T> freq = new HashSet<T>();
            var current = node;
            var previous = new LinkedList<T>.Node(node.data);
            while(current != null)
            {   
                if(freq.Contains(current.data))
                {
                    // remove it
                    previous.next = current.next;
                }
                else
                {
                    freq.Add(current.data);
                    previous = current;
                }
                current = current.next;
            }
        }
        public static T GetKthElement<T>(this LinkedList<T> source, LinkedList<T>.Node node, int K, ref int count)
        {   
            if (node.next == null)
                return node.data;

            T result = GetKthElement<T>(source, node.next, K, ref count);
            if (count == K)
            {
                count += 1;
                return node.data;
            }
            else
            {
                count += 1;
            }
            return result;
        }
    }
}
