using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkListDemo
{
    //Likedlist is Linar data structure
    //It consists of groups of nodes in a sequence
    //one is data part and address part
    //data part= each node of a linkedlist can store a data
    //address=it ll store the address for other node
    internal class linkedList
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                this.head = node;
            }
            else
            {
               Node temp= head;
                while(temp.next != null)
                {
                    temp= temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine(data);

        }
    }
}
