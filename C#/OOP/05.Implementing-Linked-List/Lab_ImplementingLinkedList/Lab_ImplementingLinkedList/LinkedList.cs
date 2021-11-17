using System;

namespace ImplementLinkedList
{
    public class LinkedList
    {
        private class Node
        {
            private Node next;
            private object element;

            public object Element
            {
                get { return element; }
                set { element = value; }
            }


            public Node Next
            {
                get { return next; }
                set { next = value; }
            }

            public Node(object element, Node prevNode)
            {
                Element = element;
                prevNode.Next = this;
            }

            public Node(object element)
            {
                Element = element;
                next = null;
            }
        }

        private Node head;
        private Node tail;
        private int count;
        public LinkedList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }
        public int Count
        {
            get { return count; }
            private set { count = value; }
        }

        public void Add(object item)
        {
            if (head == null)
            {
                head = new Node(item);
                tail = head;
            }
            else
            {
                Node newNode = new Node(item, tail);
                tail = newNode;
            }
            Count++;
        }
        public int Remove(object item)
        {
            Node current = head;
            Node previous = null;
            while (current != null)
            {
                if (current.Element.Equals(item))
                {
                    if (previous == null)
                    {
                        head = current.Next;
                    }
                    else
                    {
                        previous.Next = current.Next;
                    }
                    count--;
                    return IndexOf(current);
                }
                previous = current;
                current = current.Next;
            }

            return -1;
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException();
          
            Node current = head;
            Node previous = null;
            int i = 0;
            while (i < index)
            {
                previous = current;
                current = current.Next;
                i++;
            }
            Count--;

            if (count == 0) 
            {
                head = null;
                tail = null;
            }
            else if (previous == null) 
            {
                head = current.Next;  
            }
            else
            {
                previous.Next = current.Next; //the previous element points to the after element
            }
        }
        public int IndexOf(object item)
        {
            int i = 0;
            Node current = head;
            while (i < Count)
            {
                if (current.Equals(item))
                    return i;

                current = current.Next;
                i++;
            }
            return -1;
        }
        /*/
        public bool Contains(object item)
        {

        }
        public object this[int index]
        {

        }
        /*/
        
    }
}