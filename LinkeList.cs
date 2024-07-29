using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    internal class LinkedList
    {
        public Node First {  get; set; }

        public void InsertFirst(int data)
        {
            //Create the Node
            Node newNode = new Node();
            //Put the data in the node
            newNode.Data = data;
            //put the old node in next
            newNode.Next = First;
            //Make the head the new node
            First = newNode;

        } // Most of the time deleting the old head is illogical. You just assign a new head.

        public Node DeleteFirst()
        {
            //Assign the tempereary variable
            Node temp = First;
            //Assign the new head
            First = First.Next;
            return temp;
        }
        public void DisplayList()
        {
            Console.WriteLine("Iterating thru list.");
            Node current = First;
            while (current != null)
            {
                current.DisplayNode();
                current = current.Next;
            }
        }
        public void InsertLast(int data)
        {
            Node current = First;
            while(current.Next != null)
            {
                current = current.Next;
            }
            Node newNode = new Node();
            newNode.Data = data;
            current.Next = newNode;
        }
    }
}
