using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MyApp;

class Program
{
    // Normal method call mein tum kehte ho "ye method abhi chalao"; delegate mein tum kehte ho "is method ka reference rakho, main ise baad mein ya kisi aur jagah se chalaunga."
    static void Main(string[] args)
    {
        Person.Alert alert = Person.Desktop;

        alert += Person.Laptop;
        alert += Person.Mobile;


        alert.Invoke("OK");




    }


}
