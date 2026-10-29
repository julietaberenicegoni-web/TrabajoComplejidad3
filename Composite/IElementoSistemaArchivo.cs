/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 28/10/2026
 * Time: 13:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Composite
{
	/// <summary>
	/// Description of IElementoSistemaArchivos.
	/// </summary>
	public interface IElementoSistemaArchivos
	{
		int obtenerTamano();
		void mostrar(int nivelIdentacion);
	}
}
