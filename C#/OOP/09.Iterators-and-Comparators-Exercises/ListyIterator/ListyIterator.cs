using System.Collections.Generic;

namespace ImplementListyIterator
{
    public class ListyIterator<T1>
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
            return internalIndex < Items.Count;
        }

        public void Print()
        {
            System.Console.WriteLine(Items[internalIndex]);
        }
    }
}