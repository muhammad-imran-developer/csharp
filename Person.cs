

using System;

class Person
{
    // public string? Name;
    string? m_Name;

    public string Name
    {
        set
        {
            m_Name = string.IsNullOrEmpty(value) ? "MUHAMMAD" : value;
        }
        get
        {
            return m_Name ?? "MUHAMMAD";
        }
    }
}