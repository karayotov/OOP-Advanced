using System;
using System.Collections.Generic;
using System.Text;

namespace P06_StrategyPattern
{
    public class PersonNameComparer : IPersonComparer
    {
        public int Compare(Person firstPerson, Person secondPerson)
        {
            int result = firstPerson.Name.Length.CompareTo(secondPerson.Name.Length);

            if (result == 0)
            {
                char firstPersonLetter = Char.ToLower(firstPerson.Name[0]);
                char secondPersonLetter = Char.ToLower(secondPerson.Name[0]);

                result = firstPersonLetter.CompareTo(secondPersonLetter);
            }

            return result;
        }
    }
}
