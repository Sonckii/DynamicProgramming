using System;

namespace _02_Circular_Double_List
{
    public class DoublyLinkedList
    {
        public Node Head;

        public void Push(string data)
        {
            var newNode = new Node(data);

            newNode.Next = Head;
            newNode.Prev = null;

            if (Head != null)
            {
                Head.Prev = newNode;
            }

            Head = newNode;
        }

        public void InsertAfter(Node prev_Node, string new_data)
        {

            /*1. check if the given prev_node is NULL */
            if (prev_Node == null)
            {
                Console.WriteLine("The given previous node cannot be NULL ");
                return;
            }

            /* 2. allocate node
            * 3. put in the data */
            Node new_node = new Node(new_data);

            /* 4. Make next of new node as next of prev_node */
            new_node.Next = prev_Node.Next;

            /* 5. Make the next of prev_node as new_node */
            prev_Node.Next = new_node;

            /* 6. Make prev_node as previous of new_node */
            new_node.Next = prev_Node;

            /* 7. Change previous of new_node's next node */
            if (new_node.Next != null)
                new_node.Next.Prev = new_node;
        }

        void append(string new_data)
        {
            /* 1. allocate node
            * 2. put in the data */
            Node new_node = new Node(new_data);

            Node last = Head; /* used in step 5*/

            /* 3. This new node is going
                to be the last node, so
            * make next of it as NULL*/
            new_node.Next = null;

            /* 4. If the Linked List is empty,
            then make the new * node as head */
            if (Head == null)
            {
                new_node.Prev = null;
                Head = new_node;
                return;
            }

            /* 5. Else traverse till the last node */
            while (last.Next != null)
                last = last.Next;

            /* 6. Change the next of last node */
            last.Next = new_node;

            /* 7. Make last node as previous of new node */
            new_node.Next = last;
        }

        public void printlist(Node node)
        {
            Node last = null;
            Console.WriteLine("Traversal in forward Direction");
            while (node != null)
            {
                Console.Write(node.Data + " ");
                last = node;
                node = node.Next;
            }
            Console.WriteLine();
            Console.WriteLine("Traversal in reverse direction");
            while (last != null)
            {
                Console.Write(last.Data + " ");
                last = last.Prev;
            }
        }
    }

    public class Node
    {
        public string Data;
        public Node Prev;
        public Node Next;

        public Node(string data)
        {
            Data = data;
        }
    }

}