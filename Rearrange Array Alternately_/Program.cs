using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rearrange_Array_Alternately_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int[] out_ = new int[arr.Length];
            int n = 0;

            int left = 0;
            int right = arr.Length - 1;

            while(n < out_.Length)
            {
                out_[n] = arr[right];

                if(n + 1 < out_.Length)
                    out_[n + 1] = arr[left];

                n += 2;
                left++;
                right--;
            }

            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(out_[i] + "  ");
            }

            Console.ReadKey();
        }
    }
}
