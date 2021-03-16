using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace towers_of_hanoi
{
    class Program
    {
        static void SolveTowers(int n, char start, char end, char temp)
        {
            if (n > 0)
            {
                SolveTowers(n - 1, start, temp, end);
                Console.WriteLine("Move disk from " + start + ' ' + end);
                SolveTowers(n - 1, temp, end, start);

            }
        }

        static void Main(string[] args)
        {
            char start = 'A';
            char end = 'C';
            char temp = 'B';
            int totalDisks = 4;

            SolveTowers(totalDisks, start, end, temp);

            Console.ReadKey();
        }
    }
}
