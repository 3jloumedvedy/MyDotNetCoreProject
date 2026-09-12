using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello from MAIN and FEATURE! Welcome!");
        GreetUser("User");
    }

    static void GreetUser(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}