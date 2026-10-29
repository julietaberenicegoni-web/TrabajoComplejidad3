/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 28/10/2026
 * Time: 14:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Chain_Of__Responsability
{
	class Program
	{
		public static void Main(string[] args)
		{
			Supervisor supervisor = new Supervisor();
            Gerente gerente = new Gerente();
            Director director = new Director();

            // Armamos la cadena
            supervisor.EstablecerSucesor(gerente);
            gerente.EstablecerSucesor(director);

            // Probamos distintos montos
            SolicitudDeGasto s1 = new SolicitudDeGasto(800, "Compra de útiles");

            SolicitudDeGasto s2 = new SolicitudDeGasto(3000, "Compra de muebles");

            SolicitudDeGasto s3 = new SolicitudDeGasto(8000, "Compra de equipos");

            Console.WriteLine("CADENA COMPLETA");
            supervisor.aprobar(s1);
            supervisor.aprobar(s2);
            supervisor.aprobar(s3);

            // Probamos una cadena incompleta
            Console.WriteLine("\nCADENA INCOMPLETA");

            Supervisor supervisor2 = new Supervisor();
            Gerente gerente2 = new Gerente();

            supervisor2.EstablecerSucesor(gerente2);

            SolicitudDeGasto s4 = new SolicitudDeGasto(7000, "Compra extraordinaria");

            supervisor2.aprobar(s4);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}