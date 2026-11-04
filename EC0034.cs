using System;
using System.Globalization;

class EC0034
{
    static void Main(String [] args)
    {
        Console.Write("Introduce una cadena: ");
        string cadena = Console.ReadLine();

        char primera = cadena[0];
        char ultima = cadena[cadena.Length - 1];

        Console.WriteLine(primera);
        Console.WriteLine(ultima);
    }
}