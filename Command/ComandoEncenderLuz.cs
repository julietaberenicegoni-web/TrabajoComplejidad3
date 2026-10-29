/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 28/10/2026
 * Time: 12:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Command
{
	/// <summary>
	/// Description of ComandoEncenderLuz.
	/// </summary>
	public class ComandoEncenderLuz: IComando
	{
		private Luz luz;
		public ComandoEncenderLuz(Luz luz)
		{
			this.luz=luz;
		}
		
		public void Ejecutar()
		{
			luz.Encender();
			
		}
		public void Deshacer()
		{
			luz.Apagar();
		}
	}
}
