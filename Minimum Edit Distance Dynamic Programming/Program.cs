using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Edit_Distance_Dynamic_Programming
{
    class Program
    {
        static string solve(int l, int d, int t)
        {
            string[] map = new string[] { "left", "diag", "left" };
            int[] arr = new int[] { l, d, t };
            int m = Math.Min(l, Math.Min(d, t));
            int i = Array.IndexOf(arr, m);
            return map[i];
        }

        static void Main(string[] args)
        {
            string s1 = "abcdef";
            string s2 = "azced";

            char[] s1_arr = s1.ToCharArray();
            char[] s2_arr = s2.ToCharArray();

            int[,] dps = new int[s1_arr.Length + 1, s2_arr.Length + 1];
            string[,] dpo = new string[s1_arr.Length + 1, s2_arr.Length + 1];

            for (int i = 0; i <= s1_arr.Length; i++)
            {
                dps[i, 0] = i;
            }

            for (int j = 0; j <= s2_arr.Length; j++)
            {
                dps[0, j] = j;
            }

            for (int i = 1; i < dps.GetLength(0); i++)
            {
                for (int j = 1; j < dps.GetLength(1); j++)
                {
                    int value = 0;
                    if (s1_arr[i - 1] == s2_arr[j - 1])
                    {
                        value = dps[i - 1, j - 1];
                        dps[i, j] = value;
                        dpo[i, j] = "d";
                    }
                    else
                    {
                        value = 1 + Math.Min(dps[i, j - 1], Math.Min(dps[i - 1, j - 1], dps[i - 1, j]));
                        dps[i, j] = value;
                        dpo[i, j] = solve(dps[i, j - 1], dps[i - 1, j - 1], dps[i - 1, j]);
                    }
                }
            }

            //move up and get operations
            for(int i= dpo.GetLength(0) - 1; i >= 1; i--)
            {
                for (int j = dpo.GetLength(1) - 1; j >= 1; j--)
                {
                    string dir = dpo[i, j];
                    if(dir == "diag")
                    {
                        if(s1_arr[i-1] == s2_arr[j - 1])
                        {
                            //do nothing
                        }
                        else
                        {
                            Console.WriteLine("edit: " + s1_arr[i - 1] + " -> " + s2_arr[j - 1]);
                        }
                        --i; --j;
                    }
                    else if(dir == "left")
                    {
                        Console.WriteLine("delete: " + s1_arr[i - 1]);
                        --j;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
