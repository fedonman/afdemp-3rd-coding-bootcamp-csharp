using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    //The following code example shows a simple generic linked-list class for demonstration purposes. 
    // (In most cases, you should use the List<T> class provided by the .NET Framework class library instead of creating your own.)
    // The type parameter T is used in several locations where a concrete type would ordinarily be used to indicate the type of the item stored in the list. It is used in the following ways:
    // As the type of a method parameter in the AddHead method.
    // As the return type of the public method GetNext and the Data property in the nested Node class.
    // As the type of the private member data in the nested class.

    // type parameter T in angle brackets
    public class GenericList2<T>
    {
        // Note that T is available to the nested Node class. When GenericList<T> is instantiated with a concrete type, for example as a GenericList<int>, each occurrence of T will be replaced with int.

        // The nested class is also generic on T.
        private class Node
        {
            // T used in non-generic constructor.
            public Node(T t)
            {
                next = null;
                data = t;
            }

            private Node next;
            public Node Next
            {
                get { return next; }
                set { next = value; }
            }

            // T as private member data type.
            private T data;

            // T as return type of property.
            public T Data
            {
                get { return data; }
                set { data = value; }
            }
        }

        private Node head;

        // constructor
        public GenericList2()
        {
            head = null;
        }

        // T as method parameter type:
        public void AddHead(T t)
        {
            Node n = new Node(t);
            n.Next = head;
            head = n;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node current = head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
