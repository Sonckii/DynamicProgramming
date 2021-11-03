using System;
using System.Collections.Generic;

namespace _02_Circular_Double_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var doublyLinkedList = new DoublyLinkedList();
            doublyLinkedList.Push("apple");
            doublyLinkedList.Push("lemon");
            doublyLinkedList.Push("banana");
            doublyLinkedList.printlist(doublyLinkedList.Head);
            
        }
    }
}
