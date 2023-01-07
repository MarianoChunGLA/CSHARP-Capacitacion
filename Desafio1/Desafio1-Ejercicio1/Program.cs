using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1_Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool n1 = true, n2 = false, n3 = true;

            Console.WriteLine($"n1 ^ n2 = {n1 ^ n2}"); // True
            Console.WriteLine($"(n1 & !n2) | n3 = {n1 & !n2 | n3}"); // True
            Console.WriteLine($"(n1 | n2) & !n3 = {(n1 | n2) & !n3}"); // False

            Console.ReadKey();
        }
    }
}
