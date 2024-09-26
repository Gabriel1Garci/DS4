using System;

public class Aleatorios
{
    private Random random;

    public Aleatorios()
    {
        random = new Random();
    }
    public int GenerarNumeroEntre(int min, int max)
    {
        if (min >= max)
        {
            throw new ArgumentException("El valor mínimo debe ser menor que el valor máximo.");
        }
        return random.Next(min, max);
    }

    public int[] GenerarArregloNumeros(int min, int max, int cantidad)
    {
        if (min >= max)
        {
            throw new ArgumentException("El valor mínimo debe ser menor que el valor máximo.");
        }
        if (cantidad <= 0)
        {
            throw new ArgumentException("La cantidad debe ser un número positivo.");
        }

        int[] arreglo = new int[cantidad];
        for (int i = 0; i < cantidad; i++)
        {
            arreglo[i] = random.Next(min, max);
        }
        return arreglo;
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        Aleatorios aleatorios = new Aleatorios();


        int numeroAleatorio = aleatorios.GenerarNumeroEntre(1, 10);
        Console.WriteLine($"Número aleatorio: {numeroAleatorio}");

        int[] arregloAleatorio = aleatorios.GenerarArregloNumeros(1, 10, 5);
        Console.WriteLine("Arreglo de números aleatorios: " + string.Join(", ", arregloAleatorio));
    }
}
