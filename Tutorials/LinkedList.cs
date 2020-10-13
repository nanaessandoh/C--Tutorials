using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorials
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int _data)
        {
            data = _data;
            next = null;
        }

        public void Print ()
        {
            Console.Write($" {data} --->");
            if(next != null)
            {
                next.Print();
            }
        }

        public void AddToEnd(int data)
        {
            if(next ==null)
            {
                next = new Node(data);
            }
            else
            {
                next.AddToEnd(data);
            }
        }

        public void AddSorted(int data)
        {
            if(next == null)
            {
                next = new Node(data);
            }
            else if ( data < next.data)
            {
                var temp = new Node(data);
                temp.next = this.next;
                this.next = temp;
            }
            else
            {
                next.AddSorted(data);
            }
        }
    }

    public class MyList
    {
        public Node headNode;

        public MyList()
        {
            headNode = null;
        }

        public void AddToEnd(int data)
        {
            if( headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                headNode.AddToEnd(data);
            }
        }


        public void AddToBeginning(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else if (headNode != null)
            {
                var temp = new Node(data); ;
                temp.next = headNode;  
                headNode = temp;
            }
        }

        public void AddSorted(int data)
        {
            if(headNode == null)
            {
                headNode = new Node(data);
            }
            else if (data < headNode.data)
            {
                AddToBeginning(data);
            }
            else
            {
                headNode.AddSorted(data);
            }
        }

        public void Print()
        {
            if(headNode != null)
            {
                headNode.Print();
            }
        }
    }

    public class TestLinkedList
    {
        static void Main1(string[] args)
        {
            var myNode = new Node(2);
            myNode.next = new Node(24);
            myNode.next.next = new Node(11);
            myNode.next.next.next = new Node(15);

            myNode.AddToEnd(4);
            myNode.Print();

            Console.WriteLine();

            var list = new MyList();
            list.AddToEnd(2);
            list.AddToEnd(3);
            list.AddToEnd(4);
            list.AddToBeginning(6);
            list.AddToEnd(5);
            list.Print();

            Console.WriteLine();

            var newList = new MyList();
            newList.AddSorted(8);
            newList.AddSorted(7);
            newList.AddSorted(2);
            newList.AddSorted(9);
            newList.Print();



        }
    }

}
