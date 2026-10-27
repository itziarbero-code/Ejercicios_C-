using System;
using System.Globalization;

class EC0085
{
    static void Main(String [] args)
    {
        Console.WriteLine("Introduzca un número");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine($"Tabla del {numero}");
        Console.WriteLine($" {numero} * 1 = {numero * 1}");
        Console.WriteLine($" {numero} * 2 = {numero * 2}");
        Console.WriteLine($" {numero} * 3 = {numero * 3}");
        Console.WriteLine($" {numero} * 4 = {numero * 4}");
        Console.WriteLine($" {numero} * 5 = {numero * 5}");
        Console.WriteLine($" {numero} * 6 = {numero * 6}");
        Console.WriteLine($" {numero} * 7 = {numero * 7}");
        Console.WriteLine($" {numero} * 8 = {numero * 8}");
        Console.WriteLine($" {numero} * 9 = {numero * 9}");
        Console.WriteLine($" {numero} * 10 = {numero * 10}");

    }
}