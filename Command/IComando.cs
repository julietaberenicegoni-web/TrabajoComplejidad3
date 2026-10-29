/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 27/10/2026
 * Time: 21:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Command
{
	/// <summary>
	/// Description of IComando.
	/// </summary>
	public interface IComando
	{
		void Ejecutar();
		void Deshacer();
	}
}
