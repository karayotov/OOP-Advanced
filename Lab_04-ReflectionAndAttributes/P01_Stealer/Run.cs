using System;

class Run
{
    static void Main()
    {
        Spy spy = new Spy();

        string result = spy.StealFieldInfo("Hacker", "username", "password"); // P01

        result = spy.AnalyzeAcessModifiers("Hacker");                         // P02

        result = spy.RevealPrivateMethods("Hacker");                          // P03

        result = spy.CollectGettersAndSetters("Hacker");                      // P04


        Console.WriteLine(result);
    }
}