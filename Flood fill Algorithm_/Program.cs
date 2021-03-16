using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flood_fill_Algorithm_
{
    class Program
    {
        static int[] rv = { 0, 0, 1, -1 };
        static int[] cv = { 1, -1, 0, 0 };

        static Stack<int> rs = new Stack<int>();
        static Stack<int> cs = new Stack<int>();

        static Queue<int> rq = new Queue<int>();
        static Queue<int> cq = new Queue<int>();

        static void Main(string[] args)
        {
            //int[,] graph = new int[,]
            //{
            //    {1, 1, 1, 1, 1, 1, 1, 1},
            //    {1, 1, 1, 1, 1, 1, 0, 0},
            //    {1, 0, 0, 1, 1, 0, 1, 1},
            //    {1, 2, 2, 2, 2, 0, 1, 0},
            //    {1, 1, 1, 2, 2, 0, 1, 0},
            //    {1, 1, 1, 2, 2, 2, 2, 0},
            //    {1, 1, 1, 1, 1, 2, 1, 1},
            //    {1, 1, 1, 1, 1, 2, 2, 1}
            //};

            int[,] graph = new int[,]
            {
                {1, 2, 3, 4},
                {5, 6, 0, 7},
                {8, 0, 9, 1},
                {2, 0, 3, 4}
            };

            bool[,] visited = new bool[graph.GetLength(0), graph.GetLength(1)];

            rs.Push(0);
            cs.Push(0);

            rq.Enqueue(0);
            cq.Enqueue(0);

            //solve_dfs(graph, visited);

            //solve_bfs(graph, visited);

            solve_path_dfs(graph, visited, 3, 3);

            for (int i = 0; i < graph.GetLength(0); i++)
            {
                for(int j = 0; j < graph.GetLength(1); j++)
                {
                    Console.Write(graph[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }

        static void solve_path_dfs(int[,] graph, bool[,] visited, int tr, int tc)
        {
            int count = 0;

            while (rs.Count > 0)
            {
                int row = rs.Pop();
                int col = cs.Pop();

                if (row == tr && col == tc)
                {
                    count++;
                }
                else
                {
                    visited[row, col] = true;
                }

                for (int i = 0; i < 4; i++)
                {
                    int r = row + rv[i];
                    int c = col + cv[i];

                    if (CanMove(graph, visited, r, c))
                    {
                        rs.Push(r);
                        cs.Push(c);
                    }
                }
            }

            Console.WriteLine(count);
        }

        static void solve_dfs(int[,] graph, bool[,] visited)
        {
            while(rs.Count > 0)
            {
                int row = rs.Pop();
                int col = cs.Pop();

                if (graph[row, col] == 2)
                {
                    graph[row, col] = 9;
                }
                visited[row, col] = true;

                for (int i = 0; i < 4; i++)
                {
                    int r = row + rv[i];
                    int c = col + cv[i];

                    if (CanMove(graph, visited, r, c))
                    {
                        rs.Push(r);
                        cs.Push(c);
                    }
                }
            }
        }

        static void solve_bfs(int[,] graph, bool[,] visited)
        {
            while (rq.Count > 0)
            {
                int row = rq.Dequeue();
                int col = cq.Dequeue();

                if (graph[row, col] == 2)
                {
                    graph[row, col] = 9;
                }
                visited[row, col] = true;

                for (int i = 0; i < 4; i++)
                {
                    int r = row + rv[i];
                    int c = col + cv[i];

                    if (CanMove(graph, visited, r, c))
                    {
                        rq.Enqueue(r);
                        cq.Enqueue(c);
                    }
                }
            }
        }

        static bool CanMove(int[,] graph, bool[,] visited, int row, int col)
        {
            if(row >=0 && row < graph.GetLength(0) && col >=0 && col < graph.GetLength(1) && graph[row, col] != 0 && !visited[row, col])
            {
                return true;
            }
            return false;
        }

        public static List<string> fetchItemsToDisplay(List<List<string>> items, int sortParameter, int sortOrder, int itemsPerPage, int pageNumber)
        {
            if (items == null) return null;
            if (items.Count == 0) return new List<string>();

            List<string> result = new List<string>();

            if(sortOrder == 0)
            {
                items = items.OrderBy(x => x[sortParameter]).ToList();
            }
            else if(sortOrder == 1)
            {
                items = items.OrderByDescending(x => x[sortParameter]).ToList();
            }

            items = items.Skip((pageNumber + 1) * itemsPerPage).Take(itemsPerPage).ToList();
            
            result = items.Select(x => x[0]).ToList();
            
            return result;
        }
    }

    class Comparator
    {
        bool compare(int a, int b)
        {
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool compare(string a, string b)
        {
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool compare(int[] a, int[] b)
        {
            if(a.Length != b.Length)
            {
                return false;
            }

            for(int i = 0; i < a.Length; i++)
            {
                if(a[i] != b[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
