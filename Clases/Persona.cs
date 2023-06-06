using PractiaPooR.Funciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiaPooR.Clases
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido {get; set; }
        public string Carrera { get; set; }
        public int Edad { get; set; }

        public void Pedir()
        {
            Console.WriteLine("Ingresa tu nombre:");
            this.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu apellido");
            this.Apellido = Console.ReadLine();
            Console.WriteLine("Ingresa tu carrera");
            this.Carrera = Console.ReadLine();
            Console.WriteLine("Ingresa tu edad");
            this.Edad = int.Parse(Console.ReadLine());
            Console.Clear();

            if (Edad >= 18)
            {
                Menu menu= new Menu();
                menu.Opciones();
            }
            else
            {
                Console.WriteLine("No tienes permitido acceder al menu");
            }
        }
        public void Imprimir()
        {
            Console.WriteLine($"El nombre es: {Nombre}\nEl apellido es: {Apellido}\nLa carrera es: {Carrera}\nLa edad es: {Edad}");
        }
    }
}
