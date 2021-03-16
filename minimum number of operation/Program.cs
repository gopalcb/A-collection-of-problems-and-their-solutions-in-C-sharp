using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimum_number_of_operation
{
    class Program
    {
        static int count = 0;

        public static void solve(int n)
        {
            if (n == 0)
            {
                return;
            }
            else if (n % 2 == 0)
            {
                count++;
                solve(n / 2);
            }
            else
            {
                count++;
                solve(n - 1);
            }
        }

        static void Main(string[] args)
        {
            int n = 8;

            solve(n);

            Console.WriteLine(count);

            Console.ReadKey();
        }
    }
}
