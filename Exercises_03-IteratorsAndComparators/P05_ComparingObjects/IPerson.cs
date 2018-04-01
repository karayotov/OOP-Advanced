using System;
using System.Collections.Generic;
using System.Text;

namespace P05_ComparingObjects
{
    public interface IPerson<Person> : IComparable<Person>
    {
        string Name { get; }
        int Age { get; }
        string Town { get; }
    }
}
