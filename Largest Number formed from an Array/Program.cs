using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Number_formed_from_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 30, 34, 9 };

            for(int i = 0; i < arr.Length - 1; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    int a = arr[i];
                    int b = arr[j];

                    int ab = int.Parse(a.ToString() + b.ToString());
                    int ba = int.Parse(b.ToString() + a.ToString());

                    if (ab < ba)
                    {
                        arr[i] = b;
                        arr[j] = a;
                    }
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
