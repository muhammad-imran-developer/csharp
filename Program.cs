using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Text;

namespace MyApp;

class Program
{

    static void Main(string[] args)
    {
        Person person = new();

        person.Name = "Muhammad Imran";
        person.Age = 19;

        Console.WriteLine(person.Name);
        Console.WriteLine(person.Age);



    }


    class Person
    {
        public string? Name;
        public int Age;
    }

}
