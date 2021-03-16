using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        public class Node
        {
            public Node next;
            public Node prev;
            public object data;
        }

        public class LinkedList
        {
            public Node head;

            public void PrintAllNodes()
            {
                Node current = head;
                while (current != null)
                {
                    Console.Write(current.data + " -> ");
                    current = current.next;
                }
            }

            public void AddFirst(object data)
            {
                Node node = new Node();

                node.data = data;
                node.next = head;
                head = node;
            }

            public void AddLast(object data)
            {
                if (head == null)
                {
                    head = new Node();

                    head.data = data;
                    head.next = null;
                }
                else
                {
                    Node node = new Node();
                    node.data = data;

                    Node current = head;
                    while (current.next != null)
                    {
                        current = current.next;
                    }

                    current.next = node;
                }
            }

            public void ConvertToDoubly()
            {
                head.prev = null;
                Node current = head;

                while (current.next != null)
                {
                    current.next.prev = current;
                    current = current.next;
                }
            }

            public void Reverse()
            {
                Node prev = null;
                Node current = head;
                Node next = null;

                while (current != null)
                {
                    next = current.next;
                    next = current.next;
                    current.next = prev;
                    prev = current;
                    current = next;
                }
                head = prev;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Add First:");
            LinkedList myList1 = new LinkedList();

            myList1.AddFirst("Hello");
            myList1.AddFirst("Magical");
            myList1.AddFirst("World");
            myList1.PrintAllNodes();

            Console.WriteLine();

            Console.WriteLine("Add Last:");
            LinkedList myList2 = new LinkedList();

            myList2.AddLast("1");
            myList2.AddLast("2");
            myList2.AddLast("3");
            myList2.AddLast("4");
            myList2.AddLast("5");
            myList2.PrintAllNodes();

            Console.WriteLine();

            myList2.ConvertToDoubly();
            myList2.Reverse();
            myList2.PrintAllNodes();

            Console.WriteLine();

            LinkedList myList3 = new LinkedList();

            myList3.AddLast("1");
            myList3.AddLast("2");
            myList3.PrintAllNodes();

            c = 1;
            var res = RemoveNthFromEnd(myList3.head, 1);
            Stack<char> myStack = new Stack<char>();

            Console.ReadLine();
        }

        static int c = 0;
        static int len = 0;

        public static Node solve(Node head, Node prev, Node next, int n)
        {

            if (head.next != null)
            {
                solve(head.next, head, head.next.next, n);
            }
            c = c - 1;

            if (len == n)
            {
                return null;
            }
            else if (c == 0)
            {
                prev.next = next;
            }

            return head;
        }

        public static Node RemoveNthFromEnd(Node head, int n)
        {

            c = n;
            Node res = solve(head, null, head.next, n);

            return res;
        }
    }
}
