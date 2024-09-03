using System;

class Program
{
    static void Main (string[] args)
    {
        int a, b, resultado; 

        Console.WriteLine("Ingrese el primer numero: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero ");
        b = Convert.ToInt32(Console.ReadLine());

        CalculosMatematicos calculos = new CalculosMatematicos();

        resultado = calculos.Calcular(a, b);

        Console.WriteLine("El resultado de la operacion es: " + resultado);

    }
}