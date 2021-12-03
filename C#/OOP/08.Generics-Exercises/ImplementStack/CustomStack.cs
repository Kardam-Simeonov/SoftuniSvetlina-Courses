using System;

namespace ImplementCustomStack
{
    public class CustomStack<T>
    {
        private const int INITIAL_CAPACITY = 4;
        private T[] items;
        private int count;

        public int Count { get => this.count; }
        public CustomStack()
        {
            this.count = 0;
            this.items = new T[INITIAL_CAPACITY];
        }

        public void Push(T element)
        {
            if (this.items.Length == this.count)
                Resize();

            this.items[this.count] = element;
            count++;
        }

        public T Pop()
        {
            if (this.items.Length == 0)
                throw new InvalidOperationException("CustomStack is empty");

            T lastElement = this.items[count - 1];
            Array.Resize(ref this.items, this.items.Length - 1);
            count--;

            return lastElement;
        }

        public T Peek()
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
            T[] newArr = new T[this.items.Length];
            Array.Copy(this.items, newArr, newArr.Length);
            this.items = newArr;
        }
    }
}