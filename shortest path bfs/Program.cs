using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shortest_path_bfs
{
    class Program
    {
        static int[] dir_row = { 0, 0, 1, -1 };
        static int[] dir_col = { 1, -1, 0, 0 };

        static int min_path = int.MaxValue;
        static Queue<int> rq = new Queue<int>();
        static Queue<int> cq = new Queue<int>();

        static int[,] grid =
        {
            {1,1,0,1 },
            {0,1,1,1 },
            {0,1,0,1 },
            {0,1,1,1 }
        };

        static int[,] visited =
        {
            {0,0,0,0 },
            {0,0,0,0 },
            {0,0,0,0 },
            {0,0,0,0 }
        };

        public static void findPath(int[,] grid, int[,] visited, int desRow, int desCol, int move)
        {
            int row = rq.Dequeue();
            int col = cq.Dequeue();
            visited[row, col] = 0;

            if (row == desRow && col == desCol)
            {
                if (min_path > visited[3, 3])
                {
                    min_path = visited[3, 3];
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
                        
                    }
                }

                move++;
                visited[row, col] = move;
                findPath(grid, visited, desRow, desCol, move);
                move--;
                visited[row, col] = 0;
            }
        }

        public static bool canMove(int[,] grid, int[,] visited, int rowNew, int colNew)
        {
            if (rowNew >= 0 && rowNew < 4 && colNew >= 0 && colNew < 4 && grid[rowNew, colNew] == 1 && visited[rowNew, colNew] == 0)
            {
                rq.Enqueue(rowNew);
                cq.Enqueue(colNew);
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            visited[0, 0] = 1;
            rq.Enqueue(0);
            cq.Enqueue(0);

            findPath(grid, visited, 5, 5, 1);

            Console.WriteLine(min_path);

            Console.ReadKey();
        }
    }
}
