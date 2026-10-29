/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 28/10/2026
 * Time: 12:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Command
{
	/// <summary>
	/// Description of ControlRemoto.
	/// </summary>
	public class ControlRemoto
	{
		private IComando ultimoComando;

		public void ejecutar(IComando comando)
		{
			comando.Ejecutar();
			ultimoComando = comando;
		}

		public void deshacerUltimo()
		{
			if (ultimoComando != null)
			{
				ultimoComando.Deshacer();
				ultimoComando = null;
			}
		}
	}
}
