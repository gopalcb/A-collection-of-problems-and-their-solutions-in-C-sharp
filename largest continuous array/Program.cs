using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace largest_continuous_array
{
    class Program
    {
        static int maxSubArraySum(int[] a)
        {
            int size = a.Length;
            int max_so_far = int.MinValue,
                max_ending_here = 0;
            int start = 0, end = 0;
            int beg = 0;

            for (int i = 0; i < size; i++)
            {
                max_ending_here = max_ending_here + a[i];

                if (max_so_far < max_ending_here)
                {
                    max_so_far = max_ending_here;
                    start = beg;
                    end = i;
                }

                if (max_ending_here < 0)
                {
                    max_ending_here = 0;
                    beg = i + 1;
                }
            }

            return max_so_far;
        }

        static void Main(string[] args)
        {
            int[] a = { -1, - 2, - 3, - 4 };
            Console.Write("Maximum contiguous sum is " + maxSubArraySum(a));
            Console.ReadKey();
        }
    }
}
