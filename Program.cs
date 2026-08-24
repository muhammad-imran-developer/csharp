using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Text;

namespace MyApp;

class Program
{

    static void Main(string[] args)
    {
        int num = 12;

        ref int numref = ref num;

        Console.WriteLine(num);

        numref = 20;
        Console.WriteLine(numref);

        Console.WriteLine('Hello world');


    }


}
