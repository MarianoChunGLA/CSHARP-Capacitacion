using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3_Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float ingreso = 1000;
            float interesMensual;
            const float INTERES = 0.03F;
            int numeroMes = 0;


            while (ingreso <= 1200.0)
            {
                numeroMes++;
                interesMensual = ingreso * INTERES;
                ingreso += ingreso * INTERES;
                Console.WriteLine($"Con un interes de 3% mensual de ${interesMensual}, al mes {numeroMes}, se tendrá un ingreso de ${ingreso}");
                
            }
            Console.WriteLine($"\nFinalmente, en {numeroMes} meses se conseguirá llegar a la suma de ${ingreso}");
            Console.ReadKey();
        }
    }
}
