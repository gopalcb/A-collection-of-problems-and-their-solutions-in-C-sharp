using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cutting_Rod_dynamic_programming
{
    class Program
    {
        static void Main(string[] args)
        {
            int rod_len = 11;
            int[] price = new int[] { 2, 3, 5 };

            int[] table = new int[rod_len + 1];

            // init dp table with -1 value
            for (int i = 0; i <= rod_len; i++)
            {
                table[i] = -1;
            }

            // if length of rod is 0 then total cuts will be 0 so, initialize table[0] with 0 
            table[0] = 0;

            for (int i = 0; i <= rod_len; i++)
            {
                for(int j = 0; j < price.Length; j++)
                {

                    if (rod_len>= i + price[j])
                    {
                        int val = Math.Max(1 + table[i], table[i + price[j]]);
                        table[i + price[j]] = val;
                    }
                    
                }
            }

            Console.WriteLine(table[rod_len]);

            Console.ReadKey();
        }
    }
}
