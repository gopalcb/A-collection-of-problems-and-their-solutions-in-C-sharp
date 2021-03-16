using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coin_changing
{
    class Program
    {
        //this solution doesn't work



        static void Main(string[] args)
        {
            int N = 30;
            int[] coins = new int[] { 5, 10, 25 };

            int[] vals = new int[N + 1];

            int[,] dps = new int[coins.Length, N + 1];

            for (int i = 0; i <= N; i++)
            {
                vals[i] = i;
            }

            for (int i = 1; i < dps.GetLength(0); i++)
            {
                for (int j = 0; j < dps.GetLength(1); j++)
                {
                    if(vals[i] < coins[j])
                    {
                        int v = dps[i - 1, j];
                        dps[i, j] = v;
                    }
                    else
                    {
                        int v = Math.Min((1 + dps[i, j - coins[j]]), dps[i - 1, j]);
                        dps[i, j] = v;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
