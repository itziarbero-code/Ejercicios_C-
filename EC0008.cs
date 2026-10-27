using System;
using System.Globalization;

class EC0085
{
    static void Main(String [] args)
    {
        Console.WriteLine("Introduce primer número:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce segundo número:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduce tercer número:");
        int.TryParse(Console.ReadLine(), out int num3);

        int resultado = num1 + num2 + num3;

        Console.WriteLine( $"{num1} + {num2} + {num3} = {resultado}" );
    }
}