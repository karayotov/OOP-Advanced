using System;
using System.Collections.Generic;
using System.Text;

namespace P06_StrategyPattern
{
    public class PersonAgeComparer : IPersonComparer
    {
        public int Compare(Person firstPerson, Person secondPerson)
        {
            int result = firstPerson.Age.CompareTo(secondPerson.Age);

            return result;
        }
    }
}
