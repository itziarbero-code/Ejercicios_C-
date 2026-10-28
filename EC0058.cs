using System;
using System.Globalization;

class EC0058
{
    static void Main(String [] args)
    {
        Console.WriteLine("Introduce número:");
        int num = Convert.ToInt32(Console.ReadLine()); 

        int ultimo_digito = Math.Abs(num) % 10;

        Console.WriteLine($"El ultimo digito es {ultimo_digito}");

    }
}