using System;
using System.Collections;
using System.Collections.Generic;

namespace ImplementCircularQueue
{
    public class CircularQueue<T> : IEnumerable<T>
    {
        private T[] elements;
        private int startIndex;
        private int endIndex;

        public int Count { get; private set; }

        private const int InitialCapacity = 16;
        public CircularQueue(int capacity = InitialCapacity)
        {
            elements = new T[capacity];
        }

        public void Enqueue(T element)
        {
            if (Count >= elements.Length)
                Grow();

            elements[endIndex] = element;
            endIndex = (endIndex + 1) % elements.Length;

            Count++;
        }

        private void Grow()
        {
            T[] newElements = new T[2 * elements.Length];
            CopyAllElementsTo(newElements);

            elements = newElements;
            startIndex = 0;
            endIndex = Count;
        }

        private void CopyAllElementsTo(T[] resultArr)
        {
            int sourceIndex = startIndex;
            int destinationIndex = 0;

            for (int i = 0; i < Count; i++)
            {
                resultArr[destinationIndex] = elements[sourceIndex];
                sourceIndex = (sourceIndex + 1) % elements.Length;
                destinationIndex++;
            }
        }

        public T Dequeue()
        {
            if (Count == 0)
                throw new InvalidOperationException("The queue is empty!");

            T result = elements[startIndex];
            startIndex = (startIndex + 1) % elements.Length;
            Count--;

            return result;
        }

        public T[] ToArray()
        {
            T[] result = new T[Count];
            CopyAllElementsTo(result);
            return result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}