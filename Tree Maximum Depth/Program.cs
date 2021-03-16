using System;
using System.Collections;
using System.Collections.Generic;

public class Node
{
    public int value;
    public Node left, right;

    public Node(int val)
    {
        value = val;
        left = right = null;
    }
}

public class BinaryTree
{
    Node root;

    int maxDepth(Node root)
    {
        if (root == null)
            return 0;

        // Recursively find the depth of each subtree.
        int leftDepth = maxDepth(root.left);
        int rightDepth = maxDepth(root.right);

        // Get the larger depth and add 1 to it to
        // account for the root.
        if (leftDepth > rightDepth)
            return (leftDepth + 1);
        else
            return (rightDepth + 1);
    }

    // Driver code
    public static void Main()
    {
        BinaryTree tree = new BinaryTree();
        tree.root = new Node(1);
        tree.root.left = new Node(2);
        tree.root.right = new Node(3);
        tree.root.left.left = new Node(4);
        tree.root.right.left = new Node(5);
        tree.root.right.left.left = new Node(12);
        tree.root.right.right = new Node(6);
        tree.root.right.right.left = new Node(8);
        tree.root.right.left.right = new Node(7);
        Console.WriteLine("Max depth: " + tree.maxDepth(tree.root));

        Hashtable hashtable = new Hashtable();

        Console.ReadKey();
    }

    static void VerticalOrdering(Node root)
    {
        Queue<Node> q = new Queue<Node>();
        q.Enqueue(root.left);
        q.Enqueue(root.right);

        var list = new List<int>();
        list.Add(root.Data);

        while (stack.Count > 0)
        {
            Node node = stack.Dequeue();
            if (node != null)
            {
                list.Add(node.Data);

                stack.Enqueue(node.Left);
                stack.Enqueue(node.Right);
            }
        }
        return list;
    }
}