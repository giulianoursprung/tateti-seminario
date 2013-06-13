using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Primeras_pruebas
{
    public class Cliente
    {
        private string nombre, apellido, direccion, localidad, telefono, codigo;
        private DateTime fecha_nacimiento;

        
        public Cliente()
        {
            Console.WriteLine("Creando un objeto basado en la clase Cliente:");
        }

       
        public string MostrarNombreCompleto()
        {
            return apellido + " " + nombre;
        }
       
       
        private void CapturarNombre()
        {
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
        }

        private void CapturarApellido()
        {
            Console.Write("Ingrese su apellido: ");
            apellido = Console.ReadLine();
        }

        private void CapturarDireccion()
        {
            Console.Write("Ingrese su dirección: ");
            direccion = Console.ReadLine();
        }

       
        private void CapturarLocalidad()
        {
            Console.Write("Ingrese su localidad: ");
            localidad = Console.ReadLine();
        }
        
       
        private string AnunciarEdad()
        {
            //tomamos la fecha de hoy y la almacenamos en la
            //variable "hoy"
            DateTime hoy = DateTime.Now;
            int edad = 0;
            //evalua si la persona ya cumplio años en el año
            //actual
            if (hoy.DayOfYear >= fecha_nacimiento.DayOfYear)
            {
                edad = hoy.Year - fecha_nacimiento.Year;
            }
            else
            {
                edad = (hoy.Year - fecha_nacimiento.Year) - 1;
            }
            return "Tengo " + edad + " años";

        }

        
        private void CapturarTelefono()
        {
            Console.Write("Por último ingrese su teléfono: ");
            telefono = Console.ReadLine();
        }
        
       
        private void CapturarCodigo()
        {
            Console.Write("Ingrese Código: ");
            codigo = Console.ReadLine();
        }
        
        
        private void CapturarFecha_Nacimiento()
        {
            Console.Write("Ingrese su Fecha de Nacimiento: ");
            try
            {
                fecha_nacimiento = Convert.ToDateTime(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error, ingrese la fecha correctamente");
                CapturarFecha_Nacimiento();
            }
        }

       
        public void CapturarDatos()
        {
            CapturarCodigo();
            CapturarApellido();
            CapturarNombre();
            CapturarDireccion();
            CapturarLocalidad();
            CapturarTelefono();
            CapturarFecha_Nacimiento();
        }

        public void ImprimirFicha()
        {
            Console.WriteLine("\nPrueba de Consola en \"C#\"");
            Console.WriteLine("FICHA PERSONAL CLIENTE");
            Console.WriteLine("Código " + codigo);
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellido: " + apellido);
            Console.WriteLine("Direccion: " + direccion);
            Console.WriteLine("Localidad: " + localidad);
            Console.WriteLine("Telefono: " + telefono);
            Console.WriteLine("Fecha de Nacimiento: " + fecha_nacimiento.ToShortDateString());
        }
        
        public void ImprimirHorizontal()
        {
            Console.WriteLine("{0} {1} {2} {3}", codigo, apellido, nombre, direccion);
        }
        
        private string Presentarse()
        {
            return "Hola soy " + apellido + " " + nombre;
        }
        
        private string AnunciarDomicilio()
        {
            return "Vivo en " + direccion + " " + localidad;
        }
       
        public void Hablar()
        {
            for (int x = 0; x < 40; x++)
                Console.Write("*");
                

            Console.WriteLine("\n");
            Console.WriteLine(Presentarse());
            Console.WriteLine(AnunciarDomicilio());
            Console.WriteLine(AnunciarEdad());
        }
    }
}