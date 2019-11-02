using System;

namespace InterViewTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The height of the binary tree is " + Depth(root));
            //Reverse Linked List
            Console.WriteLine("I am Linked List Which will Reverse a String.");
            ReverseString list = new ReverseString();
            list.AddNode(new ReverseString.Node("I"));
            list.AddNode(new ReverseString.Node("Am"));
            list.AddNode(new ReverseString.Node("Linked"));
            list.AddNode(new ReverseString.Node("List"));
            list.AddNode(new ReverseString.Node("!."));

            // List before reversal 
            Console.WriteLine("Given linked list:");
            list.PrintList();

            // Reverse the list 
            list.ReverseList();

            // List after reversal 
            Console.WriteLine("Reversed linked list:");
            list.PrintList();
            Console.WriteLine("I am Binary Search.");
            int[] a = new int[100];
            Console.WriteLine("Number of elements in the array ?");
            string s = Console.ReadLine();
            int x = Int32.Parse(s);
            Console.WriteLine(" Enter array elements ");
            for (int i = 0; i < x; i++)
            {
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
                
            }

            Console.WriteLine("Enter Search element");
            string s3 = Console.ReadLine();
            int search = Int32.Parse(s3);
            int low = 0;
            int high = x - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (search < a[mid])
                    high = mid - 1;
                else if (search > a[mid])
                    low = mid + 1;
                else if (search == a[mid])
                {
                    Console.WriteLine("Search successful");
                    Console.WriteLine("Element {0} found at location {1}\n", search, mid + 1);
                    return;
                }
            }
            Console.WriteLine("Search unsuccessful");
            
        }

    }
}

