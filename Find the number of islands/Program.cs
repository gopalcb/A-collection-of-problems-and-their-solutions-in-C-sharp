using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_of_island
{
    class Program
    {
        static int[] Path_Row = { 0, 0, 1, -1 };
        static int[] Path_Col = { 1, -1, 0, 0 };
        string path = "";
        int count = 0;

        static int[,] matrix = new int[5, 5]
            {
                { 1, 1, 0, 0, 1 },
                { 1, 1, 0, 0, 0 },
                { 1, 0, 0, 0, 0 },
                { 0, 1, 0, 0, 1 },
                { 1, 1, 0, 1, 1 }
            };

        static int[,] visited = new int[5, 5]
            {
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 }
            };

        static void Main(string[] args)
        {
            int count = 0;
            int max_island = 0;

            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] == 1 && visited[i, j] == 0)
                    {
                        visited[i, j] = 1;
                        FindPathInMaze(matrix, visited, i, j, 1);

                        count++;
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (visited[i, j] > max_island)
                    {
                        max_island = visited[i, j];
                    }
                }
            }

            Console.WriteLine("Total island = " + count);
            Console.WriteLine("Max area of island = " + max_island);
            
            Console.ReadKey();
        }

        public static void FindPathInMaze(int[,] matrix, int[,] visited, int row, int col, int count)
        {
            for (int i = 0; i < Path_Row.Length; i++)
            {
                int rowNew = row + Path_Row[i];
                int colNew = col + Path_Col[i];

                if (CanMove(matrix, visited, rowNew, colNew))
                {
                    count++;
                    visited[rowNew, colNew] = count;
                    FindPathInMaze(matrix, visited, rowNew, colNew, count);
                    //visited[rowNew, colNew] = 0;
                }
            }
        }

        public static bool CanMove(int[,] matrix, int[,] visited, int rowNew, int colNew)
        {
            if (rowNew >= 0 && rowNew < 5 && colNew >= 0 && colNew < 5 && matrix[rowNew, colNew] == 1 && visited[rowNew, colNew] == 0)
            {
                return true;
            }
            return false;
        }
    }
}
