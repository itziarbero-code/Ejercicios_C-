using System;
using System.Globalization;

class EC0016
{
    static void Main(String [] args)
    {
        int numero;
        string entrada;

        while (true)
        {
            Console.Write("Introduce un número entero: ");
            entrada = Console.ReadLine();

            if (int.TryParse(entrada, out numero))
            {
                Console.WriteLine("Has introducido correctamente un número entero");
                break;
            }
            else
            {
                Console.WriteLine("Error: debes introducir un número entero. Inténtalo de nuevo.");
            }
        }

    }
}