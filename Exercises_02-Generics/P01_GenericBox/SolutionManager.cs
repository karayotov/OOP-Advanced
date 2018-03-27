using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class SolutionManager
{
    internal static void CustomListIterator()
    {
        List<int> list = new List<int>();
        CustomList<int> customList = new CustomList<int>();

        for (int i = 0; i < 5; i++)
        {
            list.Add(i);
            customList.Add(i);
        }

        GenericCustomList();
    }

    internal static void GenericCustomList()
    {
        string input;

        CustomList<string> list = new CustomList<string>();

        while ((input = Console.ReadLine()) != "END")
        {
            string[] commandArgs = input.Split();
            string command = commandArgs[0];

            switch (command)
            {
                case "Add":
                    list.Add(commandArgs[1]);
                    break;
                case "Remove":
                    int index = int.Parse(commandArgs[1]);
                    list.Remove(index);
                    break;
                case "Contains":
                    bool result = list.Contains(commandArgs[1]);
                    Console.WriteLine(result);
                    break;
                case "Swap":
                    int firstIndex = int.Parse(commandArgs[1]);
                    int secondIndex = int.Parse(commandArgs[2]);
                    list.Swap(firstIndex, secondIndex);
                    break;
                case "Greater":
                    int count = list.CountGreaterThan(commandArgs[1]);
                    Console.WriteLine(count);
                    break;
                case "Min":
                    string minElement = list.Min();
                    Console.WriteLine(minElement);
                    break;
                case "Max":
                    string maxElement = list.Max();
                    Console.WriteLine(maxElement);
                    break;
                case "Print":
                    //for (int i = 0; i < list.Count; i++)
                    //{
                    //    Console.WriteLine(list[i]);
                    //}
                    foreach (var el in list)
                    {
                        Console.WriteLine(el);
                    }
                    break;
                case "Sort":
                    list.Sort();
                    break;
                default:
                    break;
            }
        }
    }

    internal static void GenericCountMethodDoubles()
    {
        int readLineCounter = int.Parse(Console.ReadLine());
        List<Box<double>> boxes = new List<Box<double>>();

        for (int i = 0; i < readLineCounter; i++)
        {
            double num = double.Parse(Console.ReadLine());

            boxes.Add(new Box<double>(num));
        }

        Box<double> comparison = new Box<double>(double.Parse(Console.ReadLine()));
        Console.WriteLine(CountGreaterThanComparisonValue(boxes, comparison));
    }

    internal static void GenericCountMethodStrings()
    {
        int readLineCounter = int.Parse(Console.ReadLine());
        List<Box<string>> boxes = new List<Box<string>>();

        for (int i = 0; i < readLineCounter; i++)
        {
            string text = Console.ReadLine();

            boxes.Add(new Box<string>(text));
        }

        Box<string> comparison = new Box<string>(Console.ReadLine());
        Console.WriteLine(CountGreaterThanComparisonValue(boxes, comparison));

    }

    private static int CountGreaterThanComparisonValue<T>(IEnumerable<T> collection, T comparisonValue)
        where T : IComparable<T>
    {
        int count = 0;

        foreach (T item in collection)
        {
            if (item.CompareTo(comparisonValue) > 0)
            {
                count++;
            }
        }

        return count;
    }

    internal static void GenericSwapMethodString()
    {
        int readLineCounter = int.Parse(Console.ReadLine());
        List<Box<string>> boxes = new List<Box<string>>();

        for (int i = 0; i < readLineCounter; i++)
        {
            Box<string> box = new Box<string>(Console.ReadLine());
            boxes.Add(box);
        }

        int[] swapIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Swap(boxes, swapIndexes[0], swapIndexes[1]);
        boxes.ForEach(box => Console.WriteLine(box));
    }

    internal static void GenericSwapMethodInteger()
    {
        int numberOfIntegers = int.Parse(Console.ReadLine());
        List<Box<int>> listOfBoxes = new List<Box<int>>();

        while (numberOfIntegers > 0)
        {
            int value = int.Parse(Console.ReadLine());
            listOfBoxes.Add(new Box<int>(value));

            numberOfIntegers--;
        }

        int[] swapIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Swap(listOfBoxes, swapIndexes[0], swapIndexes[1]);
        listOfBoxes.ForEach(box => Console.WriteLine(box));

    }

    private static void Swap<T>(IList<T> collection, int indexToSwap, int swapWithIndex)
    {
        T temp = collection[indexToSwap];
        collection[indexToSwap] = collection[swapWithIndex];
        collection[swapWithIndex] = temp;
    }

    internal static void GenericBoxOfInteger()
    {
        int numberOfIntegers = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfIntegers; i++)
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(new Box<int>(num));
        }
    }

    internal static void GenericBoxOfStrings()
    {
        int numberOfIntegers = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfIntegers; i++)
        {
            Box<string> box = new Box<string>(Console.ReadLine());

            Console.WriteLine(box);
        }
    }

    internal static void GenericBox()
    {
        Box<int> intBox = new Box<int>();
        intBox.Value = 123123;
        Console.WriteLine(intBox);

        Box<string> textBox = new Box<string>();
        textBox.Value = "life in a box";
        Console.WriteLine(textBox);
    }
}