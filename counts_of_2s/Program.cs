using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace counts_of_2s
{
    class Program
    {
        public int count = 0;
        static void Main(string[] args)
        {
            int n = 25;

            var p = new Program();

            for(int i=0; i <= n; i++)
            {
                p.couns_2s(i);
            }
            Console.WriteLine(p.count);
            Console.ReadKey();
        }

        void couns_2s(int x)
        {
            if (x <= 0)
            {
                return;
            }

            if (x % 10 == 2)
            {
                count++;
            }

            couns_2s(x / 10);
        }
    }
}
