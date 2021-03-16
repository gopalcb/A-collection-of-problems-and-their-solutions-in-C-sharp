using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spirally_traversing_a_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,]
            {
                {1,  2,  3,  4 },
                {5,  6,  7,  8 },
                {9,  10, 11, 12 },
                {13, 14, 15, 16 }
            };

            var list = new List<int>();

            int r1 = 0; int r2 = matrix.GetLength(0) - 1;
            int c1 = matrix.GetLength(1)-1; int c2 = 0;

            int factor = 0;

            while (list.Count != matrix.Length)
            {
                for (int j = r1; j <= c1; j++)
                {
                    list.Add(matrix[r1, j]);
                }

                for (int i = r1 + 1; i <= r2; i++)
                {
                    list.Add(matrix[i, c1]);
                }
                
                for(int j = c1-1; j >= c2; j--)
                {
                    list.Add(matrix[r2, j]);
                }

                for (int i = r2-1; i >= r1 + 1; i--)
                {
                    list.Add(matrix[i, c2]);
                }

                r1++; r2--;
                c1--; c2++;
            }

        }
    }
}
