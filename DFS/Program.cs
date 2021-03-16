using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS
{
    class Graph
    {
        private int V; // No. of vertices 

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

        //Function to Add an edge into the graph  
        void AddEdge(int v, int w)
        {
            adj[v].Add(w); // Add w to v's list.  
        }
        
        void DFSUtil(int v, bool[] visited)
        {
            visited[v] = true;
            Console.Write(v + " ");

            // Recur for all the vertices adjacent to this vertex  
            List<int> vList = adj[v];
            foreach (var n in vList)
            {
                if (!visited[n])
                    DFSUtil(n, visited);
            }
        }

        void DFS(int v)
        {
            bool[] visited = new bool[V];
            DFSUtil(v, visited);
        }

        static void Main(string[] args)
        {
            Graph g = new Graph(4);

            //number of vertices 4(0,1,2,3)
            g.AddEdge(0, 1); //edge between 0,1 vertices
            g.AddEdge(0, 2);
            g.AddEdge(1, 2);
            g.AddEdge(2, 0);
            g.AddEdge(2, 3);
            //g.AddEdge(3, 3);

            Console.WriteLine("Following is Depth First Traversal " +
                              "(starting from vertex 2)");

            g.DFS(2);

            Console.WriteLine("BFS Result");

            g.BFS(2);

            Console.ReadKey();
        }


        void BFSUtil(int v, bool[] visited)
        {
            visited[v] = true;
            Console.Write(v + " ");

            // Recur for all the vertices adjacent to this vertex  
            List<int> vList = adj[v];
            foreach (var item in vList)
            {
                stack.Push(item);
            }

            while (stack.Count > 0)
            {
                int n = Convert.ToInt32(stack.Pop());
                if (!visited[n])
                    BFSUtil(n, visited);
            }
        }

        void BFS(int v)
        {
            bool[] visited = new bool[V];
            BFSUtil(v, visited);
        }
    }
}
