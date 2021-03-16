using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace top_sort
{
    class Graph
    {
        public int V; // No. of vertices 

        //for bfs
        Stack stack = new Stack();
        

        // Array of lists for Adjacency List Representation  
        private List<int>[] adj;

        Graph(int v)
        {
            V = v;
            adj = new List<int>[v];
            for (int i = 0; i < v; ++i)
                adj[i] = new List<int>();
        }
        
        void AddEdge(int v, int w)
        {
            adj[v].Add(w); // Add w to v's list.  
        }

        void DFSUtil(int v, bool[] visited)
        {
            visited[v] = true;
            //Console.Write(v + " ");

            // Recur for all the vertices adjacent to this vertex  
            List<int> vList = adj[v];
            foreach (var n in vList)
            {
                if (!visited[n])
                {
                    DFSUtil(n, visited);

                    //Print sorted
                    Console.Write(n + " ");
                }
            }
        }

        void DFS(int v, bool[] visited)
        {
            DFSUtil(v, visited);
        }

        static void Main(string[] args)
        {
            Graph g = new Graph(4);
            bool[] visited = new bool[g.V];

            //number of vertices 3(0,1,2,3)
            g.AddEdge(0, 1); //edge between 0,1 vertices
            g.AddEdge(1, 2);
            g.AddEdge(2, 3);
            //g.AddEdge(2, 0);
            g.AddEdge(0, 3);
            //g.AddEdge(3, 3);

            Console.WriteLine("Following is Depth First Traversal " +
                              "(starting from vertex 2)");


            //g.DFS(2);
            for (int i = 0; i < 4; i++)
            {
                if (!visited[i])
                {
                    g.DFS(i, visited);
                    Console.Write(i);
                }
            }

            Console.ReadKey();
        }
    }
}
