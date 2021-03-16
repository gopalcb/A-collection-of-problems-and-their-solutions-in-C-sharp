using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Next_Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 2, 0, 4, 3, 1 };
            int len = nums.Length;
            int d1 = 0;
            int d2 = 0;
            int d1i = -1;
            int d2i = -1;

            for (int i = len - 1; i > 0; i--)
            {
                if (nums[i - 1] < nums[i])
                {
                    d1 = nums[i - 1];
                    d1i = i - 1;
                    break;
                }
            }

            if (  )
            {
                for (int i = len - 1; i > d1i; i--)
                {
                    if (nums[i] > d1)
                    {
                        d2 = nums[i];
                        d2i = i;
                        break;
                    }
                }

                nums[d1i] = d2;
                nums[d2i] = d1;

                for (int i = d1i + 1; i < len - 1; i++)
                {
                    int min_idx = i;
                    for (int j = i + 1; j < len; j++)
                    {
                        if (nums[j] < nums[min_idx])
                        {
                            min_idx = j;
                        }
                    }

                    int temp = nums[min_idx];
                    nums[min_idx] = nums[i];
                    nums[i] = temp;
                }
            }
            else
            {
                Array.Sort(nums);
            }

        }
    }
}
