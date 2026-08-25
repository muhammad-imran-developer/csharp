using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Text;

namespace MyApp;

class Program
{

    static void Main(string[] args)
    {
        Person person = new()
        {
            Name = "MUHAMMAD IMRAN",
            Age = 19,
        };

        Console.WriteLine(person.Name);
        Console.WriteLine(person.Age);

        person.Sing();



    }




}
