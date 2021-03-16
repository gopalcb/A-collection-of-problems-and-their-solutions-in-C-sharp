using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_staircase_problem
{
    class Program
    {
        static int num_ways(int n, Dictionary<int, int> memo)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }

            if (n == 2)
            {
                return 2;
            }

            if (memo.ContainsKey(n))
            {
                return memo[n];
            }
            else
            {
                int res = num_ways(n - 1, memo) + num_ways(n - 2, memo) + num_ways(n - 3, memo);
                memo.Add(n, res);
            }

            return memo[n];
        }

        static void Main(string[] args)
        {
            int n = 5000;

            var memo = new Dictionary<int, int>();

            memo.Add(0, 1);
            memo.Add(1, 1);
            memo.Add(2, 2);

            var ways = num_ways(n, memo);

            Console.ReadKey();
        }
    }
}
