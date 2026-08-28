

using System;
using System.ComponentModel;
using System.Security.Cryptography;


abstract class Person
{
    // STATIC DATA IS CREATED ONLY ONCE

    static public ulong Count = 0ul;

    public Person()
    {
        Count++;
    }
}

class Doctor : Person
{
    public Doctor() : base()
    {

    }
}

class Patient : Person
{
    public Patient() : base()
    {

    }

}