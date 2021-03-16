using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volume_of_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 0, 6, 0, 3, 0, 8, 0, 2, 0, 5, 2, 0, 3 };
            int[] left_max = new int[arr.Length];
            int[] right_max = new int[arr.Length];
            int cur_left_max = 0;
            int cur_right_max = 0;
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > cur_left_max)
                {
                    left_max[i] = arr[i];
                    cur_left_max = arr[i];
                }
                else
                {
                    left_max[i] = cur_left_max;
                }

                int rmi = arr.Length - i - 1;
                if (arr[rmi] > cur_right_max)
                {
                    right_max[rmi] = arr[rmi];
                    cur_right_max = arr[rmi];
                }
                else
                {
                    right_max[rmi] = cur_right_max;
                }
            }


            for (int i = 0; i < arr.Length; i++)
            {
                int level = Math.Min(left_max[i], right_max[i]);
                int diff = level - arr[i];
                sum += diff;
            }

            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
