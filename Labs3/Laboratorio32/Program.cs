using System;

namespace CalculadoraArea
{
    class Program
    {
        static void Main(string[] args)
        {

            Circulo circulo = new Circulo();

            Console.Write("Ingrese el radio del círculo: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            double area = circulo.CalculoArea(radio);

            Console.WriteLine($"El área del círculo con radio {radio} es: {area}");

        }
    }
}
