using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Cost_Path_with_Left__Right__Bottom_and_Up_moves_allowed
{
    class Program
    {
        static int V = 5;
        static List<int> costList = new List<int>();

        static Queue<int> rq = new Queue<int>();
        static Queue<int> cq = new Queue<int>();
        static int[] dir_row = { 0, 0, 1, -1 };
        static int[] dir_col = { 1, -1, 0, 0 };
        static int min = int.MaxValue;


        public static void minPath(int[,] grid, int[,] visited, int row, int col, int desRow, int desCol, int val)
        {
            if (row == desRow && col == desCol)
            {
                costList.Add(visited[4, 4]);
                if (min > visited[4, 4])
                {
                    min = visited[4, 4];
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
                        val += grid[rowNew, colNew];
                        visited[rowNew, colNew] = val;
                        minPath(grid, visited, rowNew, colNew, desRow, desCol, val);
                        val -= grid[rowNew, colNew];
                        visited[rowNew, colNew] = 0;
                    }
                }
            }
        }

        public static bool canMove(int[,] grid, int[,] v, int rowNew, int colNew)
        {
            if (rowNew >= 0 && rowNew < 5 && colNew >= 0 && colNew < 5 && grid[rowNew, colNew] > 0 && v[rowNew, colNew] == 0)
            {
                return true;
            }
            return false;
        }


        static void Main(string[] args)
        {
            int[,] graph = new int[,] { {31,  100, 65,  12,  18 },
                                        {10,  13,  47,  157, 6 },
                                        {100, 113, 174, 11,  33 },
                                        {88,  124, 41,  20,  140},
                                        {99,  32,  111, 41,  20} };

            int[,] v = new int[5,5];

            costList.Add(graph[0,0]);
            v[0, 0] = 1;
            minPath(graph, v, 0, 0, 4, 4, graph[0, 0]);

            Console.ReadKey();
        }
    }
}
