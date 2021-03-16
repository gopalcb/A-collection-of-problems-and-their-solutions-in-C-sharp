using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        int fibb(int n, Dictionary<int, int> memo, List<long> odd_nums)
        {
            // for initial two values return themselves
            if (n == 0) return 0;
            if (n == 1) return 1;
            // if the iteration value is already in dict return it
            if (memo.ContainsKey(n))
            {
                // check if the value is odd then add into list
                if(memo[n] % 2 != 0 && memo[n] < 10000)
                {
                    odd_nums.Add(memo[n]);
                }
                return memo[n];
            }
            // else compute fibonacci
            memo[n] = fibb(n - 1, memo, odd_nums) + fibb(n - 2, memo, odd_nums);
            if (memo[n] % 2 != 0 && memo[n] < 10000)
            {
                // check if the value is odd then add into list
                odd_nums.Add(memo[n]);
            }
            return memo[n];
        }

        static void Main(string[] args)
        {
            var p = new Program();
            // set value for iteration
            int n = 21;
            // define dp dictionary
            var memo = new Dictionary<int, int>();
            // this list contains all odd numbers
            var odd_nums = new List<long>();
            // call fibb function to compute fibonacci
            var res = p.fibb(n, memo, odd_nums);
            // distinct the odd numbers list
            odd_nums = odd_nums.Distinct().ToList();
            // get sum of odd numbers
            long sum_ = odd_nums.Sum();
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
