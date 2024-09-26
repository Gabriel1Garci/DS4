using System;

class Contar
{
    static void Main(string[] args)
    {
        Console.WriteLine("Los números pares del 1 al 100 son:");

        for (int i = 1; i <= 100; i++) 
        {
            if (i % 2 == 0 || i % 3 == 0)
                {
                Console.Write(i+", "); 
            }

        }
    }
}

