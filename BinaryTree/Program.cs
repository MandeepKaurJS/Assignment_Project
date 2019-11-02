using System;

namespace BinaryTree
{
    class Program
    {
        public static int Depth(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            return 1 + Math.Max(Depth(root.left), Depth(root.right));
        }
        public static void Main(String[] args)
        {

            Node root = null;

            root = new Node(15);
            {
                root.left = new Node(10);
                {
                    root.left.left = new Node(8);
                    root.left.right = new Node(12);
                }
                root.right = new Node(20);
                {
                    root.right.left = new Node(16);
                    root.right.right = new Node(25);
                }
            }
            Console.WriteLine("The Depth of Binary Tree is:" + Depth(root));



        }
    }
 public class Node
            {
                public Node left = null, right = null;
                int value;
                public Node(int value)
                {
                    this.value = value;
                }
            }
        
        }
    







