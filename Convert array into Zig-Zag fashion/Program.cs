using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_array_into_Zig_Zag_fashion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 3, 2 };
            bool isLess = true;

            for(int i = 0; i < arr.Length-1; i++)
            {
                int a = arr[i];
                int b = arr[i + 1];

                if((isLess && a > b) || (!isLess && a < b))
                {
                    arr[i] = b;
                    arr[i + 1] = a;
                }

                isLess = isLess == true ? false : true;
            }

            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
