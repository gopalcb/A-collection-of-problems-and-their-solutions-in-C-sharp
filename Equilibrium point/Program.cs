using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equilibrium_point
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 2, 2 };

            int j = arr.Length - 1;
            int[] fsum_arr = new int[arr.Length];
            int[] bsum_arr = new int[arr.Length];
            int fsum = 0;
            int bsum = 0;
            var dict = new Dictionary<int, int>();


            for (int i = 0; i < arr.Length; i++)
            {
                fsum += arr[i];
                fsum_arr[i] = fsum;

                bsum += arr[j];
                bsum_arr[j] = bsum;
                dict.Add(bsum, j);
                j--;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(fsum_arr[i]))
                {
                    Console.WriteLine(arr[i]);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
