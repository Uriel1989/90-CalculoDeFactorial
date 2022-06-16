using System;

//Crea una función que calcule el factorial de un número.

namespace _90_CalculoDeFactorial
{
    class Program
    {
        static void Main(string[] args)
        {

            Factorial factor = new Factorial();

            int resultado = factor.operacion(5);

            Console.WriteLine("El facotorial del numero ingresado es: " + resultado);
        }
    }
}
