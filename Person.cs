

using System;
using System.ComponentModel;
using System.Security.Cryptography;

// Interface is easy and best way for make abstract class
interface IPerson
{
    string Name { get; set; }
    int Age { get; set; }
    string GetName();

}

interface IEmployee
{
    string Designation { get; set; }
}


class Doctor : IPerson, IEmployee
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public string Designation { get; set; } = string.Empty;

    public string GetName()
    {
        return Name;
    }


}
