using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_array_in_groups
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2 };
            int n = 3;
            int i = 0;

            double x = (double)arr.Length / n;
            double gn = Math.Ceiling(x);

            while(i < gn)
            {
                int rng = 0;
                if((i * 3 + 2) <= arr.Length - 1) rng = i * 3 + 2;
                else rng = arr.Length - 1;
                
                int j = i * 3;
                int temp = arr[j];
                arr[j] = arr[rng];
                arr[rng] = temp;

                i++;
            }

            for(int j = 0; j < arr.Length; j++)
            {
                Console.Write(arr[j] + " ");
            }

            Console.ReadKey();
        }
    }
}
