using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MyApp;

class Program
{



    /* ===================================================================

    // Program ko is tarah likhna ke error aaye to application crash hone ke bajaye us error ko properly handle kare.
    =======================================================================
    Exception	                        Example
    NullReferenceException	            null object ko access karna
    DivideByZeroException	            Zero se divide
    FormatException	                    Invalid string conversion
    IndexOutOfRangeException	        Array ke invalid index ko access
    ArgumentException	                Invalid argument
    ArgumentNullException	            Required argument null
    InvalidOperationException	        Invalid operation/state
    FileNotFoundException	            File nahi mili
    =========================================================================
    // try ke andar woh code likhte hain jahan exception occur hone ka chance ho.
    //(Finally) Cleanup code jo normally execute hona chahiye, chahe exception aaye ya na aaye.
 
============================
BASIC STRUCTURE OF EXCEPTION
============================

    try
{
    // risky code
}
catch (Exception ex)
{
    // handle error
}
finally
{
    // cleanup
}

      =======================================================================  */
    static void Main(string[] args)
    {


        try
        {
            int a = 10;
            int b = 0;

            int result = a / b;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }


        try
        {
            int number = int.Parse("abc");
        }
        catch (FormatException)
        {
            Console.WriteLine("Wrong format.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Number is too large.");
        }
        catch (Exception)
        {
            Console.WriteLine("Unknown error.");
        }


        try
        {
            int number = int.Parse("abc");
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid number.");
        }
        finally
        {
            Console.WriteLine("Finished.");
        }


    }


}
