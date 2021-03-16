using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolutions
{
    class Program
    {
        //01-R, 0-1-L, 10-D, -10-U
        static int[] Path_Row = { 0, 0, 1, -1 };
        static int[] Path_Col = { 1, -1, 0, 0 };
        string path = "";
        //Stack st = new Stack();

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
            var mazes = new List<List<int>>();

            Console.WriteLine();
            int N = Convert.ToInt32(Console.ReadLine());
            
            string[] items = Console.ReadLine().Split(' ');

            var mz = new List<int>();
            int c = 0;

            for (int j = 0; j < N*N; j++)
            {
                mz.Add(Convert.ToInt32(items[j]));
                c++;
                if (c == 4)
                {
                    mazes.Add(mz);
                    c = 0;
                    mz = new List<int>();
                }
            }



            visited[0, 0] = 1;
            FindPathInMaze(mazes, visited, 0, 0, 3, 3, 1, new Stack());
            Console.ReadKey();
        }

        public static void FindPathInMaze(/*int[,] maze*/ List<List<int>> maze, int[,] visited, int row, int col, int desRow, int desCol, int move, Stack st)
        {
            if (row == desRow && col == desCol)
            {
                for(int i = 0; i < 4; i++)
                {
                    for (int j=0; j < 4; j++)
                    {
                        Console.Write(visited[i, j] + ", ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("//////////");

                string path = "";
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
                        if (Path_Row[i] == 0 && Path_Col[i] == -1)
                        {
                            st.Push("L");
                        }
                        if (Path_Row[i] == 1 && Path_Col[i] == 0)
                        {
                            st.Push("D");
                        }
                        if (Path_Row[i] == -1 && Path_Col[i] == 0)
                        {
                            st.Push("U");
                        }
                        //
                        move++;
                        visited[rowNew, colNew] = move;
                        FindPathInMaze(maze, visited, rowNew, colNew, desRow, desCol, move, st);
                        move--;
                        st.Pop();
                        visited[rowNew, colNew] = 0;
                    }
                }
            }
        }

        public static bool CanMove(/*int[,] maze*/ List<List<int>> maze, int[,] visited, int rowNew, int colNew)
        {
            if(rowNew >= 0 && rowNew < 4 && colNew >=0 && colNew < 4 && maze[rowNew][colNew] == 1 && visited[rowNew, colNew] == 0)
            {
                return true;
            }
            return false;
        }
    }
}
