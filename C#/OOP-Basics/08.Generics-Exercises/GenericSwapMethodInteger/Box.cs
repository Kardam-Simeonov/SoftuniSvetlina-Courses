using System.Collections.Generic;

namespace GenericSwapMethodInteger
{
    public class Box<T>
    {
        private List<T> myElements;
        public int Count { get => myElements.Count; }
        public Box()
        {
            myElements = new List<T>();
        }

        public void Add(T element)
        {
            myElements.Add(element);
        }

        public T Remove()
        {
            T element = myElements[Count - 1];
            myElements.RemoveAt(Count - 1);

            return element;
        }

        public T this[int index] { get => myElements[index]; set => myElements[index] = value;}
    }
}