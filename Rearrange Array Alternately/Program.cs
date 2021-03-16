using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rearrange_Array_Alternately
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };

            int max = arr.Length - 1;
            int min = 0;

            int tmax = arr[max];
            int tmin = arr[min];

            for (int i = 0; i < arr.Length; i = i + 2)
            {
                int tmax1 = tmax;
                int tmin1 = tmin;

                max--;
                min++;
                tmax = arr[max];
                tmin = arr[min];

                arr[i] = tmax1;
                arr[i + 1] = tmin1;
                if (i + 1 == arr.Length - 1)
                {
                    break;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.ReadKey();

        }
    }
}
