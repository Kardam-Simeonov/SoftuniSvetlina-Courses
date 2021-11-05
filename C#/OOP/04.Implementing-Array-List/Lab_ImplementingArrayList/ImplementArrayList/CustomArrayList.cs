using System;

namespace ImplementArrayList
{
    public class CustomArrayList
    {
        private object[] arr;

        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        private static readonly int INITIAL_CAPACITY;
        public CustomArrayList()
        {
            arr = new object[INITIAL_CAPACITY];
            count = 0;
        }

        public void Add(object item)
        {
            Insert(count, item);
        }

        public bool Contains(object item)
        {
            if (IndexOf(item) != -1)
                return true;

            return false;
        }

        public object Remove(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException("Invalid Index: " + index);
            }

            object item = arr[index];

            arr[index] = null;
            Shift(index);
            count--;

            if (count < arr.Length / 2)
            {
                Shrink();
            }

            return item;
        }

        public int Remove(object item)
        {
            int index = IndexOf(item);

            if (index == -1)
            {
                return index;
            }
            Remove(index);

            return index;
        }

        public void Insert(int index, object item)
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

        public int IndexOf(object item)
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
            arr = new object[INITIAL_CAPACITY];
            count = 0;
        }

        public void Resize()
        {
            object[] copy = new object[arr.Length * 2];
            Array.Copy(arr, copy, copy.Length);
            arr = copy;
        }

        private void Shift(int index)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i + 1];
            }

            arr[count - 1] = null;
        }

        private void Shrink()
        {
            object[] copy = new object[arr.Length / 2];
            Array.Copy(arr, copy, copy.Length);
            arr = copy;
        }

        public object this[int index]
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
    }
}