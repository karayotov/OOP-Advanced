using System;

public class Program
{
    static void Main(string[] args)
    {
        var scale = new Scale<string>("select", "enter");

        Console.WriteLine(scale.GetHeavier());
    }
}