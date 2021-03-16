using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_search
{
    class Program
    {

        static bool Search(int[] arr, int val)
        {
            var len = arr.Length;
            int mid = 0;
            if (len % 2 == 0)
            {
                mid = len / 2;
            }
            else
            {
                mid = len / 2;
            }

            if (arr[mid] != val && len == 1)
            {
                return false;
            }

            if(arr[mid] == val)
            {
                return true;
            }
            else if (val > arr[mid])
            {
                var right = arr.Skip(mid).Take(len - mid + 1).ToArray();
                return Search(right, val);
            }
            else if (val < arr[mid])
            {
                var left = arr.Skip(0).Take(mid).ToArray();
                return Search(left, val);
            }

            return false;
        }

        static void Main(string[] args)
        {
            var list = new List<int>();

            //1 2 3 4 5 6 7 8 9 10 11
            for(int i = 0; i < 11; i++)
            {
                list.Add(i);
            }

            var index = Search(list.ToArray(), 12);

            Console.ReadKey();

        }
    }
}
