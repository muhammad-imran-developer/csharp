using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MyApp;

class Program
{

    static void Main(string[] args)
    {
        Person person = new("TIKTOK");




        Console.WriteLine(person.Name);
    }


}
