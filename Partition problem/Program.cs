using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partition_problem
{
    class Program
    {
        static List<int> SubsetSum(int[] arr, int n, int sum)
        {
            if (n >= arr.Length)
            {
                return new List<int>();
            }

            List<int> l1 = SubsetSum(arr, n + 1, sum - arr[n]);
            l1.Add(arr[n]);

            List<int> l2 = SubsetSum(arr, n + 1, sum);

            int t1 = l1.Sum();
            int t2 = l2.Sum();


            if(Math.Abs(t1 - sum) <= Math.Abs(t2 - sum))
            {
                return l1;
            }
            else
            {
                return l2;
            }
        }
        
        static void Main(string[] args)
        {
            int[] arr = { 1,3,5,6,3 };
            int n = arr.Length;

            int sum = 0;
            for (int i = 0; i < n; i++)
                sum += arr[i];

            if (sum % 2 != 0)
            {
                return;
            }

            var value = SubsetSum(arr, 0, sum / 2);
        }
    }
}