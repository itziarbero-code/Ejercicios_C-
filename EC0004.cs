using System;
using System.Globalization;

class EC0004
{
    static void Main(String [] args)
    {
        double op1 = -8 + 6 * 3;
        double op2 = (2 + 7) % 5;
        double op3 = 2 + ( -1 * 8 ) -5 % 3;

        Console.WriteLine($" Operacion 1 = {op1}");
        Console.WriteLine($" Operacion 2 = {op2}");
        Console.WriteLine($" Operacion 3 = {op3}");

    }
}