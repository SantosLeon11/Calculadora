using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PractiaPooR.Funciones
{
    public class Menu: Operaciones
    {
        int num1, num2, num3, num4, num5,resultado;
        public void Opciones()
        {
            Console.WriteLine("Ingresa una de las opciones");
            Console.WriteLine("1: Suma");
            Console.WriteLine("2: resta");
            Console.WriteLine("3: multiplicacion");
            Console.WriteLine("4: Dolar a peso");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            
            switch (opcion)
            {
                case 1:
                    #region Pedir 5 numeros
                    Console.WriteLine("Ingresa el numero 1");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo valor");
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Dame el 3er numero para la suma");
                    num3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Dame el 4to numero para la suma");
                    num4 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Dame el 5to numero para la suma");
                    num5 = int.Parse(Console.ReadLine());
                    #endregion
                    resultado = Suma(num1,num2,num3,num4,num5);
                    Console.WriteLine($"El resultado de la Suma es {resultado}");
                    break;
                case 2:
                    #region Pedir 2 numeros para restar
                    Console.WriteLine("Ingresa el numero 1");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo valor");
                    num2 = int.Parse(Console.ReadLine());
                    #endregion
                    resultado = Resta(num1, num2);
                    Console.WriteLine($"El resultado de la Resta es {resultado}");
                    break;
                case 3:
                    #region Pedir 2 numeros para Multiplicacion
                    Console.WriteLine("Ingresa el numero 1");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo valor");
                    num2 = int.Parse(Console.ReadLine());
                    #endregion
                    resultado = Multiplicacion(num1, num2);
                    Console.WriteLine($"El resultado de la Multiplicacion es {resultado}");
                    break;
                case 4:
                    DolarApeso();
                    break;
                default:
                    Console.WriteLine("No hay esa opcion unu");
                    break;
            }
        }
    }
}
