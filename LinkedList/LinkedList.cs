using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingCodingInterviewsProblems.LinkedList
{
    public class LinkedList<T>
    {
        private Node head;
        private Node tail;
        public class Node
        {
            public Node next = null;
            public T data;
            public Node(T data)
            {
                this.data = data;
            }
        }
        /// <summary>
        /// This method appends at the head.
        /// </summary>
        /// <param name="data"></param>
        public void AppendFront(T data)
        {
            // check null option
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            Node node = new Node(data);
            // if the head is null == linked list is empty
            if (head == null)
            {
                head = node;
                tail = node;
                return;
            }
            node.next = head;
            head = node;
        }
        /// <summary>
        /// This method appends at the tail.
        /// </summary>
        /// <param name="data"></param>
        public void AppendBack(T data)
        {
            // check null option
            if (data == null)
                throw new ArgumentNullException(nameof(data));
            // if the head is null == linked list is empty
            Node node = new Node(data);
            if (tail == null)
            {
                head = node;
                tail = node;
                return;
            }
            tail.next = node;
            tail = node;
        }
        /// <summary>
        /// This method prints all items inside the list.
        /// </summary>
        /// <param name="data"></param>
        public void Print()
        {
            var current = head;
            while(current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
            return;
        }
        /// <summary>
        /// This method removes the item at the head.
        /// </summary>
        /// <param name="data"></param>
        public T RemoveFront()
        {
            if (head == null)
                throw new Exception("The linked list is empty");

            T data = head.data;
            if (head.next == null)
            {
                head = null;
                return data;
            }
            Node node = head.next;
            head = null;
            head = node;
            return data;
        }
        /// <summary>
        /// This method removes the item at the tail.
        /// </summary>
        /// <param name="data"></param>
        public T RemoveBack()
        {
            if (tail == null)
                throw new Exception("The linked list is empty");

            var current = head;
            T data = tail.data;
            if (current.next != null)
            {
                while (current.next.next != null)
                {
                    current = current.next;
                }
                tail = null;
                tail = current;
                current.next = null;
                return data;
            }
            head = null;
            tail = null;
            return data;
        }
        /// <summary>
        /// This method returns the count of items in the list.
        /// </summary>
        /// <param name="data"></param>
        public int Count()
        {
            var current = head;
            int count = 0;
            while (current != null)
            {
                current = current.next;
                count++;
            }
            return count;
        }
        /// <summary>
        /// This method returns true if the item exists and false if not.
        /// </summary>
        /// <param name="data"></param>
        public bool IsExist(T value)
        {
            var current = head;
            while(current != null)
            {
                if (current.data.Equals(value)) return true;
                current = current.next;
            }
            return false;
        }
        /// <summary>
        /// This method returns true if the list is empty and false if not.
        /// </summary>
        /// <param name="data"></param>
        public bool IsEmpty()
        {
            return Count() == 0 ;
        }
        /// <summary>
        /// This method returns the head value.
        /// </summary>
        /// <param name="data"></param>
        public T Front()
        {
            return head.data;
        }
        /// <summary>
        /// This method returns the tail value.
        /// </summary>
        /// <param name="data"></param>
        public T Back()
        {
            return tail.data;
        }
        /// <summary>
        /// This method removes the item if exists.
        /// </summary>
        /// <param name="data"></param>
        public void Remove(T value)
        {
            var current = head.next;
            var previous = head;
            while(current != null)
            {   
                if(current.data.Equals(value))
                {
                    previous.next = current.next;
                    current.next = null;
                    current = null;
                    return;
                }
                previous = current;
                current = current.next;
            }
            if(head.data.Equals(value))
            {
                head = null;
                tail = null;
            }
            return;
        }
        public Node GetHead()
        {
            return head;
        }
    }
}
