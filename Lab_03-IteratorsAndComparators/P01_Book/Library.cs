using System.Collections;
using System.Collections.Generic;
public class Library : IEnumerable<Book>
{
    private List<Book> books;

    public Library(params Book[] books)
    {
        this.books = new List<Book>(books);
        this.books.Sort(new BookComparator());
    }

    public IEnumerator<Book> GetEnumerator()
    {
        for (int i = 0; i < books.Count; i++)
        {
            yield return books[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    private class LibraryIterator : IEnumerator<Book>
    {

        public LibraryIterator(IEnumerable<Book> books)
        {
            this.Reset();
            this.books = new List<Book>(books);
        }

        private readonly List<Book> books;

        private int currentIndex;

        public Book Current => this.books[this.currentIndex];

        object IEnumerator.Current => this.Current;

        public void Dispose() { }

        public bool MoveNext() => ++this.currentIndex < this.books.Count;

        public void Reset() => this.currentIndex = -1;
    }
}
