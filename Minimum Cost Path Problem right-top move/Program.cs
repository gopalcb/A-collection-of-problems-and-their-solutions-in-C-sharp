using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Cost_Path_Problem_right_top_move
{
    public class MinCostPath
    {

        public static int find(int[,] A)
        {
            int[,] solution = new int[A.Length,A.Length];

            solution[0,0] = A[0,0];
            // fill the first row
            for (int i = 1; i < A.Length; i++)
            {
                solution[0,i] = A[0,i] + solution[0,i - 1];
            }

            // fill the first column
            for (int i = 1; i < A.Length; i++)
            {
                solution[i,0] = A[i,0] + solution[i - 1,0];
            }

            // path will be either from top or left, choose which ever is minimum
            for (int i = 1; i < A.Length; i++)
            {
                for (int j = 1; j < A.Length; j++)
                {
                    solution[i,j] = A[i,j]
                            + Math.Min(solution[i - 1,j], solution[i,j - 1]);
                }
            }
            return solution[A.Length - 1,A.Length - 1];
        }

        static void Main(string[] args)
        {
            int[,] A = { { 1, 7, 9, 2 }, { 8, 6, 3, 2 }, { 1, 6, 7, 8 },
                { 2, 9, 8, 2 } };
            Console.WriteLine("Minimum Cost Path " + find(A));

            Console.ReadKey();
        }
    }
}
