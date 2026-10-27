using System;
using System.Globalization;

class EC0085
{
    static void Main(String [] args)
    {
        Console.WriteLine("Introduzca una distancia en metros:");
        double metros = Convert.ToDouble(Console.ReadLine());

        double millas = metros/1609;

        Console.WriteLine($"{metros} metros son {millas} millas");

    }
}