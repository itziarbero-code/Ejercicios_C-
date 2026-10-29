using System;
using System.Globalization;

class EC0028
{
    static void Main(String [] args)
    {
        Console.Write("Introduce un numero");
        int n = int.Parse(Console.ReadLine());

        int suma = 0;

        for (int i = 0; i <= n; i++)
        {
            suma += i;
        }

        Console.WriteLine($"La suma de 1 a {n} es {suma}");
    }
}