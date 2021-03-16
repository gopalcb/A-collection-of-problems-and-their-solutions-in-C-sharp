using System;
using System.Collections.Generic;

class GFG
{
    static int ROW = 5;
    static int COL = 5;
    
    public class Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    };
    
    public class queueNode
    {
        public Point pt;
        
        public int dist;

        public queueNode(Point pt, int dist)
        {
            this.pt = pt;
            this.dist = dist;
        }
    };
    
    static bool isValid(int row, int col)
    {
        // return true if row number and column number is in range 
        return (row >= 0) && (row < ROW) && (col >= 0) && (col < COL);
    }
    
    static int[] rowNum = { -1, 0, 0, 1 };
    static int[] colNum = { 0, -1, 1, 0 };
    
    static int BFS(int[,] mat, Point src, Point dest)
    {
        // check source and destination cell of the matrix have value 1 
        if (mat[src.x, src.y] < 1 || mat[dest.x, dest.y] < 1)
            return -1;

        bool[,] visited = new bool[ROW, COL];
        visited[src.x, src.y] = true;
        
        Queue<queueNode> q = new Queue<queueNode>();

        // Distance of source cell is 0 
        queueNode s = new queueNode(src, 0);
        q.Enqueue(s);

        // Do a BFS starting from source cell 
        while (q.Count != 0)
        {
            queueNode curr = q.Peek();
            Point pt = curr.pt;

            // If we have reached the destination cell, we are done 
            if (pt.x == dest.x && pt.y == dest.y)
                return curr.dist;

            // Otherwise dequeue the front cell in the queue and enqueue its adjacent cells 
            q.Dequeue();

            for (int i = 0; i < 4; i++)
            {
                int row = pt.x + rowNum[i];
                int col = pt.y + colNum[i];
                
                if (isValid(row, col) && mat[row, col] >= 1 && !visited[row, col])
                { 
                    visited[row, col] = true;
                    queueNode Adjcell = new queueNode(new Point(row, col), curr.dist + 1);
                    q.Enqueue(Adjcell);
                }
            }
        }
        
        return -1;
    }
    
    public static void Main(String[] args)
    {
        int[,] mat = {{ 5, 4, 1, 1, 1 },
                      { 9, 0, 1, 0, 1 },
                      { 5, 6, 5, 0, 1},
                      { 0, 0, 4, 5, 1 },
                      { 0, 0, 4, 5, 1 }};

        Point source = new Point(0, 0);
        Point dest = new Point(4, 4);

        int dist = BFS(mat, source, dest);

        if (dist != int.MaxValue)
            Console.WriteLine("Shortest Path is " + dist);
        else
            Console.WriteLine("Shortest Path doesn't exist");

        Console.ReadKey();
    }
}