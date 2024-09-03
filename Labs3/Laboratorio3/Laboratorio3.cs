internal class Laboratorio3
{
    private static void Main (string[] args)
    {
        int primerNumero, segundoNumero, suma;

        Console.Write("Introduce el Primeron numero: ");
        primerNumero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce el segundo Numero: ");
        segundoNumero = Convert.ToInt32(Console.ReadLine());

        suma = primerNumero + segundoNumero;

        Console.WriteLine("la suma de {0} y {1} es {2}", primerNumero, segundoNumero, suma); 

    }
}