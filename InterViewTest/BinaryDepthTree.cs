using System;
using System.Collections.Generic;
using System.Text;

namespace InterViewTest
{
    class BinaryDepthTree
    {
        public static int Depth(Node1 root)
        {
            if (root == null)
            {
                return 0;
            }
            return 1 + Math.Max(Depth(root.left), Depth(root.right));
          

        public class Node1 {
            public Node1 left = null, right = null;
            int value;
            Node1(int value)
            {
                this.value = value;
            }
        }
        public static void main(String[] args)
        {
            Node root = null;

            root = new Node(15);
            root.left = new Node(10);
            root.right = new Node(20);
            root.left.left = new Node(8);
            root.left.right = new Node(12);
            root.right.left = new Node(16);
            root.right.right = new Node(25);
        }
    }
}

        
    

