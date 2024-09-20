using System;


namespace Labs8
{
    class Colaborador
    {
        public static void Main ()
        {
            Trabajador p = new Trabajador ("Jason", 22, "77588260", 100000);
            Console.WriteLine("Nombre= " +p.Nombre);
            Console.WriteLine("Edad= " + p.Edad);
            Console.WriteLine("NIF= " + p.NIF);
            Console.WriteLine("Sueldo= " + p.Sueldo);
            Console.ReadKey();
        }

    }
}
