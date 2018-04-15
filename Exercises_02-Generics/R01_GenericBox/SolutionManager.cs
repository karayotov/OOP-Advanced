using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class SolutionManager
{
    public static void GenericBoxOfString()
    {
        List<Box<string>> collection = new List<Box<string>>();

        int lineCounter = int.Parse(Console.ReadLine());

        string inputLine;
        Box<string> stringBox;

        for (int i = 0; i < lineCounter; i++)
        {
            inputLine = Console.ReadLine();

            stringBox = new Box<string>(inputLine);

            collection.Add(stringBox);
        }

        foreach (var item in collection)
        {
            Console.WriteLine(item.ToString());
        }
    }

    public static void GenericBoxOfInt()
    {
        List<Box<int>> collection = new List<Box<int>>();

        int lineCounter = int.Parse(Console.ReadLine());

        int inputLine;
        Box<int> intBox;

        for (int i = 0; i < lineCounter; i++)
        {
            inputLine = int.Parse(Console.ReadLine());

            intBox = new Box<int>(inputLine);

            collection.Add(intBox);
        }

        foreach (var item in collection)
        {
            Console.WriteLine(item.ToString());
        }
    }

    private static void Swap<T>(IList<T> collection, int indexToSwap, int swapWithIndex)
    {



        T temporary = collection[indexToSwap];
        collection[indexToSwap] = collection[swapWithIndex];
        collection[swapWithIndex] = temporary;
    }
}