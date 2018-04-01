using System;
using System.Collections.Generic;
using System.Text;

namespace P06_StrategyPattern
{
    public interface IPerson<Person> : IComparable<Person>
    {
        string Name { get; }

        int Age { get; }
    }
}
