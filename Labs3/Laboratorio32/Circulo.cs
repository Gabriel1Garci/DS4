using System;

namespace CalculadoraArea
{
    public class Circulo
    {
        public double CalculoArea(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}