using System.Collections;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public SortedSet<Book> Books { get; set; }
        public Library(params Book[] books)
        {
            this.Books = new SortedSet<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            /*
            for (int i = 0; i < this.Books.Count; i++)
            {
                yield return this.Books[i];
            }
            */
            return Books.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}