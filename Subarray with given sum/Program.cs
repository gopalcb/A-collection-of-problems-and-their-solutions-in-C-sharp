using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subarray_with_given_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 3, 7, 8, 9, 10 };
            int sum = 15;
            int n = arr.Length;
            int left = 0;
            int right = 0;
            int psum = arr[0];
            int sv = 0;

            while(right < n && left <= right)
            {
                psum += sv;
                if (psum == sum)
                {
                    Console.WriteLine(left + " - " + right);

                    sv = -arr[left];
                    left += 1;
                }
                else if(psum > sum)
                {
                    sv = -arr[left];
                    left += 1;
                }
                else
                {
                    right += 1;
                    if(right < n)
                    {
                        sv = arr[right];
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
