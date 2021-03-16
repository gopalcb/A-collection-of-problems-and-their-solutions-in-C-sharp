using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_length_chain
{
    class Program
    {
        static void Main(string[] args)
        {
            //5  24 39 60 15 28 27 40 50 90
            int[,] pairs =
            {
                {5,  24 },
                {39, 60 },
                {15, 28 },
                {27, 40 },
                {50, 90 }
            };

            var d = new Dictionary<int, int>();
            int[] xs = new int[pairs.GetLength(0)];

            for(int i = 0; i < pairs.GetLength(0); i++)
            {
                d.Add(pairs[i, 0], pairs[i, 1]);
                xs[i] = pairs[i, 0];
            }

            Array.Sort(xs);

            int c = pairs[0, 1];
            int count = 1;

            for (int i = 1; i < xs.Length; i++)
            {
                if(xs[i] > c)
                {
                    count++;
                    c = d[xs[i]];
                }
            }

            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
