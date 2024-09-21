public class Empleado
{
    private string nombre;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }

    }
}

public class CuentaBancaria
{
    private decimal saldo;

    public decimal Saldo
    {
        get { return Saldo; }
        set
        {
            if (value >= 0)
                saldo = value;
            else
                throw new ArgumentException("El saldo no puede ser negativo");
        }

    }
}

public class Cobertura
{
    private double radio;

    public Cobertura(double radio)
    {
        this.radio = radio;
    }

    public double Radio
    {
        get { return radio; }

    }
}

internal class Program
{
    private static void Main (string[] args)
    {
        Empleado empleado = new Empleado();
        empleado.Nombre = "John doe";
        Console.WriteLine($"nombre del empleado: {empleado.Nombre}");

        CuentaBancaria cta = new CuentaBancaria();
        cta.Saldo = 100;
        Console.WriteLine($"El Saldo del empleado: {cta.Saldo}");

        Cobertura c = new Cobertura(5);
        Console.WriteLine($"con una cobertura de: {c.Radio}");
    }
}