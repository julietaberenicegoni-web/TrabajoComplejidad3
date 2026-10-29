/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 28/10/2026
 * Time: 13:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Composite
{
	class Program
	{
		public static void Main(string[] args)
		{
			Carpeta raiz = new Carpeta("Raiz");

			Carpeta documentos = new Carpeta("Documentos");
			Carpeta fotos = new Carpeta("Fotos");

			Archivo archivo1 = new Archivo("informe.txt", 300);
			Archivo archivo2 = new Archivo("trabajo.doc", 200);
			Archivo archivo3 = new Archivo("vacaciones.jpg", 500);
			Archivo archivo4 = new Archivo("familia.png", 700);

			documentos.agregar(archivo1);
			documentos.agregar(archivo2);

			fotos.agregar(archivo3);
			fotos.agregar(archivo4);

			raiz.agregar(documentos);
			raiz.agregar(fotos);

			Console.WriteLine("Estructura de archivos:");
			raiz.mostrar(0);

			Console.WriteLine("Tamano total: " + raiz.obtenerTamano() + " bytes");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}