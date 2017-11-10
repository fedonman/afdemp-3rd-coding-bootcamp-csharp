using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class LinkedListGeneric<T>
    {
        // private class Node exists only within LinkedList
        private class Node<T>
        {
            public T Value { get; set; }
            public Node<T> Next { get; set; }

            public Node(T v)
            {
                Value = v;
                Next = null;
            }
        }

        // private variable head
        // is the first node of the list or null if list is empty
        private Node<T> head;

        // property Count returns the number of nodes in list
        public int Count
        {
            get
            {
                if (head == null)
                {
                    return 0;
                }
                int count = 1;
                Node<T> current = head;
                while (current.Next != null)
                {
                    count++;
                    current = current.Next;
                }
                return count;
            }
        }

        // Constructor
        public LinkedListGeneric()
        {
            head = null;
        }

        // Add a node at the end of the list
        public void Add(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node<T> current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        // Remove last node and return its value or null if list is empty
        public T RemoveLast()
        {
            if (head == null)
            {
                return default(T);
            }
            Node<T> current = head;
            Node<T> precurrent = null;
            while (current.Next != null)
            {
                precurrent = current;
                current = current.Next;
            }
            if (precurrent == null)
            {
                head = null;
                return current.Value;
            }
            precurrent.Next = null;
            return current.Value;
        }

        // return a string representation of the list
        public string Print()
        {
            if (head == null)
            {
                return "";
            }
            Node<T> current = head;
            string result = "";
            while (current.Next != null)
            {
                result += $"{current.Value} -> ";
                current = current.Next;
            }
            result += $"{current.Value}";
            return result;
        }
    }
}
