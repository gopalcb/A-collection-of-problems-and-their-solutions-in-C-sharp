using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flood_fill_algorithm
{
    class Program
    {
        //01-R, 0-1-L, 10-D, -10-U
        static int[] Path_Row = { 0, 0, 1, -1 };
        static int[] Path_Col = { 1, -1, 0, 0 };
        string path = "";
        //Stack st = new Stack();

        static int[,] maze = {
            {1, 1, 1, 1, 1, 1, 1, 1},
            {1, 1, 1, 1, 1, 1, 0, 0},
            {1, 0, 0, 1, 1, 0, 1, 1},
            {1, 2, 2, 2, 2, 0, 1, 0},
            {1, 1, 1, 2, 2, 0, 1, 0},
            {1, 1, 1, 2, 2, 2, 2, 0},
            {1, 1, 1, 1, 1, 2, 1, 1},
            {1, 1, 1, 1, 1, 2, 2, 1},
        };

        static int[,] visited = {
            {0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0},
            {1, 0, 0, 1, 1, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0},
        };

        static void Main(string[] args)
        {
            
            visited[3, 1] = 1;
            FindPathInMaze(maze, visited, 3, 1, 1);

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(maze[i, j] + ", ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        public static void FindPathInMaze(int[,] maze, int[,] visited, int row, int col, int move)
        {
            for (int i = 0; i < Path_Row.Length; i++)
            {
                int rowNew = row + Path_Row[i];
                int colNew = col + Path_Col[i];

                if (CanMove(maze, visited, rowNew, colNew))
                {
                    move++;
                    visited[rowNew, colNew] = move;
                    maze[rowNew, colNew] = 5;
                    FindPathInMaze(maze, visited, rowNew, colNew, move);
                    move--;
                    visited[rowNew, colNew] = 0;
                }
            }
        }

        public static bool CanMove(int[,] maze, int[,] visited, int rowNew, int colNew)
        {
            if (rowNew >= 0 && rowNew < 7 && colNew >= 0 && colNew < 7 && maze[rowNew,colNew] == 2 && visited[rowNew, colNew] == 0)
            {
                return true;
            }
            return false;
        }
    }
}
