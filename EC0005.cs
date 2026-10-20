using System;
using System.Globalization;

class EC0005
{
    static void Main(String [] args)
    {
        double entero1 = 321;
        double entero2 = 698;
        double resultado = entero2 / entero1;

        Console.WriteLine($"La solucion de la división entre {entero2} y {entero1} es {resultado:F3}");

    }
}