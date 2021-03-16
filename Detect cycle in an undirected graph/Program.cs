﻿using System;
using System.Collections.Generic;

class Graph
{
    private int V; // No. of vertices 
    
    private List<int>[] adj;
    
    Graph(int v)
    {
        V = v;
        adj = new List<int>[v];
        for (int i = 0; i < v; ++i)
            adj[i] = new List<int>();
    }
    
    void addEdge(int v, int w)
    {
        adj[v].Add(w);
        adj[w].Add(v);
    }
    
    bool dfs(int v, Boolean[] visited, int parent)
    {
        visited[v] = true;
        
        foreach (int i in adj[v])
        {
            if (!visited[i])
            {
                if (dfs(i, visited, v))
                    return true;
            }

            // If an adjacent is visited and not parent of current vertex, then there is a cycle. 
            else if (i != parent)
                return true;
        }
        return false;
    }
    
    bool isCyclic()
    {
        bool[] visited = new bool[V];
        for (int i = 0; i < V; i++)
            visited[i] = false;
        
        for (int u = 0; u < V; u++)
            if (!visited[u])
                if (dfs(u, visited, -1))
                    return true;

        return false;
    }

    // Driver Code 
    public static void Main(String[] args)
    {
        Graph g1 = new Graph(5);
        g1.addEdge(1, 0);
        g1.addEdge(0, 2);
        g1.addEdge(2, 1);
        g1.addEdge(0, 3);
        g1.addEdge(3, 4);
        if (g1.isCyclic())
            Console.WriteLine("Graph contains cycle");
        else
            Console.WriteLine("Graph doesn't contains cycle");

        Graph g2 = new Graph(3);
        g2.addEdge(0, 1);
        g2.addEdge(1, 2);
        if (g2.isCyclic())
            Console.WriteLine("Graph contains cycle");
        else
            Console.WriteLine("Graph doesn't contains cycle");

        Console.ReadKey();
    }
}