using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equilibrium_point_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 3, 5, 2, 2 };
            int lsum = 0, rsum = 0;
            int pos = -1;

            if (arr.Length == 1) Console.WriteLine("1");

            for (int i = 0; i < arr.Length; i++)
            {
                rsum += arr[i];
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (i > 0) lsum += arr[i - 1];
                rsum -= arr[i];

                if (lsum == rsum)
                {
                    pos = i + 1;
                    break;
                }
            }

            Console.WriteLine(pos);

            Console.ReadKey();
        }
    }
}
