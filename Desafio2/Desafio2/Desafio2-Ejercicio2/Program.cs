using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2_Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese otro numero: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine($"El primer numero ingresado es MAYOR, la suma de {n1} + {n2} es de {n1 + n2}, y la diferencia de {n1} - {n2} es de {n1 - n2}");
            }
            else 
            { 
                Console.WriteLine($"El primer numero ingresado es MENOR, el producto de {n1} * {n2} es de {n1 * n2}, y el cociente entre {n2} / {n1} es de {n2 / n1}"); 
            }


            Console.ReadKey();
        }
    }
}
