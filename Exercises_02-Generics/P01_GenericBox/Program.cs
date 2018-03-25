using System;

public class Program
{
    static void Main(string[] args)
    {
        Box<int> intBox = new Box<int>();

        Box<string> stringBox = new Box<string>();

        intBox.Add(123123);
        stringBox.Add("life in a box");



        Console.WriteLine();
    }
}