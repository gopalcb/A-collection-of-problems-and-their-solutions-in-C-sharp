using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_pairs_of_given_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 8, 3, 4, 2, 6, 10, 7, 1, 9 };
            Array.Sort(arr);
            int left = 0;
            int right = arr.Length - 1;
            int gs = 11;

            while (left < right)
            {
                int sum = arr[left] + arr[right];
                if (sum > gs)
                {
                    right--;
                }
                else if (sum < gs)
                {
                    left++;
                }
                else
                {
                    Console.WriteLine(arr[left] + "," + arr[right]);
                    left++;
                }
            }

            Console.ReadKey();
        }
    }
}
