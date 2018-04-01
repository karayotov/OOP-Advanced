﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P06_StrategyPattern
{
    public class Person : IPerson<Person>
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; }

        public int Age { get; }

        public int CompareTo(Person other)
        {
            int result = this.Name.CompareTo(other.Name);

            if (result == 0)
            {
                result = this.Age.CompareTo(other.Age);
            }

            return result;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
    }
}
