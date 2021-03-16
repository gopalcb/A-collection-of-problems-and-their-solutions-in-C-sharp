using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shortest_path_dfs
{
    class Program
    {
        static int[] dir_row = { 0, 0, 1, -1 };
        static int[] dir_col = { 1, -1, 0, 0 };
        static int min_path = int.MaxValue;

        static int[,] grid =
        {
            { 1,1,0,1,1,1 },
            { 0,1,1,1,1,1 },
            { 0,1,0,1,1,1 },
            { 0,1,1,1,1,1 },
            { 0,1,1,1,1,1 },
            { 0,1,1,1,1,1 }
        };

        static int[,] visited =
        {
            { 0,0,0,0,0,0 },
            { 0,0,0,0,0,0 },
            { 0,0,0,0,0,0 },
            { 0,0,0,0,0,0 },
            { 0,0,0,0,0,0 },
            { 0,0,0,0,0,0 }
        };

        public static void findPath(int[,] grid, int[,] visited, int row, int col, int desRow, int desCol, int move)
        {
            if (row == desRow && col == desCol)
            {
                if(min_path > visited[5, 5])
                {
                    min_path = visited[5, 5];
                }
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    int rowNew = row + dir_row[i];
                    int colNew = col + dir_col[i];

                    if (canMove(grid, visited, rowNew, colNew))
                    {
                        move++;
                        visited[rowNew, colNew] = move;
                        findPath(grid, visited, rowNew, colNew, desRow, desCol, move);
                        move--;
                        visited[rowNew, colNew] = 0;
                    }
                }
            }
        }

        public static bool canMove(int[,] grid, int[,] visited, int rowNew, int colNew)
        {
            if (rowNew >= 0 && rowNew < 6 && colNew >= 0 && colNew < 6 && grid[rowNew, colNew] == 1 && visited[rowNew, colNew] == 0)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            visited[0, 0] = 1;
            findPath(grid, visited, 0, 0, 5, 5, 1);

            Console.WriteLine(min_path);

            Console.ReadKey();
        }
    }
}
