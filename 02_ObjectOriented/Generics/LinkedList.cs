using System;

namespace Generics
{
    class LinkedList
    {
        // private class Node exists only within LinkedList
        private class Node
        {
            public int Value { get; set; }
            public Node Next { get; set; }

            public Node(int v)
            {
                Value = v;
                Next = null;
            }
        }

        // private variable head
        // is the first node of the list or null if list is empty
        private Node head;

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
                Node current = head;
                while(current.Next != null)
                {
                    count++;
                    current = current.Next;
                }
                return count;
            }
        }

        // Constructor
        public LinkedList()
        {
            head = null;
        }

        // Add a node at the end of the list
        public void Add(int value)
        {
            Node newNode = new Node(value);
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        // Remove last node and return its value or null if list is empty
        public int? RemoveLast()
        {
            if (head == null)
            {
                return null;
            }
            Node current = head;
            Node precurrent = null;
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
            Node current = head;
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
