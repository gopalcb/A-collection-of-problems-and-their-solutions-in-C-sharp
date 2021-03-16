using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutations_of_a_given_string
{
    class Program
    {
        static List<string> solve(char[] arr, string s, int n, List<string> res)
        {
            if(s.Length == n)
            {
                res.Add(s);
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (!s.Contains(arr[i]))
                    {
                        s += arr[i];
                        solve(arr, s, n, res);
                        s = s.Remove(s.Length - 1);
                    }
                }
            }

            return res;
        }

        static void Main(string[] args)
        {
            char[] arr = new char[] { 'A', 'B', 'C' };

            var res = solve(arr, "", arr.Length, new List<string>());

            foreach(var itm in res)
            {
                Console.WriteLine(itm);
            }

            Console.ReadKey();
        }
    }
}
