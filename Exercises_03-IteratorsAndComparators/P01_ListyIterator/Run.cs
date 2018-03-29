using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Run
{
    static void Main(string[] args)
    {
        List<string> input = Console.ReadLine().Split().Skip(1).ToList();

        ListyIterator<string> collectiion = new ListyIterator<string>(input);



        StringBuilder stringBuilder = new StringBuilder();


        string command;


        try
        {
            while ((command = Console.ReadLine()) != "END")
            {
                switch (command)
                {
                    case "Move":

                        Console.WriteLine(collectiion.Move().ToString());
                        break;

                    case "Print":

                        Console.WriteLine(collectiion.Print().ToString()); ;
                        break;

                    case "HasNext":

                        Console.WriteLine(collectiion.HasNext().ToString());
                        break;

                    case "PrintAll":

                        Console.WriteLine(collectiion.PrintAll());
                        break;

                    default:
                        break;
                }
            }
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}