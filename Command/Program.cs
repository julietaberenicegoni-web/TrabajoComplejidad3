
/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 27/10/2026
 * Time: 21:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Command
{
	class Program
	{
		public static void Main(string[] args)
		{
			Luz luz = new Luz();

			ControlRemoto control = new ControlRemoto();

			IComando encender = new ComandoEncenderLuz(luz);
			IComando apagar = new ComandoApagarLuz(luz);

			control.ejecutar(encender);
			control.ejecutar(apagar);
			control.ejecutar(encender);

			control.deshacerUltimo();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}