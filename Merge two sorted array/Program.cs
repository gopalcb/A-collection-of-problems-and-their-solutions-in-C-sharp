using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_two_sorted_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 5, 9, 10, 15, 20 };
            int[] arr2 = new int[] { 2, 3, 8, 13 };

            int[] arr3 = new int[arr1.Length + arr2.Length];

            int p1 = arr1.Length - 1;
            int p2 = arr2.Length - 1;
            int p3 = arr1.Length + arr2.Length - 1;

            while(p3 >= 0)
            {
                if(p1 < 0)
                {
                    arr3[p3] = arr2[p2];
                }
                else if (p2 < 0)
                {
                    arr3[p3] = arr1[p1];
                }
                else if(arr1[p1] >= arr2[p2])
                {
                    arr3[p3] = arr1[p1];
                    p1--;
                }
                else
                {
                    arr3[p3] = arr2[p2];
                    p2--;
                }
                p3--;
            }

            for(int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i] + "  ");
            }

            Console.ReadKey();
        }
    }
}
