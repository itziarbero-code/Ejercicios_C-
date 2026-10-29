using System;
using System.Globalization;

class EC0076
{
    static void Main(String [] args)
    {
        Console.Write("Introduce un numero de una cifra");
        int num = int.Parse(Console.ReadLine());

        switch (num)
        {
            case 1:
                Console.WriteLine("Uno");
                break;

            case 2:
                Console.WriteLine("Dos");
                break;

            case 3:
                Console.WriteLine("Tres");
                break;

            case 4:
                Console.WriteLine("Cuatro");
                break;

            case 5:
                Console.WriteLine("Cinco");
                break;

            case 6:
                Console.WriteLine("Seis");
                break;

            case 7:
                Console.WriteLine("Siete");
                break;

            case 8:
                Console.WriteLine("Ocho");
                break;

            case 9:
                Console.WriteLine("Nueve");
                break;
        }
    }
}