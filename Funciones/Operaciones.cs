using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiaPooR.Funciones
{
    public class Operaciones
    {
        #region Suma
        //public void Suma()
        //{
        //    Console.WriteLine("Dame el valor del primer numero a sumar");
        //    num1 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Dame el valor del segundo numero");
        //    num2 = int.Parse(Console.ReadLine());
        //    resultado = num1 + num2;
        //    Console.WriteLine($"El resultado es {resultado}");
        //}
        #endregion
        public int Suma(int num1, int num2,int num3, int num4, int num5)
        {
            int resultado = num1 + num2 + num3 + num4 + num5;
            return resultado;
        }
        public int Resta(int num1, int num2)
        {
            int resultado = num1 - num2;
            return resultado;
        }
        public int Multiplicacion(int num1, int num2)
        {
            int resultado = num1 * num2;
            return resultado;
        }
        public void DolarApeso()
        {
            float dolar=0;
            float peso = 0;
            Console.WriteLine("Dame la cantidad en dolar a comvertir en peso");
            dolar = float.Parse(Console.ReadLine());
            peso = dolar * 18;
            Console.WriteLine($"El valor en pesos es {peso}");

        }
    }
}
