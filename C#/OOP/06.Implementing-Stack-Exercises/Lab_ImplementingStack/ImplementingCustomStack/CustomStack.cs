using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementCustomStack
{
    public class CustomStack
    {
        private const int INITIAL_CAPACITY = 4;
        private int[] items;
        private int count;

        public int Count { get => this.count; }
        public CustomStack()
        {
            this.count = 0;
            this.items = new int[INITIAL_CAPACITY];
        }
       
        public void Push(int element)
        {
            if (this.items.Length == this.count)
                Resize();

            this.items[this.count] = element;
            count++;
        }

        public int Pop()
        {
            if (this.items.Length == 0)
                throw new InvalidOperationException("CustomStack is empty");

            int lastElement = this.items[count - 1];
            Array.Resize(ref this.items, this.items.Length - 1);
            count--;

            return lastElement;
        }

        public int Peek()
        {
            if (this.items.Length == 0)
                throw new InvalidOperationException("CustomStack is empty");

            return this.items[count - 1];
        }

        public void ForEach(Action<object> action)
        {
            for (int i = 0; i < count; i++)
            {
                action(this.items[i]);
            }
        }
        public void Resize()
        {
            int[] newArr = new int[this.items.Length];
            Array.Copy(this.items, newArr, newArr.Length);
            this.items = newArr;
        }
    }
}
