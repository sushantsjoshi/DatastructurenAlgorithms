using System;

namespace ConsoleApp2.Data
{
    public class BTreePrroblems
    {
        public Node LCANode(Node root, int a, int b)
        {
            if (root == null) return null;
            if (root.Data == a || root.Data == b) return root;

            var left = LCANode(root.Left, a, b);
            var right = LCANode(root.Right, a, b);

            return left != null && right != null ? root : left != null ? left : right;

        }

        public void Postorder(Node root)
        {
            if (root != null)
            {
                if (root.Left != null)
                    Postorder(root.Left);

                if (root.Right != null)
                    Postorder(root.Right);

                Console.Write($"{root.Data} ");
            }
        }

        public void Preorder(Node root)
        {
            if (root != null)
            {
                Console.Write($"{root.Data} ");

                if (root.Left != null)
                    Preorder(root.Left);

                if (root.Right != null)
                    Preorder(root.Right);
            }
        }

        public void Inorder(Node root)
        {
            if (root != null)
            {
                if (root.Left != null)
                    Inorder(root.Left);
                Console.Write($"{root.Data} ");
                if (root.Right != null)
                    Inorder(root.Right);
            }
        }
    }

    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }
}
