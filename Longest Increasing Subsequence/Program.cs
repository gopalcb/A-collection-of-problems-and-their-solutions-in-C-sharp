using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 4, -1, 0, 6, 1, 2, 3, 8, 7 };
            int[] table = new int[arr.Length];
            int[] actualSolution = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                table[i] = 1;
                actualSolution[i] = i;
            }

            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        if (table[j] + 1 > table[i])
                        {
                            table[i] = table[j] + 1;
                            //set the actualSolution to point to guy before me
                            actualSolution[i] = j;
                        }
                    }
                }
            }

            int cmp = arr[arr.Length - 1];
            for (int i = arr.Length - 2; i >= 0; i++)
            {

            }
        }
    }
}
