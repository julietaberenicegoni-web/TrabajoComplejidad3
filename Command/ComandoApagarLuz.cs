/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 28/10/2026
 * Time: 12:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Command
{
	/// <summary>
	/// Description of ComandoApagarLuz.
	/// </summary>
	public class ComandoApagarLuz: IComando
	{
		private Luz luz;
		public ComandoApagarLuz(Luz luz)
		{
			this.luz=luz;
		}
		
		public void Ejecutar()
		{
			luz.Apagar();
		}
		public void Deshacer()
		{
			luz.Encender();
		}
	}
}
