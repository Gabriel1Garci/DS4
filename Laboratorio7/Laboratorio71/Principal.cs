namespace Laboratorio71
{ 
    class Principal
    {
        static void Main (string[] args)
        {
            Banco banco1 = new Banco ();
            banco1.Operar();
            banco1.DepositarTotales();
            Console.ReadKey();
        }
    }


}