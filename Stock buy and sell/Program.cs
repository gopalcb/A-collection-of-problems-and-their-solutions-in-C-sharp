using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_buy_and_sell
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 100, 180, 260, 310, 40, 535, 695 };
            int start = -1;
            int end = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    if (start >= 0 && end > 0)
                    {
                        Console.WriteLine("(" + start + "," + end + ")");
                        start = -1;
                        end = 0;
                    }
                }
                else if (arr[i + 1] > arr[i])
                {
                    if(start < 0)
                    {
                        start = i;
                    }
                    end = i + 1;
                }
                else if(arr[i + 1] < arr[i])
                {
                    if(start>=0 && end > 0)
                    {
                        Console.WriteLine("(" + start + "," + end + ")");
                        start = -1;
                        end = 0;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
