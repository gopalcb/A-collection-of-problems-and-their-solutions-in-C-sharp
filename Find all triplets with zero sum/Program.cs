using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_all_triplets_with_zero_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 5, 3, -1, -5, -8, 1, 7};

            Array.Sort(arr);

            for(int i =0; i < arr.Length - 2; i++)
            {
                int left = i + 1;
                int right = arr.Length - 1;

                while (left < right)
                {
                    int sum = arr[i] + arr[left] + arr[right];
                    if (sum == 0)
                    {
                        Console.WriteLine(arr[i] + "," + arr[left] + "," + arr[right]);
                        left++;
                        right--;
                    }
                    else if(sum < 0)
                    {
                        left++;
                    }
                    else if (sum > 0)
                    {
                        right--;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
