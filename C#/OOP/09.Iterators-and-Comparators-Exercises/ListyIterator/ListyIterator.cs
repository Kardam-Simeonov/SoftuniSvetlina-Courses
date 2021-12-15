using System;
using System.Collections;
using System.Collections.Generic;

namespace ImplementListyIterator
{
    public class ListyIterator<T1> : IEnumerable<T1>
    {
        private int internalIndex = 0;
        public List<T1> Items { get; set; }
        public ListyIterator(List<T1> items)
        {
            this.Items = items; 
        }
        public bool Move()
        {
            if (!HasNext())
                return false;

            internalIndex++;
            return true;
        }
        public bool HasNext()
        {
            return internalIndex + 1 < Items.Count;
        }

        public void Print()
        {
            Console.WriteLine(Items[internalIndex]);
        }

        public void PrintAll()
        {
            foreach (var item in Items)
                Console.Write($"{item} ");

            Console.WriteLine();
        }
        public IEnumerator<T1> GetEnumerator()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                yield return Items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}