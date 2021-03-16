using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_number_possible
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 3;
            int S = 20;

            string str = string.Empty;
            int sum = 0;

            for(int i = 0; i < N; i++)
            {
                if(S - sum > 9)
                {
                    str += "9";
                    sum += 9;
                }
                else
                {
                    str += S - sum;
                    sum += S - sum;
                }
            }

            Console.WriteLine(str);

            Console.ReadKey();
        }
    }
}
