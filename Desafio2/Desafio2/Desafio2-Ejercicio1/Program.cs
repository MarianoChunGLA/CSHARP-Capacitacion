using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2_Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int NOTA_APROBADO = 4;
            const int NOTA_PROMOCION = 7;

            const string APROBADO = "APRUEBA";
            const string PROMOCIONADO = "PROMOCIONA";
            const string DESAPROBADO = "DESAPRUEBA";


            Console.Write("Ingrese nota: ");
            int nota = Convert.ToInt32(Console.ReadLine());

            if (nota >= NOTA_PROMOCION) 
            { 
                Console.WriteLine(PROMOCIONADO); 
            } else if (nota >= NOTA_APROBADO) 
            { 
                Console.WriteLine(APROBADO); 
            } else 
            { 
                Console.WriteLine(DESAPROBADO); 
            }

            Console.ReadKey();
        }
    }
}
