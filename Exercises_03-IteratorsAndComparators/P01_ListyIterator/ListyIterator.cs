using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ListyIterator<T> : IListyIteratorable<T>
{
    public ListyIterator()
    {
        this.List = new List<T>();
        this.CurrentInternalIndex = DEFAULT_VALUE;
    }

    public ListyIterator(IEnumerable<T> elements) : base()
    {
        this.List = new List<T>(elements);
    }

    private const int DEFAULT_VALUE = 0;

    public int CurrentInternalIndex { get; set; }

    public List<T> List { get; }

    
    public bool HasNext() => this.CurrentInternalIndex != this.List.Count - 1;

    public bool Move()
    {
        if (HasNext())
        {
            this.CurrentInternalIndex++;

            return true;
        }

        return false;
    }

    public T Print()
    {

        if (this.List.Count == 0)
        {
            throw new ArgumentException("Invalid Operation!");
        }

        return this.List[this.CurrentInternalIndex];
    }

    public string PrintAll()
    {
        StringBuilder stringBuilder = new StringBuilder();

        foreach (T item in this.List)
        {
            stringBuilder.Append($"{item} ");
        }

        return stringBuilder.ToString().Trim();
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.List.Count; i++)
        {
            yield return this.List[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}