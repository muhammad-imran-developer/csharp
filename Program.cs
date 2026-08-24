using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Text;

namespace MyApp;

class Program
{

    static void Main(string[] args)
    {
        bool CanVote;

        int Age = 18;

        string Can;

        CanVote = Age >= 18 ? true : false;

        Can = CanVote ? "Yesn You Can." : "No";
        Console.WriteLine(CanVote);
        Console.WriteLine(Can);


    }



}
