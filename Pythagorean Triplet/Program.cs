using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pythagorean_Triplet
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 2, 4, 6, 5 };

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * arr[i];
            }

            Array.Sort(arr);

            for (int i = arr.Length - 1; i >= 2; i--)
            { 
                int l = 0;
                int r = i - 1;

                while (l < r)
                {
                    // A triplet found 
                    if (arr[l] + arr[r] == arr[i])
                        Console.WriteLine(arr[i] + "," + arr[l] + "," + arr[r]);

                    // Else either move 'l' or 'r' 
                    if (arr[l] + arr[r] < arr[i])
                        l++;
                    else
                        r--;
                }
            }

            Console.ReadKey();
        }
    }
}
