using System;
using System.Collections.Generic;
using System.Text;

public interface IListyIteratorable<T> : IEnumerable<T>
{
    List<T> List { get; }

    int CurrentInternalIndex { get; }

    bool Move();

    bool HasNext();

    T Print();

}
