using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist_middle_item
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();
            Console.WriteLine();
            int N = Convert.ToInt32(Console.ReadLine());

            string[] items = Console.ReadLine().Split(' ');

            foreach(var itm in items)
            {
                ll.AddLast(Convert.ToInt32(itm));
            }

            int count = ll.Count;
            int middle = 0;
            if(count%2==0)
            {
                middle = (count / 2) + 1;
            }
            else
            {
                middle = (count+1)/2;
            }
            int index = 1;
            for (LinkedListNode<int> node = ll.First; node != null; node = node.Next)
            {
                if (index == middle)
                {
                    Console.WriteLine(node.Value);
                    break;
                }
                index++;
            }

            Console.ReadKey();
        }
    }
}
