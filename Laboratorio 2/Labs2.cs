using System;
using System.Net.Http.Json;

namespace Laboratorio2
{
    public class Labs2
    {
        static void Main(string[] args)
        {

            client client = new client();
            //ejemplo utilizando las variables de instancia  de clase.
            client.FirstName = "Gabriel";
            client.LastName = "Garcia";
            client.Age = 15;
            client.Id = 1;

            Console.WriteLine(client.GetFullName());

        }

        public class client
        {
            //Declarando variables de instancia en Clase. 
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public ushort Age { get; set; }

            public string GetFullName()
            {
                //Utilizando variable de instamcia dentro de metodos de clase. 
                return FirstName + " " + LastName;
            }
        }

    }
}