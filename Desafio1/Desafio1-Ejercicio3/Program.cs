using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1_Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double IVA = 1.21;

            double remera = 59.90;
            double pantalon = 99.90;
            double campera = 149.90;

            Console.WriteLine($"remera con IVA: ${remera * IVA}");
            Console.WriteLine($"pantalon con IVA: ${pantalon * IVA}");
            Console.WriteLine($"campera con IVA: ${campera * IVA}");

            Console.ReadKey();
        }
    }
}
