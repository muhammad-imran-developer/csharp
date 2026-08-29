using System;

class Person
{
    public static void Desktop(string msg)
    {
        Console.WriteLine($"This is Desktop. {msg}");
    }

    public static void Laptop(string msg)
    {
        Console.WriteLine($"This is Laptop. {msg}");
    }

    public static void Mobile(string msg)
    {
        Console.WriteLine($"This is Mobile. {msg}");
    }

    public delegate void Alert(string msg);
}