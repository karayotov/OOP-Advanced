using System;
using System.Collections.Generic;
using System.Text;

public class BookComparator : IComparer<Book> // 👀
{
    public int Compare(Book x, Book y)
    {
        int comparer = x.Title.CompareTo(y.Title);

        if (comparer == 0)
        {
            return y.Year.CompareTo(x.Year);
        }

        return comparer;
    }
}