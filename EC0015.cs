using System;
using System.Globalization;

class EC0015
{
    static void Main(String [] args)
    {
        Console.Write("Introduce un numero");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Introduce un segundo numero");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Introduce un tercer numero");
        int num3 = int.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            if (num1 > num3)
            {
                Console.WriteLine($"{num1} es el mayor");
            } else
            {
                Console.WriteLine($"{num3} es el mayor");
            }
        } else
        {
            if (num2 > num3)
            {
                Console.WriteLine($"{num2} es el mayor");
            } else
            {
                Console.WriteLine($"{num3} es el mayor");
            }
        }

        if (num1 < num2)
        {
            if (num1 < num3)
            {
                Console.WriteLine($" y {num1} es el menor");
            } else
            {
                Console.WriteLine($" y {num3} es el menor");
            }
        } else
        {
            if (num2 < num3)
            {
                Console.WriteLine($" y {num2} es el menor");
            } else
            {
                Console.WriteLine($" y {num3} es el menor");
            }
        }

    }
}