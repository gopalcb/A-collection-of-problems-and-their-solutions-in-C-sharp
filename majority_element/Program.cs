using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majority_element
{
    class Program
    {
        static void Main(string[] args)
        {
            var hash = new Dictionary<int, int>();
            int[] arr = { 1, 2, 5, 9, 5, 9, 5, 5, 5 };
            int max = 0;
            int key = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if (hash.ContainsKey(arr[i]))
                {
                    hash[arr[i]] = hash[arr[i]] + 1;
                    if (hash[arr[i]] > max)
                    {
                        max = hash[arr[i]];
                        key = arr[i];
                    }
                }
                else
                {
                    hash.Add(arr[i], 1);
                    if (hash[arr[i]] > max)
                    {
                        max = hash[arr[i]];
                        key = arr[i];
                    }
                }
            }

            Console.WriteLine("Majority element: " + hash[key]);
            Console.ReadKey();
        }
    }
}
