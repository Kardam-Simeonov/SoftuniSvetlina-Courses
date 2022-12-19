using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Programer_s_Distillery
{
    internal class Batch<T> : IEnumerable<T>
    {
        private T[] arr;
        private int lastIndex;

        public int LastIndex
        {
            get { return lastIndex; }
        }

        public Batch()
        {
            arr = new T[4];
            lastIndex = 0;
        }

        public void Add(T item)
        {
            arr[lastIndex] = item;
            lastIndex++;
        }

        public void Remove(T item)
        {
            int index = IndexOf(item);

            T[] temp = new T[4];

            int tempCounter = 0;

            for (int i = 0; i < 4; i++)
            {
                if (i != index)
                {
                    temp[tempCounter] = arr[i];
                    tempCounter++;
                }
            }

            arr = temp;
            lastIndex--;
        }

        public int UniqueItems()
        {
            return arr.Distinct().ToArray().Count(); 
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

        public T this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }
    
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                yield return arr[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}