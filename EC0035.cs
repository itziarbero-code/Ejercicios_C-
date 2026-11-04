using System;
using System.Globalization;

class EC0035
{
    static void Main(String [] args)
    {
        int vocales = 0;

        Console.Write("Introduce una cadena: ");
        string cadena = Console.ReadLine();

        for (int i = 0; i < cadena.Length; i++)
        {
            char letra = char.ToLower(cadena[i]);

            if (letra == 'a' || letra == 'e' || letra == 'i' ||
                letra == 'o' || letra == 'u')
            {
                vocales++;
            }
        }

        Console.WriteLine("Número de vocales: " + vocales);

    }
}