using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Box<T> : IComparable<Box<T>> 
    where T : IComparable
{


    public Box()
    {
        this.Value = default(T);
    }
    public Box(T item) : this()
    {
        this.Value = item;
    }

    public T Value { get; set; }

    public int CompareTo(Box<T> other)
    {
        return this.Value.CompareTo(other);
    }

    public override string ToString()
    {
        return $"{this.Value.GetType().FullName}: {this.Value}";
    }
}