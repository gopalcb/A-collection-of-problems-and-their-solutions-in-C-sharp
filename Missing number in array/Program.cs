using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missing_number_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 10 };

            int rsum = 0;
            int vsum = 0;
            int max = int.MinValue;

            for(int i = 0; i < arr.Length; i++)
            {
                rsum += arr[i];

                if(arr[i] > max)
                {
                    max = arr[i];
                }
            }

            for(int i = 1; i<= max; i++)
            {
                vsum += i;
            }

            int missing = vsum - rsum;

            Console.WriteLine(missing);

            Console.ReadKey();
        }
    }
}
