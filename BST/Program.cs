using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class BinarySearchTree
    {
        public class Node
        {
            public int Data;
            public int Level;
            public Node Parent;
            public Node Left;
            public Node Right;
            public void DisplayNode()
            {
                Console.Write(Data + " ");
            }
        }

        public Node root;
        List<List<int>> lbl_data = new List<List<int>>();
        Queue<Node> stack = new Queue<Node>();

        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(int i)
        {
            Node newNode = new Node();
            newNode.Data = i;

            if (root == null)
            {
                root = newNode;
                root.Parent = null;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (i < current.Data)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            parent.Left.Parent = parent;
                            break;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            parent.Right.Parent = parent;
                            break;
                        }
                    }
                }
            }
        }

        public void BFS(BinarySearchTree bst)
        {
            stack = new Queue<Node>();
            //root.Left.Level = 2;
            //root.Right.Level = 2;

            stack.Enqueue(root.Left);
            stack.Enqueue(root.Right);

            int curr_lbl = 2;

            Node parent = root;
            lbl_data.Add(new List<int> { root.Data});

            var temp = new List<int>();

            while (stack.Count > 0)
            {
                Node node = stack.Dequeue();
                if (node != null)
                {
                    if(node.Left != null && node.Right != null)
                    {
                        node.Left.Level = node.Level + 1;
                        node.Right.Level = node.Level + 1;
                    }

                    stack.Enqueue(node.Left);
                    stack.Enqueue(node.Right);

                    if (node.Level == curr_lbl)
                    {
                        temp.Add(node.Data);
                    }
                    else
                    {
                        curr_lbl = node.Level;
                        lbl_data.Add(temp);
                        temp = new List<int>();
                    }
                }
            }
        }

        public Node Search(int data)
        {
            stack = new Queue<Node>();
            stack.Enqueue(root.Left);
            stack.Enqueue(root.Right);

            while (stack.Count > 0)
            {
                Node node = stack.Dequeue();
                if (node != null)
                {
                    if (node.Data == data)
                    {
                        return node;
                    }

                    stack.Enqueue(node.Left);
                    stack.Enqueue(node.Right);
                }
            }
            return null;
        }

        public List<int> SearchAndPrint()
        {
            stack = new Queue<Node>();
            stack.Enqueue(root.Left);
            stack.Enqueue(root.Right);

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

        public bool FirstCommonAncestor_BFS(Node node_root, int data)
        {
            stack = new Queue<Node>();
            stack.Enqueue(node_root.Left);
            stack.Enqueue(node_root.Right);

            while (stack.Count > 0)
            {
                Node node = stack.Dequeue();
                if (node != null)
                {
                    if (node.Data == data)
                    {
                        return true;
                    }

                    stack.Enqueue(node.Left);
                    stack.Enqueue(node.Right);
                }
            }
            return false;
        }

        public int GetHeight(Node root)
        {
            if (root == null) return -1;
            return Math.Max(GetHeight(root.Left), GetHeight(root.Right)) + 1;
        }

        public bool IsBalanced(Node root)
        {
            if (root == null) return true;

            int heightDiff = GetHeight(root.Left) - GetHeight(root.Right);
            if (Math.Abs(heightDiff) > 1)
            {
                return false;
            }
            else
            {
                return IsBalanced(root.Left) && IsBalanced(root.Right);
            }
        }

        public void Preorder(Node Root)
        {
            if (Root != null)
            {
                Console.Write(Root.Data + " ");
                Preorder(Root.Left);
                Preorder(Root.Right);
            }
        }
        public void Inorder(Node Root)
        {
            if (Root != null)
            {
                Inorder(Root.Left);
                Console.Write(Root.Data + " ");
                Inorder(Root.Right);
            }
        }
        public void Postorder(Node Root)
        {
            if (Root != null)
            {
                Postorder(Root.Left);
                Postorder(Root.Right);
                Console.Write(Root.Data + " ");
            }
        }

        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(50);
            bst.Insert(17);
            bst.Insert(23);
            bst.Insert(12);
            bst.Insert(19);
            bst.Insert(54);
            bst.Insert(9);
            bst.Insert(14);
            bst.Insert(67);
            bst.Insert(76);
            bst.Insert(72);

            bst.BFS(bst);

            var isBalanced = bst.IsBalanced(bst.root);

            //in pre post order
            Console.WriteLine("Inorder Traversal : ");
            bst.Inorder(bst.root);
            Console.WriteLine(" ");
            Console.WriteLine();
            Console.WriteLine("Preorder Traversal : ");
            bst.Preorder(bst.root);
            Console.WriteLine(" ");
            Console.WriteLine();
            Console.WriteLine("Postorder Traversal : ");
            bst.Postorder(bst.root);
            Console.WriteLine(" ");

            //First common ancestor
            Node first = bst.Search(9);
            Node parent = first.Parent;
            while (true)
            {
                bool found = bst.FirstCommonAncestor_BFS(parent, 19);
                if (!found)
                {
                    parent = parent.Parent;
                }
                else
                {
                    Console.WriteLine("First common ancestor:" + parent.Data);
                    break;
                }
            }

            //Get node data top to bottom
            var arr = bst.SearchAndPrint().ToArray();

            var dict = new Dictionary<int, int>();
            
            int target_sum = 90;
            int prefix_sum = 0;
            var res = "";

            for (int i = 0; i < arr.Length; i++)
            {
                prefix_sum += arr[i];
                dict.Add(prefix_sum, i);

                if (prefix_sum == target_sum)
                {
                    res = res + "/" + "0," + i;
                }
                else if (dict.ContainsKey(prefix_sum-target_sum))
                {
                    res = res + "/" + (dict[prefix_sum - target_sum] + 1) + "-" + i;
                }
            }

            Console.ReadKey();
        }
    }
}
