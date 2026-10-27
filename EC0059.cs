using System;
using System.Globalization;

class EC0085
{
    static void Main(String [] args)
    {
        Console.WriteLine("¿Cuanto vale sin IVA?");
        double precio = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"El producto con IVA vale {precio * 1.21}");

    }
}