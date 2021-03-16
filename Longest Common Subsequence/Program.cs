using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Common_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "abcdxf";
            string s2 = "aebcf";

            char[] s1_arr = s1.ToCharArray();
            char[] s2_arr = s2.ToCharArray();

            int[,] dps = new int[s1_arr.Length + 1, s2_arr.Length + 1];

            int max = 0;
            int mr = 0; int mc = 0;
            string lcs = string.Empty;

            for (int i = 0; i < s1_arr.Length; i++)
            {
                for (int j = 0; j < s2_arr.Length; j++)
                {
                    //if two char sare same (a,a) put diag val+1, else max(left,top)
                    int value = 0;
                    if (s1_arr[i] == s2_arr[j])
                    {
                        value = 1 + dps[i, j];
                        dps[i + 1, j + 1] = value;
                    }
                    else
                    {
                        value = Math.Max(dps[i + 1, j], dps[i, j + 1]);
                        dps[i + 1, j + 1] = value;
                    }

                    if (value > max)
                    {
                        max = value;
                        mr = i + 1;
                        mc = j + 1;
                    }
                }
            }

            //while (mr > 1)
            //{
            //    lcs = s1_arr[mr - 1] + lcs;
            //    mr--;
            //}

            Console.WriteLine("Length: " + max);
            Console.WriteLine("LCS:" + lcs);

            Console.ReadKey();
        }
    }
}
