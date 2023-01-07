using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2_Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la primer nota de parcial: ");
            int notaPrimerParcial = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese la segunda nota de parcial: ");
            int notaSegundoParcial = Convert.ToInt32(Console.ReadLine());

            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4) 
            { 
                Console.WriteLine("APROBADO"); 
            }
            else if (notaPrimerParcial >= 4 && notaSegundoParcial < 4) 
            { 
                Console.WriteLine("Debe recuperar el SEGUNDO parcial"); 
            }
            else if (notaSegundoParcial >= 4 && notaPrimerParcial < 4) 
            { 
                Console.WriteLine("Debe recuperar el PRIMER parcial"); 
            }
            else 
            { 
                Console.WriteLine("DESAPROBADO"); 
            }



            Console.ReadKey();
        }
    }
}
