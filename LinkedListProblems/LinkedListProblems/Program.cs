using System;
using System.Collections.Generic;

namespace LinkedListProblems
{
    class Progarm
    {
        static void Main(string[] args)
        {
            LinkedList linkedlist = new LinkedList();

            linkedlist.Add(56);
            linkedlist.Add(30);
            //linkedlist.Add(40);
            linkedlist.Add(70);
            linkedlist.Display();
           

            Console.WriteLine("-----------------------------");

            //linkedlist.RemoveFirstNode();
            //linkedlist.RemoveLastNode();
            //linkedlist.search(40);
            //linkedlist.InsertAtParticularPosition(2, 40);
            //Console.ReadKey();
        }


    }
}