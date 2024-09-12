using System;


internal class PrimerArray
{
    private int[] sueldos;

    public void Cargar()
    {
        sueldos = new int[5];
        for (int f = 0; f <5; f++)
        {
            Console.Write("Ingrese el sueldo del operario " + (f + 1) + ": ");
            string linea = Console.ReadLine();
            sueldos[f] = int.Parse(linea);
        }
    }

    public void Imprimir()
    {
        Console.WriteLine("Los 5 sueldos de los operarios son:");
        for (int f = 0; f <5 ; f++) 
        {
            Console.Write("[" + sueldos[f] + "] ");
        }
        Console.ReadKey();
    }

    static void Main(string[] args)
    {
        PrimerArray pv = new PrimerArray();
        pv.Cargar();
        pv.Imprimir();
    }
}
