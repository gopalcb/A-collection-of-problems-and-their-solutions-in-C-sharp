using System;
using System.Collections.Generic;

public class Graph
{

    private readonly int V;
    private readonly List<List<int>> adj;

    public Graph(int V)
    {
        this.V = V;
        adj = new List<List<int>>(V);

        for (int i = 0; i < V; i++)
            adj.Add(new List<int>());
    }
    
    private bool dfs(int i, bool[] visited, bool[] recStack)
    {
        // Mark the current node as visited and part of recursion stack  
        if (recStack[i])
            return true;

        if (visited[i])
            return false;

        visited[i] = true;

        recStack[i] = true;
        List<int> children = adj[i];

        foreach (int c in children)
            if (dfs(c, visited, recStack))
                return true;

        recStack[i] = false;

        return false;
    }

    private void addEdge(int sou, int dest)
    {
        adj[sou].Add(dest);
    }
    
    private bool isCyclic()
    {
        bool[] visited = new bool[V];
        bool[] recStack = new bool[V];
        
        for (int i = 0; i < V; i++)
            if (dfs(i, visited, recStack))
                return true;

        return false;
    }
    
    public static void Main(String[] args)
    {
        Graph graph = new Graph(4);
        graph.addEdge(0, 1);
        graph.addEdge(0, 2);
        graph.addEdge(1, 2);
        graph.addEdge(2, 0);
        graph.addEdge(2, 3);
        graph.addEdge(3, 3);

        if (graph.isCyclic())
            Console.WriteLine("Graph contains cycle");
        else
            Console.WriteLine("Graph doesn't "
                                    + "contain cycle");

        Console.ReadKey();

    }
}