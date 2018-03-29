using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Run
{
    static void Main(string[] args)
    {
        string inputLine;

        StackArray<int> stack = new StackArray<int>();

        while ((inputLine = Console.ReadLine()) != "END")
        {
            string[] data = inputLine.Split(new string[] {" ", ", "}, StringSplitOptions.RemoveEmptyEntries);

            switch (data[0])
            {
                case "Push":

                    IEnumerable<int> elements = data.Skip(1).Select(int.Parse);
                    stack.Push(elements);
                    break;

                case "Pop":

                    try
                    {
                        stack.Pop();
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    

                    break;
                default:
                    break;
            }
        }

        printStack(stack);
        printStack(stack);
    }

    private static void printStack(StackArray<int> stack)
    {
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
    }
}