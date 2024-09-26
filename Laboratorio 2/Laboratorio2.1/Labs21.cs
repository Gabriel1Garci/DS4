using System;

namespace laboratorio21
{ 

    public class labs21
    { 
        public static void Main()
        {
            MyClass.valor = 1; 
            Console.WriteLine(MyClass.valor);
        }
            
    }
    public class MyClass
    {
        public static int valor;
    }

}
