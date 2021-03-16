using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int[] arr = new int[n + 1];

            arr[0] = 1;
            arr[1] = 1;

            for(int i = 2; i <= n; i++)
            {
                arr[i] = i * arr[i - 1];
            }

            Console.WriteLine(arr[n]);

            Console.ReadKey();
        }
    }
}
