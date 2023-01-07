using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3_Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string contrasena = "admin123";
            string contrasenaIngresada;
            const int INTENTOS_CONTRASENA = 3;
            int chancesRestantes = INTENTOS_CONTRASENA;

            do
            {
                Console.WriteLine("Ingrese su contraseña: ");
                contrasenaIngresada = Console.ReadLine();

                if (contrasenaIngresada.Equals(contrasena))
                {
                    Console.WriteLine("Bienvenido!! Inicio de sesion exitoso");
                    break;
                }
                else
                {
                    chancesRestantes--;

                    if (chancesRestantes == 1)
                    {
                        Console.WriteLine("Atención!! Ultima oportunidad!");
                    }
                    else if(chancesRestantes > 0)
                    {
                        Console.WriteLine($"Tiene {chancesRestantes} chances más");
                    }
                    
                }
                
            } while (chancesRestantes > 0);

            if(chancesRestantes == 0)
            {
                Console.WriteLine("Tres veces fallidas, inicio de sesión erroneo. Intente nuevamente");
            }

            Console.WriteLine("\nPresione una tecla para finalizar el programa...");
            Console.ReadKey();

        }
    }
}
