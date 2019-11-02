using Ext.Net;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterViewTest
{
    class ReverseString
    {
        Node head;

        public class Node
        {
            public string Str;
            public Node next;

            public Node(String mystr)
            {
                Str = mystr;
                next = null;
            }
        }

        public void AddNode(Node node)
        {
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }

        // ReverseList()function to reverse the list 
        public void ReverseList()
        {
            Node previous = null, current = head, next = null;
            while (current != null)
            {
                next = current.next;
                current.next = previous;
                previous = current;
                current = next;
            }
            head = previous;
        }

        // PrintList() to print the list string
        public void PrintList()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Str + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }

}



