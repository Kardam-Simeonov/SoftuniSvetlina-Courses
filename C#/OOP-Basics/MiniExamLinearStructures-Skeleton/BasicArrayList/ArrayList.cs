using System;
using System.Collections.Generic;
using System.Text;

namespace BasicArrayList
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
            return items.Length - Count;
        }

        public void Cut(int count)
        {
            if (count > items.Length)
                throw new ArgumentOutOfRangeException("Number is out of range.");

            Count -= count;
            int[] trimmedArray = new int[Count];
            Array.Copy(items, Count, trimmedArray, 0, Count);
            items = trimmedArray;
        }
        public int Change(int element, int newElement)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == element)
                {
                    items[i] = newElement;
                    return i;
                }
            }
            return -1;
        }

    }
}
