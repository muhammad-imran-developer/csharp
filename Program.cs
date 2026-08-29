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

        IPerson person = new Doctor();
        Console.WriteLine(person.Who());

        person = new Manager();
        Console.WriteLine(person.Who());


        IAnimal animal;

        animal = new Dog();
        animal.MakeSound();

        animal = new Cat();
        animal.MakeSound();

    }


}
