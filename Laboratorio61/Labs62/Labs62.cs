class Labs62
{
    static void Main (string[] args)
    {
        int numero;
        Console.WriteLine("Digite el numero deseado:");

        try
        {
            numero = Int16.Parse(Console.ReadLine());
        }
        catch (FormatException ex)
        {
            Console.WriteLine("No se a introducido un digito calido");
            numero = -1;

        }
        catch (OverflowException ex)
        {
            Console.WriteLine("El Numero introducido es Muy grande");
            numero = -1;

        }
        Console.WriteLine(numero);
    }

  
}