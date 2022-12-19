using System;
using System.Collections;
using System.Collections.Generic;

namespace ImplementArrayList
{
    public class CustomArrayList<T> : IEnumerable<T>
    {
        private T[] arr;

        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        private static readonly int INITIAL_CAPACITY = 4;
        public CustomArrayList()
        {
            arr = new T[INITIAL_CAPACITY];
            count = 0;
        }

        public void Add(T item)
        {
            Insert(count, item);
        }

        public bool Contains(T item)
        {
            if (IndexOf(item) != -1)
                return true;

            return false;
        }

        public T Remove(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException("Invalid Index: " + index);
            }

            T item = arr[index];

            arr[index] = default(T);
            Shift(index);
            count--;

            if (count < arr.Length / 2)
            {
                Shrink();
            }

            return item;
        }

        public int Remove(T item)
        {
            int index = IndexOf(item);

            if (index == -1)
            {
                return index;
            }
            Remove(index);

            return index;
        }

        public void Insert(int index, T item)
        {
            if (count == arr.Length)
                Resize();

            for (int i = arr.Length; i > index; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[index] = item;
            count++;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(item))
                    return i;
            }

            return -1;
        }

        public void Clear()
        {
            arr = new T[INITIAL_CAPACITY];
            count = 0;
        }

        public void Resize()
        {
            T[] copy = new T[arr.Length * 2];
            Array.Copy(arr, copy, copy.Length);
            arr = copy;
        }

        private void Shift(int index)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i + 1];
            }

            arr[count - 1] = default(T);
        }

        private void Shrink()
        {
            T[] copy = new T[arr.Length / 2];
            Array.Copy(arr, copy, copy.Length);
            arr = copy;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new ArgumentOutOfRangeException("Invalid Index: " + index);
                }
                return arr[index];
            }
            set
            {
                if (index < 0 || index >= Count)
                {
                    throw new ArgumentOutOfRangeException("Invalid Index: " + index);
                }
                arr[index] = value;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.arr.Length; i++)
            {
                yield return this.arr[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}