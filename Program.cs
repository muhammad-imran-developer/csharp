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
        // try
        // {
        //     int a = 10;
        //     int b = 0;

        //     int result = a / b;
        // }

        // catch (Exception ex)
        // {
        //     Console.WriteLine(ex.Message);
        // }


        // static void SetHealth(int health)
        // {
        //     if (health < 0)
        //     {
        //         throw new Exception("Health cannot be negative.");
        //     }
        //     else
        //     {
        //         Console.WriteLine($"Health: {health}");
        //     }


        // }

        // try
        // {
        //     SetHealth(110);
        // }
        // catch (Exception ex)
        // {
        //     Console.WriteLine(ex.Message);
        // }


        static void CheckAge(int Age)
        {
            if (Age < 0)
            {
                throw new Exception("Age cannot be negative.");
            }
            else
            {
                Console.WriteLine($"AGE: {Age}");
            }


        }
        try
        {
            CheckAge(2);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }


}
