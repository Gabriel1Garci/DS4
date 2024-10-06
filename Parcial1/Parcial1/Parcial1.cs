class Parcial1
{
    static void Main() 
    {
        int numeroSolicitado;

        do
        {

            Console.Write("Introduzca un Numero Impar para la Matriz: ");
            numeroSolicitado = int.Parse(Console.ReadLine());

            if (numeroSolicitado % 2 == 0)
            {
                Console.WriteLine("El numero debe de ser impar, Intentar denuevo.");
            }

        } while (numeroSolicitado % 2 == 0);

        int[,] matriz = new int[numeroSolicitado, numeroSolicitado];
        Random random = new Random();
        int sumaColumna = 0, sumaFila = 0;
        int indicemedio = numeroSolicitado / 2;

        for (int i = 0; i < numeroSolicitado; i++)
        {
            for (int j = 0; j < numeroSolicitado; j++)
            {
                if (i == indicemedio || j == indicemedio )
                {
                    matriz[i, j] = random.Next(1, 101);
                    if (i == indicemedio) sumaFila += matriz[i, j];
                    if (j == indicemedio) sumaColumna += matriz[i, j];

                }
                else
                {
                    matriz[i, j] = 0;
                }
            }
        }

        Console.WriteLine("\nResultado de la Matriz en Forma de cruz");
        for (int i = 0; i < numeroSolicitado; i++)
        {
            for (int j = 0; j < numeroSolicitado;j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nSuma de valores de la columna Solicitada " + sumaColumna);
        Console.WriteLine(" Suma de los valores de la fila Solicitada " + sumaFila);

    }
}

