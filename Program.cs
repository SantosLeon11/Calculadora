using PractiaPooR.Clases;
using System;

namespace PractiaPooR
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Persona persona = new Persona();
            persona.Pedir();
            persona.Imprimir();
        }
    }
}