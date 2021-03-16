using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robot_in_a_grid
{
    class Program
    {
        //01-R, 10-D
        static int[] Path_Row = { 0, 1};
        static int[] Path_Col = { 1, 0};
        string path = "";
        int max_path = 0;
        int min_path = int.MaxValue;

        static int[,] maze =
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

        static void Main(string[] args)
        {
            var p = new Program();
            visited[0, 0] = 1;
            FindPathInMaze(maze, visited, 0, 0, 3, 3, 1, new Stack(), p);
            Console.ReadKey();
        }

        public static void FindPathInMaze(int[,] maze, int[,] visited, int row, int col, int desRow, int desCol, int move, Stack st, Program p)
        {
            if (row == desRow && col == desCol)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(visited[i, j] + ", ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("//////////");

                string path = "";

                if (st.Count > p.max_path)
                {
                    p.max_path = st.Count;
                }

                if(st.Count < p.min_path)
                {
                    p.min_path = st.Count;
                }


                foreach (string str in st)
                {
                    path = str + path;
                }

                Console.WriteLine(path);
            }
            else
            {
                for (int i = 0; i < Path_Row.Length; i++)
                {
                    int rowNew = row + Path_Row[i];
                    int colNew = col + Path_Col[i];

                    if (CanMove(maze, visited, rowNew, colNew))
                    {
                        //for path
                        if (Path_Row[i] == 0 && Path_Col[i] == 1)
                        {
                            st.Push("R");
                        }
                        if (Path_Row[i] == 1 && Path_Col[i] == 0)
                        {
                            st.Push("D");
                        }
                        //
                        move++;
                        visited[rowNew, colNew] = move;
                        FindPathInMaze(maze, visited, rowNew, colNew, desRow, desCol, move, st, p);
                        move--;
                        st.Pop();
                        visited[rowNew, colNew] = 0;
                    }
                }
            }
        }

        public static bool CanMove(int[,] maze, int[,] visited, int rowNew, int colNew)
        {
            if (rowNew >= 0 && rowNew < 4 && colNew >= 0 && colNew < 4 && maze[rowNew,colNew] == 1 && visited[rowNew, colNew] == 0)
            {
                return true;
            }
            return false;
        }
    }
}
