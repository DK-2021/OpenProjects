using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects
{
    public class MyLinkedList
    {
        public Node headNode;
        public MyLinkedList()
        {
            headNode = null;
        }
        public void Print()
        {
            headNode.Print();
        }
        public void AddToEnd(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                headNode.AddToEnd(data);
            }
        }
        public void AddToStart(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = headNode;
                headNode = temp;
            }
        }
        public void SearchList(int data)
        {
            if (headNode != null && headNode.data == data)
            {
                Console.WriteLine("{0}, exists in the list", data);
            }
            else if (headNode != null && headNode.data != data)
            {
                headNode.SearchList(data);
            }
            else if (headNode == null)
            {
                Console.WriteLine("{0}, does not exist in the list", data);
            }
        }
    }
    public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            next = null;
        }
        public void AddToEnd(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else
            {
                next.AddToEnd(data);
            }
        }
        public void Print()
        {
            Console.Write("|" + data + "|>");
            if (next != null)
            {
                next.Print();
            }
        }
        public void SearchList(int data)
        {
            if (next != null && next.data == data)
            {
                Console.WriteLine("{0}, exists in the list", data);
            }
            else if (next != null && next.data != data)
            {
                next.SearchList(data);
            }
            else
            {
                Console.WriteLine("{0}, does not exist in the list", data);
            }
        }
    }
}
