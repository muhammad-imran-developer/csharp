

using System;
using System.ComponentModel;
using System.Security.Cryptography;

class Person
{
    // public string? Name;

    public Person()
    {
        m_Name = "SET NAME";
    }

    public Person(string _name) : this()
    {
        Name = _name;
    }
    string m_Name;

    public string Name
    {
        set
        {
            m_Name = string.IsNullOrEmpty(value) ? m_Name : value;
        }
        get
        {
            return m_Name;
        }
    }
}