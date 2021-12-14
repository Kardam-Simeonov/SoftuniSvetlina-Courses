using System.Collections.Generic;

namespace ImplementListyIterator
{
    public class ListyIterator<T>
    {
        private List<T> elements;
        private int index;
        public List<T> Elements { get { return elements; } }
        public ListyIterator(List<T> input)
        {
            elements = input;
        }


    }
}