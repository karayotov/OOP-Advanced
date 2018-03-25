using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Box<T> : IComparable<Box<T>>
    where T : IComparable
{
    public Box()
    {
        this.Value = default(T);
    }

    public Box(T element)
    {
        this.Value = element;
    }

    public T Value { get; set; }

    public override string ToString()
    {
        return $"{this.Value.GetType().FullName}: {this.Value}";
    }

    public int CompareTo(Box<T> other)
    {
        return this.Value.CompareTo(other.Value);
    }
}
//Create a generic class Box that can be initialized with any type and store the value.