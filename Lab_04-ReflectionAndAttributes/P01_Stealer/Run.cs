using System;

class Run
{
    static void Main()
    {
        Spy spy = new Spy();

        string result = spy.StealFieldInfo("Hacker", "username", "password"); // P01

        result = spy.AnalyzeAcessModifiers("Hacker");                         // P02

        Console.WriteLine(result);
    }
}