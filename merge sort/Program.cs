using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace merge_sort
{
    class Program
    {
        private void Merge(int[] input, int left, int middle, int right)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(input, left, leftArray, 0, middle - left + 1);
            Array.Copy(input, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    input[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else
                {
                    input[k] = rightArray[j];
                    j++;
                }
            }
        }

        private void MergeSort(int[] input, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(input, left, middle);
                MergeSort(input, middle + 1, right);

                Merge(input, left, middle, right);
            }
        }

        public int MinimumSwap(int[] arr, int[] arr_clone)
        {
            var dict = new Dictionary<string, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != arr_clone[i])
                {
                    if(!dict.ContainsKey(arr[i] + "," + arr_clone[i]) && !dict.ContainsKey(arr_clone[i] + "," + arr[i]))
                    {
                        dict.Add(arr[i] + "," + arr_clone[i], 1);
                    }
                }
            }

            return dict.Count;
        }


        static void Main(string[] args)
        {
            int[] arr = new int[]{ 1, 5, 4, 3, 2 };

            int[] arr_clone = new int[arr.Length];

            arr.CopyTo(arr_clone, 0);

            var p = new Program();

            p.MergeSort(arr, 0, arr.Length - 1);
            Console.WriteLine("Sorted Values:");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + "  ");

            int min_swap = p.MinimumSwap(arr, arr_clone);

            Console.ReadKey();
        }
    }
}
