using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();

            for(int i=1; i <= 5; i++)
            {
                ll.AddLast(i);
            }

            //reverse traverse
            //kasr 2 elements
            Console.WriteLine("Last 2");
            int count = 0;
            var el = ll.Last;
            while (el != null)
            {
                if (count == 2)
                {
                    break;
                }
                Console.WriteLine(el.Value);
                el = el.Previous;
                count++;
            }

            //forward traverse
            //first 2 elements
            Console.WriteLine("Last 2");
            count = 0;
            var el2 = ll.First;
            while (el2 != null)
            {
                if (count == 2)
                {
                    break;
                }
                Console.WriteLine(el2.Value);
                el2 = el2.Next;
                count++;
            }

            Console.ReadKey();
        }
    }
}
