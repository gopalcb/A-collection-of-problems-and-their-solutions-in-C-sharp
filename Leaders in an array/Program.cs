using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leaders_in_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 16, 17, 4, 3, 5, 2 };
            //int[] arr = { 1, 2, 3, 4, 0 };
            int[] arr = { 7, 4, 5, 7, 3 };

            var stack = new Stack<int>();

            for(int i = 0; i < arr.Length; i++)
            {
                if(i == arr.Length - 1)
                {
                    stack.Push(arr[i]);
                }
                else if(arr[i] > arr[i + 1])
                {
                    stack.Push(arr[i]);
                }
                else
                {
                    if (stack != null && i !=0 && stack.Contains(arr[i-1]))
                    {
                        var v = stack.Pop();
                        if (v >= arr[i + 1])
                        {
                            stack.Push(v);
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
