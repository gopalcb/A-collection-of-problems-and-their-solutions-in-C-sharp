using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_coin_count
{
    class Program
    {
        public static int makeChanges(int amount)
        {
            if (amount <= 0) return 0;
            if (amount < 5) return 1;
            int[] denom = { 25, 10, 5, 1 };
            int[,] dp = new int[amount + 1,denom.Length];
            return helper(amount, denom, dp, 0);

        }

        private static int helper(int amount, int[] denom, int[,] dp, int index)
        {
            // TODO Auto-generated method stub

            if (dp[amount,index] > 0)
            {
                Console.WriteLine("amount = " + amount + " index = " + index + " value = " + dp[amount,index]);
                return dp[amount,index];

            }
            if (index >= denom.Length - 1) return 1;
            int denominator = denom[index];
            int ways = 0;
            for (int i = 0; i * denominator <= amount; i++)
            {
                ways += helper(amount - i * denominator, denom, dp, index + 1);
            }
            dp[amount,index] = ways;
            return ways;
        }

        static void Main(string[] args)
        {
            int n = 10;
            Console.WriteLine(makeChanges(n));
            Console.ReadKey();
        }
    }
}
