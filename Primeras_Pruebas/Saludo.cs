using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Primeras_Pruebas
{
    public class Saludo
    {
        private string nombre;
        private string apellido;
        public Saludo()
        {
            nombre = "";
            apellido = "";
        }

        public void CapturarNombre()
        {
            Console.WriteLine("ingresa tu nombre:");
            nombre = Console.ReadLine();
        }
         public void CapturarApellido()
         {
            Console.WriteLine("ingresa tu apellido:");
            apellido = Console.ReadLine();
        }
         public void Saludar()
         {
             Console.WriteLine("hola {0} {1}", nombre, apellido);
         }
         public void SaludoFormal()
         {
             Console.WriteLine("hola Sr/a=: {0} {1}", nombre, apellido);
         }
         public void SaludoFormal(String leyenda)
         {
             Console.WriteLine("hola {0}: {1} {2}", leyenda, nombre, apellido);
         }

            

     }
}