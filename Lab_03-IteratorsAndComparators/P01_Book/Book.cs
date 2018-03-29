using System;
using System.Collections.Generic;


public class Book : IComparable<Book>
{
    public Book(string title, int year, params string[] authors)
    {
        this.Title = title;
        this.Year = year;
        this.Authors = authors;
    }

    public string Title { get; }

    public int Year { get; }

    public IReadOnlyList<string> Authors { get; }

    public int CompareTo(Book other)
    {
        int comparator = this.Year.CompareTo(other.Year);

        if (comparator == 0)
        {
            return this.Title.CompareTo(other.Title);
        }

        return comparator;
    }

    public override string ToString()
    {
        return $"{this.Title} - {this.Year}";
    }
}