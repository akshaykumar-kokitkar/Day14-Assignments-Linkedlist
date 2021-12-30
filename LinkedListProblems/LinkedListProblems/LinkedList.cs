using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProblems
{

    public class LinkedList
    {
        internal Node head;
        internal Node tail;
        internal void Add(int data)
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
            Console.WriteLine("{0} inserted into linked", node.data);
            
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        internal Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }
            if (position == 1)
            {
                Node newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        var node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                
                if (position != 1)
                    Console.WriteLine("Position out of range");
                else
                    Console.WriteLine("Inserted value is :{0} {1} ", head.data, head.next.data);
            }
            
            return head;
        }
        internal Node RemoveFirstNode()
        {
            //[56 -> 30 -> 40]
            //[ 30 -> 40]

            if (this.head == null)
            {
                return null;
            }
            //Node temp = this.head;
            //this.head = this.head.next;
            this.head = this.head.next;
            Console.WriteLine("updated linked list : {0} {1}", this.head.data , head.next.data);
            return this.head;
        }


        internal Node RemoveLastNode()
        {
            //[56 -> 30 -> 77 -> 40]
            //[56 -> 30 -> 77]
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return null;
            }

            Node current = head;
            while (current.next.next != null)
            {
                current = current.next;
            }
            current.next = null;
            Console.WriteLine("updated linked list : {0} {1}", this.head.data, head.next.data);
            return head;
        }
        public bool search(int value)
        {
            int index = 0;
            Node temp = head;
            while (temp != null)
            {
                if (temp.data.Equals(value))
                {
                    Console.WriteLine(value + " is found at index = " + index);
                    return true;
                }
                temp = temp.next;
                index++;
            }
            return false;
        }

    }
}