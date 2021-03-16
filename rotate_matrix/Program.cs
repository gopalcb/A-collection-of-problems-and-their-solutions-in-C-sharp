using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rotate_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] oldMatrix = new int[3, 5]
            {
                { 3, 4, 5, 6, 8 },
                { 5, 4, 3, 2, 6 },
                { 3, 3, 7, 8, 9 }
            };

            int[,] newMatrix = new int[oldMatrix.GetLength(1), oldMatrix.GetLength(0)];
            int newColumn, newRow = 0;
            for (int oldColumn = oldMatrix.GetLength(1) - 1; oldColumn >= 0; oldColumn--)
            {
                newColumn = 0;
                for (int oldRow = 0; oldRow < oldMatrix.GetLength(0); oldRow++)
                {
                    newMatrix[newRow, newColumn] = oldMatrix[oldRow, oldColumn];
                    newColumn++;
                }
                newRow++;
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(newMatrix[i, j] + "  ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
