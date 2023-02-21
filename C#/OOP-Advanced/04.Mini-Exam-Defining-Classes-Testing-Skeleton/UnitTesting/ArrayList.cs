using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting
{
    public class ArrayList
    {
        private const int Initial_Capacity = 2;
        private int[] items;
        public ArrayList()
        {
            this.items = new int[Initial_Capacity];
        }
        public int Count { get; private set; }

        public void Add(int item)
        {
            if (this.Count == this.items.Length)
            {
                int[] copy = new int[this.items.Length * 2];
                for (int i = 0; i < this.items.Length; i++)
                {
                    copy[i] = this.items[i];
                }
                this.items = copy;
            }
            this.items[this.Count] = item;
            this.Count++;
        }

        public int CountFreePositions()
        {
            int result = this.items.Length - this.Count;

            return result;

        }

        public void Cut(int countToCut)
        {
            if (countToCut > this.Count || countToCut < 0)
            {
                throw new ArgumentOutOfRangeException("Number is out of range.");
            }
            int countStayingElements = Count - countToCut;

            int[] copy = new int[countStayingElements];
            for (int i = 0; i < countStayingElements; i++)
            {
                copy[i] = this.items[countToCut + i];
            }
            this.items = copy;
            this.Count = countStayingElements;
        }
        public int Change(int element, int newElement)
        {
            int index = -1;

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i]== element)
                { 
                    index = i;
                    items[i] = newElement;
                    break; 
                }
            }
            return index;

        }

    }
}
