using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio71
{
    class Banco
    {
        private Cliente Cliente1, Cliente2, Cliente3;

        public Banco()
        {
            Cliente1 = new Cliente("Yhonas");
            Cliente2 = new Cliente("Ana");
            Cliente3 = new Cliente("Pedro");
        }

        public void Operar()
        {
            Cliente1.Depositar(100);
            Cliente2.Depositar(150);
            Cliente3.Depositar(200);
            Cliente3.Depositar(150);

        }
        public void DepositarTotales()
        {
            int  t = Cliente1.RetornarMonto() + Cliente2.RetornarMonto() + Cliente3.RetornarMonto();

            Console.WriteLine("el toatal de dinero en el banco es " + t);
            Cliente1.Imprimir();
            Cliente2.Imprimir();
            Cliente3.Imprimir();
        }
    }
}
