using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Runtime.CompilerServices;

class Solicitud
{
    static void Main(string[] args)
    {
        double total = 0;
        string volver;

        do
        {
            Console.Write("Ingresar el precio del producto: ");
            double precio = Convert.ToDouble(Console.ReadLine());
            total += precio;

            Console.WriteLine("¿Desea ingresar un producto más (si/no)?: ");
            volver = Console.ReadLine().ToLower();

        } while (volver == "si");

        Console.WriteLine($"El total a pagar es de {total}");

        Console.Write("¿Cuál es su método de pago? ");
        string metodo_Pago = Convert.ToString(Console.ReadLine());

        if (metodo_Pago.ToLower() == "tarjeta")
        {
            do
            {
                Console.Write("Introduzca los 16 dígitos de su tarjeta: ");
                string tarjeta = Convert.ToString(Console.ReadLine());

                if (tarjetaValida(tarjeta))
                {
                    Console.WriteLine("Número de tarjeta válido");
                    break;
                }
                else
                {
                    Console.WriteLine("Número de tarjeta no válido");
                }
            }while(true);

            static bool tarjetaValida(string tarjeta)
            {
                if (tarjeta.Length != 16 || !EsSoloDigitos(tarjeta))
                {
                    return false;
                }

                int suma = 0;
                bool esSegundoDigito = false;

                for (int i = tarjeta.Length - 1; i >= 0; i--)
                {
                    int n = int.Parse(tarjeta[i].ToString());

                    if (esSegundoDigito)
                    {
                        n *= 2;
                        if (n > 9)
                        {
                            n -= 9;
                        }
                    }

                    suma += n;
                    esSegundoDigito = !esSegundoDigito;
                }

                return (suma % 10 == 0);
            }

            static bool EsSoloDigitos(string cadena)
            {
                foreach (char c in cadena)
                {
                    if (!char.IsDigit(c))
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        else
        {
            Console.WriteLine("Pagar en Efectivo");
        }
    }
}

