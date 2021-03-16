using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_the_triplets
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 5, 3, 2 };
            int count = 0;

            Array.Sort(arr);

            for(int i = 0; i < arr.Length; i++)
            {
                int l = 0;
                int r = arr.Length - 1;

                while(l < r)
                {
                    int sum = arr[l] + arr[r];

                    if (sum == arr[i])
                    {
                        count++;

                        Console.WriteLine(arr[l] + "+" + arr[r] + "=" + arr[i]);
                        l++;
                    }
                    else if (sum > arr[i])
                    {
                        r--;
                    }
                    else
                    {
                        l++;
                    }
                }
            }

            count = count > 0 ? count : -1;

            Console.WriteLine(count);

            Console.ReadKey();
        }
    }
}
