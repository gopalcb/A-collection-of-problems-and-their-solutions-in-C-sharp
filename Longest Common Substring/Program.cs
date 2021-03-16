using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Common_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "ABCDGH";
            string s2 = "ACDGHR";

            char[] s1_arr = s1.ToCharArray();
            char[] s2_arr = s2.ToCharArray();

            int[,] dps = new int[s1_arr.Length + 1, s2_arr.Length + 1];

            int max = 0;
            int mr = 0; int mc = 0;
            string lcs = string.Empty;
            string lcs2 = string.Empty;

            for (int i = 0; i < s1_arr.Length; i++)
            {
                for (int j = 0; j < s2_arr.Length; j++)
                {
                    //if two char sare same (a,a) put diag val+1, else 0
                    if (s1_arr[i] == s2_arr[j])
                    {
                        int dv = 1 + dps[i, j];
                        dps[i + 1, j + 1] = dv;

                        if (dv > max)
                        {
                            max = dv;
                            mr = i + 1;
                            mc = j + 1;

                            //lcs2 = lcs2 + s1_arr[1];
                        }
                    }
                    else
                    {
                        dps[i + 1, j + 1] = 0;
                    }
                }
            }
            
            while (mr > 1)
            {
                lcs = s1_arr[mr-1] + lcs;
                mr--;
            }

            Console.WriteLine("Length: " + max);
            Console.WriteLine("LCS:" + lcs);

            Console.ReadKey();
        }
    }
}
