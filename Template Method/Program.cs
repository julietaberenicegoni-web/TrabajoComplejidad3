/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 28/10/2026
 * Time: 14:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Template_Method
{
	class Program
	{
		public static void Main(string[] args)
		{
			PreparadorDeCafe cafe = new PreparadorDeCafe();
            PreparadorDeTe te = new PreparadorDeTe();

            Console.WriteLine("Preparando café:");
            cafe.prepararBebida();

            Console.WriteLine();

            Console.WriteLine("Preparando té:");
            te.prepararBebida();
            
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}