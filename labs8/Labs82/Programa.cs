public class Cuenta
{
    private string idCuenta;

    public Cuenta(string prmtIdCuenta)
    {
        this.idCuenta = prmtIdCuenta;
        System.Console.WriteLine("Constructor Clase Base para cuenta {0}", prmtIdCuenta);
    }

    public virtual void CalcularIntereses()
    {
        System.Console.WriteLine("CUenta.CalcularIntereses() efectuado para la cuenta {0}", this.idCuenta);
    }

    public string getIdCuenta()
    {
        return this.idCuenta;
    }

}

public class CuentaCorriente : Cuenta
{
    public CuentaCorriente(string prmtIdCuenta) : base(prmtIdCuenta) 
    {
    }

    public override void CalcularIntereses()
    {
        System.Console.WriteLine ("CuenctaCorriente.CalcularIntereses() efectuado para " + "las cuenta {0}", getIdCuenta());

    }
}

public class CuentaAhorro : Cuenta
{
    public CuentaAhorro(string prmtIdCuenta) : base(prmtIdCuenta)
    {
    }

    public override void CalcularIntereses()
    {
        System.Console.WriteLine("CuenctaAhorro.CalcularIntereses() efectuado para " + "las cuenta {0}", getIdCuenta());

    }
}

internal class Programa
{
    private static void Main(string[] args)
    {
        const string Cuenta = "100";

        Cuenta cuenta = new Cuenta(Cuenta);
        CuentaCorriente cuentaCorriente = new CuentaCorriente(Cuenta);
        CuentaAhorro cuentaAhorro = new CuentaAhorro(Cuenta);
        cuenta.CalcularIntereses();
        cuentaCorriente.CalcularIntereses();
        cuentaAhorro.CalcularIntereses();
    }
}