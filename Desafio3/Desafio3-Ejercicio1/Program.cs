using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3_Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float ingreso = 1000;
            float interesMensual;
            const float INTERES = 0.02F;
            const int MESES = 12;


            for (int i = 1; i <= MESES; i++)
            {
                interesMensual = ingreso * INTERES;
                ingreso += ingreso * INTERES;
                Console.WriteLine($"En el mes {i}, tiene un total de ${ingreso}, siendo el 2% de interes mensual de ${interesMensual}");
            }
            Console.WriteLine($"\nFinalmente, al cabo de un año se tendrá la suma de ${ingreso}");
            Console.ReadKey();
        }
    }
}
