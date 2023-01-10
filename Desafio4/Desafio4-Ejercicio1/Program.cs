using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio4_Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] origen = { 1002, 104, 309, 500};
            int[] destino = new int[origen.Length];

            int indiceInvertidoOrigen = origen.Length - 1;

            Console.WriteLine("Indices y valores nuevo vector (destino)\n");
            for(int i = 0; i < destino.Length; i++)
            {
                destino[i] = origen[indiceInvertidoOrigen];
                Console.WriteLine($"Vector destino: Indice: {i} con valor {destino[i]}");
                
                indiceInvertidoOrigen--;
            }

            Console.WriteLine("\nPresione una tecla para finalizar...");
            Console.ReadKey();      
        }
    }
}
