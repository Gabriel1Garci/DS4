﻿using System;

class Program
{
    static void Main()
    {

        Console.Write("Introduce el largo del rectángulo: ");
        double largo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce el ancho del rectángulo: ");
        double ancho = Convert.ToDouble(Console.ReadLine());

        double perimetro = 2 * (largo + ancho);

        Console.WriteLine($"El perímetro del rectángulo es: {perimetro}");
    }
}
