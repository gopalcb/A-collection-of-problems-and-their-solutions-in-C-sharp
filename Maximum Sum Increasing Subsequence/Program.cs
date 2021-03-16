using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Sum_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 101, 2, 3, 100, 4, 5 };

            int[] lis = new int[arr.Length];
            int i, j, max = 0;
            
            for (i = 0; i < arr.Length; i++)
            {
                lis[i] = 1;
            }
            
            for (i = 1; i < arr.Length; i++)
            {
                for (j = 0; j < i; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        lis[i] = Math.Max(lis[j] + 1, lis[i]);
                        max = Math.Max(max, lis[i]);
                    }
                }
            }

            Console.WriteLine(max);

            Console.ReadKey();
        }
    }
}
