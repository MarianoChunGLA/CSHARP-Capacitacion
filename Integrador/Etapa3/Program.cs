using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string nombre, apellido, email, carrera = "";
			string[] cursos = { "Desarrollo Web con HTML", "Introducción a POO", "C# para no programadores", "Introducción a Bases de Datos y SQL", "Introducción a Git"};
			string[] cursosIngresados = new string[cursos.Length];
			int edad = 0;

			while (true)
			{

				Console.Write("Nombre: ");
				nombre = Console.ReadLine();

				Console.Write("Apellido: ");
				apellido = Console.ReadLine();

				Console.Write("Edad: ");
				edad = Convert.ToInt32(Console.ReadLine());

				Console.Write("Correo electronico: ");
				email = Console.ReadLine();

				Console.WriteLine($"DATOS: \n Nombre    :   {nombre} \n Apellido  :   {apellido} \n Edad      :   {edad} \n Email     :   {email}");
				Console.WriteLine("\n\n ¿Los datos son correctos? \n En caso de ser correctos ingresar S\n En caso de ser erroneos ingresar N");

				Console.Write("Afiramar: S || Rehacer: N: ");
				string afirmacion = Console.ReadLine().ToLower();

				if (afirmacion == "s")
				{
					break;
				}
				Console.Clear();
			}
			Console.Clear();


			while (true)
			{

				Console.WriteLine("<<< Selecciona el código de la carrera elegida >>>");
				Console.WriteLine("1. Programación .NET \n2. Programación Java \n3. Programación .PHP");

				Console.Write("\n\nCodigo de carrera: ");
				int codigoCarrera = Convert.ToInt32(Console.ReadLine());


				Console.Clear();
				switch (codigoCarrera)
				{
					case 1:
						carrera = "Programación .NET";
						break;
					case 2:
						carrera = "Programación Java";
						break;
					case 3:
						carrera = "Programación PHP";
						break;
					default:
						Console.WriteLine("Carrera inexistente\nDatos incorrectos, elija nuevamente: ");
						continue;
				}
				break;
			}


			Console.WriteLine("Seleccione uno o varios cursos de los disponibles");

			while (true)
			{
				for (int i = 0; i < cursos.Length; i++)
				{
					Console.WriteLine($"{i + 1}: {cursos[i]}");
				}

				int codigoCurso = Convert.ToInt32(Console.ReadLine());

				if (codigoCurso < 1 || codigoCurso > cursos.Length - 1)
				{
					Console.WriteLine("Error: El codigo de curso elegido no corresponde a un curso existente. Elija nuevamente");
					continue;
				}

				cursosIngresados[codigoCurso-1] = cursos[codigoCurso-1];

				Console.WriteLine("¿Desea seguir ingresando a cursos? Presione 'S' para seguir o 'N' para finalizar");

				string respuesta = Console.ReadLine().ToLower();

				if (respuesta == "s")
				{
					continue;
				}

				Console.Clear();
				break;
			}

			Console.WriteLine($"<<<Constancia de inscripción>>>\n\nAlumno: {nombre} {apellido}\nCorreo electronico: {email}\nCarrera: {carrera}");

			Console.WriteLine("Cursos elegidos: ");
			for (int i = 0; i < cursosIngresados.Length; i++)
			{
				if (!string.IsNullOrEmpty(cursosIngresados[i]))
				{
					Console.WriteLine($"{i + 1}: {cursosIngresados[i]}");
				}
				
			}

			Console.ReadKey();

		}
		
	}
}
