using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Text;

namespace MyApp;

class Program
{

    static void Main(string[] args)
    {

        int sum = Sum(5, 6, 4);
        Console.WriteLine(sum);

    }

    static int Sum(int n1, int n2)
    {

        return n1 + n2;

    }

    static int Sum(int n1, int n2, int n3)
    {
        return n1 + n2 + n3;

    }



}
