using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} Values Are Inserted", node.data);
        }
        public void AddFirst(int data)
        {
            Node node = new Node(data);
            node.next = this.head;
            this.head = node;
            Console.WriteLine("{0} inserted into linked list ", node.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Liked List Is Empty");
            }
            Console.WriteLine("Linked list IS :");
            while (temp != null)
            {
                Console.WriteLine(temp.data + "");
                temp = temp.next;
            }
        }

            public void InReverse(int data)
            {
                Node node = new Node(data);
                if (head == null)
                {
                    head = node;
                }
                else
                {
                    Node temp = head;
                    node.next = temp;
                    head = node;
                }
                Console.WriteLine($"{node.data} ");
            }
        public void Append(int data)
        {
            Node node = new Node(data);
            if (head != null)
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                Console.WriteLine($"{node.data} is added after the {temp.data}");
            }
            else { head = node; }
        }
    }