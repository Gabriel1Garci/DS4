internal class Laboratorio31
{
    private static void Main (string[] args)
    {
        int a, b, CalculosMatematicos;

        Console.Write("Introduce el Primeron numero: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce el segundo Numero: ");
        b = Convert.ToInt32(Console.ReadLine());

        CalculosMatematicos = (a+b)*(a-b);

        Console.WriteLine("El resultado del calculo es:" + CalculosMatematicos );

    }
}