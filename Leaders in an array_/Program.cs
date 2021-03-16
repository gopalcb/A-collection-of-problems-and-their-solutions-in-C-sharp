using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leaders_in_an_array_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 0 };

            if (arr.Length == 0) Console.WriteLine("");

            for(int i = 0; i < arr.Length - 1; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[i] < arr[j])
                    {
                        break;
                    }

                    if (j == arr.Length - 1) Console.Write(arr[i] + " ");
                }
            }
            Console.Write(arr[arr.Length - 1]);

            Console.ReadKey();
        }
    }
}
