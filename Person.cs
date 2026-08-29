using System;
using System.ComponentModel;
using System.Security.Cryptography;

// Interface is easy and best way for make abstract class
interface IPerson
{
    string? Who();

}

// Ek hi cheez ka multiple forms mein behave karna.Polymorphism

class Doctor : IPerson
{

    public string? Who()
    {
        return ToString()?.Split('.')[^1];
    }


}

class Manager : IPerson
{

    public string? Who()
    {
        return ToString()?.Split('.')[^1];
    }


}
interface IAnimal
{
    void MakeSound();
}

class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}


class Cat : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}