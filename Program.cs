using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MyApp;

// Generics/Templated Classes and Methods
class Program
{
    static void Main(string[] args)
    {

        // Templated Method
        T DoubleIt<T>(T number) where T : INumber<T>
        {
            return (dynamic)number * 2;
        }

        var twice = DoubleIt(12); // yaha per jo value dein gay T os value ki data type mein convert ho jay ga ya 12 diya h to ab her T ki jaga int likha jay ga
        Console.WriteLine(twice);

    }

    // Templated Classes

    class Vector<T, T2> //int
    {
        T data; // int data
    }

    Vector<int, float> vector = new(); // it replace T with int and T2 with float
    Vector<double, string> vector2 = new(); // it rplace T with double and T2 with string

}
