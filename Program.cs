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
        Doctor doctor = new();

        doctor.Talk();
    }


}
