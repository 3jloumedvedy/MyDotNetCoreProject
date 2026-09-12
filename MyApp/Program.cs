using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello from MAIN!");
        GreetUser("User");
    }

    static void GreetUser(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}