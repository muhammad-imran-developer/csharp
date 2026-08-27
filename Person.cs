

using System;
using System.ComponentModel;
using System.Security.Cryptography;


abstract class Person
{
    public string Name = "TEST";
    public static int Age = 18;

    abstract public void Talk();
}


class Doctor : Person
{
    public override void Talk()
    {

    }
}

class Patient : Person
{
    public override void Talk()
    {

    }
}