using System;
using System.Globalization;

class EC0088
{
    static void Main(String [] args)
    {
        Console.Write("Introduce el rojo (0-255): ");
        int r = int.Parse(Console.ReadLine());

        Console.Write("Introduce el verde (0-255): ");
        int g = int.Parse(Console.ReadLine());

        Console.Write("Introduce el azul (0-255): ");
        int b = int.Parse(Console.ReadLine());

        int color = (r << 16) | (g << 8) | b;

        Console.WriteLine("Color hexadecimal: #{0:X6}", color);
    }
}