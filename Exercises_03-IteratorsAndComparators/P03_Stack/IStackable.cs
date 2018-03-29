using System;
using System.Collections.Generic;
using System.Text;

public interface IStackable<T> : IEnumerable<T>
{
    T[] StackList { get; }

    int Length { get; }

    void Push(IEnumerable<T> item);

    T Pop();
}