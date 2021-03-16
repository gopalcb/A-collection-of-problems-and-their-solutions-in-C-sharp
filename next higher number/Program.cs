using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace next_higher_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 32841;
            int[] arr = n.ToString().ToArray().Select(x => Convert.ToInt32(x.ToString())).ToArray();
            int d1 = 0;
            int d2 = 0;
            int d1_index = 0;
            int d2_index = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if(i == arr.Length - 1)
                {
                    d1 = arr[i];
                    d2 = arr[i];
                }
                else if (arr[i] > d1)
                {
                    d1 = arr[i];
                }
                else if (arr[i] < d1)
                {
                    d1 = arr[i];
                    d1_index = i;
                    break;
                }
            }

            for(int i = arr.Length - 1; i >= d1_index; i--)
            {
                if (d1 < arr[i] && arr[i] < d2)
                {
                    d2 = arr[i];
                    d2_index = i;
                }
            }

            int temp = arr[d1_index];
            arr[d1_index] = arr[d2_index];
            arr[d2_index] = temp;

            var subarr = arr.Skip(d1_index).Take(arr.Length-1).ToArray();

            Array.Sort(subarr);

            int olen = arr.Length - 1;
            for (int i = subarr.Length-1; i >= 0; i--)
            {
                arr[olen] = subarr[i];
                olen--;
            }

            Console.ReadKey();
        }
    }
}
