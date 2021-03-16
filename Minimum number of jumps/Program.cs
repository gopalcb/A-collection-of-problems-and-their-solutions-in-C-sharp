using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_number_of_jumps
{
    class Program
    {
        static int minJumps(int[] arr, int n)
        {
            int[] jumps = new int[n];

            // if first element is 0, 
            if (n == 0 || arr[0] == 0)
            {
                return int.MaxValue;
            }

            for (int i = 0; i < n; i++)
            {
                if(i == 0)
                {
                    jumps[i] = 0;
                }
                else
                {
                    jumps[i] = int.MaxValue;
                }
            }

            // Find the minimum number of 
            // jumps to reach arr[i] 
            // from arr[0], and assign 
            // this value to jumps[i] 
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (i <= j + arr[j] && jumps[j] != int.MaxValue)
                    {
                        jumps[i] = Math.Min(jumps[i], jumps[j] + 1);
                        break;
                    }
                }
            }
            return jumps[n - 1];
        }


        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 6, 1, 0, 9 };
            Console.Write("Minimum number of jumps to reach end is : " + minJumps(arr, arr.Length));
            Console.ReadKey();
        }
    }
}
