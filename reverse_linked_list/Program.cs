using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_linked_list
{
    class Program
    {


        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();
            LinkedList<int> ll2 = new LinkedList<int>();

            for (int i = 1; i <= 5; i++)
            {
                ll.AddLast(i);
            }
            int head = ll.First();
            for (LinkedListNode<int> node = ll.First; node != null; node = node.Next)
            {
                ll2.AddFirst(node.Value);
            }
        }
    }
}
