using System;
using System.Text;


public class ConsoleWriter : IWriter
{
    private StringBuilder sb;

    public ConsoleWriter()
    {
        sb = new StringBuilder();
    }

    public void AppendLine(string line)
    {
        sb.AppendLine(line);
    }

    public void WriteLineAll()
    {
        Console.WriteLine(sb.ToString().Trim());
    }
}