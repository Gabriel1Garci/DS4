using System.Runtime.InteropServices;
using System;

internal class Program
{
    class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }

    List<Estudiante> estudiantes = new List<Estudiante>
    {

        new Estudiante { Nombre = "Ana", Edad = 12},
        new Estudiante { Nombre = "Juan", Edad = 10},
        new Estudiante { Nombre = "Sofia", Edad = 11}

    };


    public static void Main(String[] args)
    {

        Program programa = new Program();

        foreach (Estudiante estudiante in programa.estudiantes)
        {

            Console.WriteLine("Nombre:" + estudiante.Nombre + ", Edad: " + estudiante.Edad);

        }

    }
}