using System;
using System.Globalization;

class EC0014
{
    static void Main(String [] args)
    {
        Console.Write("Introduce un numero entero");
        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine($"{num} es par");
        }
        else
        {
            Console.WriteLine($"{num} es impar");
        }
    
    }
}