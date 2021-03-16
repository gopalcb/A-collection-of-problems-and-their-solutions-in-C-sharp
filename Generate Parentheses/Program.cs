using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate_Parentheses
{
    class Program
    {
        public static IList<string> solve(int n, int l, int r, string p, List<string> res)
        {
            if (r == n)
            {
                res.Add(p);
            }
            else
            {
                if (l > r)
                {
                    solve(n, l, r + 1, p + ")", res);
                }
                if (l < n)
                {
                    solve(n, l + 1, r, p + "(", res);
                }
            }

            return res;
        }

        static void Main(string[] args)
        {
            var res = solve(3, 0, 0, "", new List<string>());
        }
    }
}
