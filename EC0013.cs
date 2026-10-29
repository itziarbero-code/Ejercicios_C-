using System;
using System.Globalization;

class EC0013
{
    static void Main(String [] args)
    {
        Console.Write("Introduce un numero entero");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Introduce otro numero entero");
        int num2 = int.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine($"El número {num1} es mayor");
        } else
        {
            Console.WriteLine($"El número {num2} es mayor");
        }

    }
}