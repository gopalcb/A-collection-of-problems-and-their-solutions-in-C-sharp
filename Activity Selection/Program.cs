using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_Selection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 3, 2, 5, 8, 5 };
            int[] arr2 = new int[] { 2, 4, 6, 7, 9, 9 };

            int end = 0;

            for(int i = 0; i < arr1.Length; i++)
            {
                if(arr1[i] < arr2[i] && arr1[i] >= end)
                {
                    end = arr2[i];
                    Console.WriteLine(arr1[i] + ", " + arr2[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
