using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio4_Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] facturacionAnual =
            {
                // 1er trimestre
                1000,
                2000,
                1500,

                // 2do trimestre
                5000,
                3500,
                500,

                // 3er trimestre
                6000,
                3000,
                1200,

                //4to trimestre
                200,
                250,
                300
            };

            int[] facturacionTrimestres = new int[4];
            // El indice de facturacion trimestral aumenta en indice mes = 2 (mes 3), 5 (mes 6), 8 (mes 9) y 11 (mes 12)
            int indiceFacturacionTrimestral = 0;

            int sumaFacturacionTrimestral = 0;

            for(int indiceMes = 1; indiceMes <= facturacionAnual.Length; indiceMes++)
            {
                sumaFacturacionTrimestral += facturacionAnual[indiceMes-1];
                
                if (indiceMes % 3 == 0)
                {
                    facturacionTrimestres[indiceFacturacionTrimestral] = sumaFacturacionTrimestral;
                    sumaFacturacionTrimestral = 0;
                    indiceFacturacionTrimestral++;
                }
            }

            // Imprimo los valores del año
            Console.WriteLine("Durante el año, se facturo lo siguiente\n");

            foreach (int facturacionMensual in facturacionAnual)
            {
                Console.WriteLine($"Se facturó ${facturacionMensual} durante el mes {Array.IndexOf(facturacionAnual, facturacionMensual)+1}");
            }

            // Imprimo los valores trimestrales
            Console.WriteLine("\nDurante cada trimestre del año, se facturo lo siguiente\n");

            foreach (int facturacionTrimestral in facturacionTrimestres)
            {
                Console.WriteLine($"Se facturó ${facturacionTrimestral} durante el trimestre {Array.IndexOf(facturacionTrimestres, facturacionTrimestral)+1}");
            }


            Console.WriteLine("\nPresione una tecla para finalizar...");
            Console.ReadKey();

        }
    }
}
