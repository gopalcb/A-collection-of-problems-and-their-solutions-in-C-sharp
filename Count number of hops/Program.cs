using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_number_of_hops
{
    class Program
    {
        static int num_ways(int n, Dictionary<int, int> memo)
        {
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
            int n = 5;

            var memo = new Dictionary<int, int>();

            memo.Add(0, 1);
            memo.Add(1, 1);
            memo.Add(2, 2);

            var ways = num_ways(n, memo);

            Console.ReadKey();
        }
    }
}
