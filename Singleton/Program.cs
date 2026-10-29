/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 28/10/2026
 * Time: 21:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Singleton
{
	class Program
	{
		public static void Main(string[] args)
		{
			ConfiguracionDelSistema c1 =ConfiguracionDelSistema.obtenerInstancia();

			ConfiguracionDelSistema c2 = ConfiguracionDelSistema.obtenerInstancia();

			c1.establecerValor("Idioma", "Español");

			Console.WriteLine(c2.obtenerValor("Idioma"));

			if (c1 == c2)
			{
				Console.WriteLine("Ambas referencias apuntan a la misma instancia.");
			}
			else
			{
				Console.WriteLine("Son instancias diferentes.");
			}

			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}