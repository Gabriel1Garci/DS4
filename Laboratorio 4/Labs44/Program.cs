﻿namespace labs44
{
    class program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Ingrese la nota del estudiante: ");
            float score = float.Parse(Console.ReadLine());

            if (score >= 70)
            {
                Console.WriteLine();
                Console.WriteLine($"Su nota es {score} ha aprobadi");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Su nota es {score} ha reprobado, debe repetir");
            }
        }
    }
}