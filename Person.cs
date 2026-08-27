

using System;
using System.ComponentModel;
using System.Security.Cryptography;

class Person
{
    public string Name = "TEST";
    public static int Age = 18;

    public static void Talk()
    {
        Console.WriteLine(Age);
        Console.WriteLine("PERSON IS TALKIN.");
    }
}


class Doctor : Person
{

}

class Patient : Person
{

}