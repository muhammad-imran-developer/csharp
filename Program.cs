using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Text;

namespace MyApp;

class Program
{

    static void Main(string[] args)
    {

        int sum = Sum(5, 6, 4, 5, 3);
        Console.WriteLine(sum);

    }

    static int Sum(params int[] numbers)
    {
        int total = 0;
        foreach (var num in numbers)
        {
            total += num;
        }

        return total;

    }




}
