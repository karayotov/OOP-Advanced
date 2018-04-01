using System;
using System.Collections.Generic;

namespace P05_ComparingObjects
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] inputArr = input.Split();
                string name = inputArr[0];
                int age = int.Parse(inputArr[1]);
                string town = inputArr[2];

                Person person = new Person(name, age, town);
                people.Add(person);
            }

            int personIndex = int.Parse(Console.ReadLine()) - 1;

            Person personToCompare = people[personIndex];

            int matches = 0;

            foreach (Person person in people)
            {
                if (person.CompareTo(personToCompare) == 0)
                {
                    matches++;
                }
            }

            string textToPrint;

            if (matches > 1)
            {
                textToPrint = $"{matches} {people.Count - matches} {people.Count}";
            }
            else
            {
                textToPrint = "No matches";
            }

            Console.WriteLine(textToPrint);
        }
    }
}
