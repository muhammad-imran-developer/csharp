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

        // Func<int, bool> isOdd = (int n) => n % 2 == 1;
        // var isEven = (int n) =>
        // {
        //     return n % 2 == 0;
        // };


        // Console.WriteLine(isEven(4));
        // Console.WriteLine(isOdd(3));

        List<int> ints = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<int> Odds = ints.Where((int n) => n % 2 == 1).ToList();

        foreach (var n in Odds)
        {
            Console.WriteLine(n);
        }

    }


}
