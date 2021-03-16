using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pascal_s_Triangle_II
{
    class Program
    {
        static int[] solve(int[] arr, int n)
        {
            arr[n] = 1;
            int temp = arr[0];
            for(int i = 1; i < n; i++)
            {
                int sum = arr[i - 1] + arr[i];
                arr[i-1] = temp;
                temp = sum;
            }
            arr[n - 1] = temp;

            return arr;
        }


        static void Main(string[] args)
        {
            int n = 20;
            int[] arr = new int[n + 1];

            arr[0] = 1;
            //arr[1] = 1;
            arr[n] = 1;

            

            for (int i = 1; i <= n; i++)
            {
                arr = solve(arr, i);
            }

            Console.ReadKey();
        }
    }
}
