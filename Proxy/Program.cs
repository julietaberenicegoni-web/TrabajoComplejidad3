/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 27/10/2026
 * Time: 19:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Proxy
{
	class Program
	{
		public static void Main(string[] args)
		{
			IDocumento documento = new DocumentoProxy();

			Console.WriteLine(documento.Leer("juan"));

			Console.WriteLine(documento.Leer("admin"));

			Console.WriteLine(documento.Leer("admin"));
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}