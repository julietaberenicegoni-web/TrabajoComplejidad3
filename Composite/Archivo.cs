/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 28/10/2026
 * Time: 13:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Composite
{
	/// <summary>
	/// Description of Archivo.
	/// </summary>
	public class Archivo: IElementoSistemaArchivos
	{
		private string nombre;
		private int tamanoFijo;
		public Archivo(string nombre, int tamanoFijo)
		{
			this.nombre=nombre;
			this.tamanoFijo=tamanoFijo;
		}
		
		public int obtenerTamano()
		{
			return tamanoFijo;
		}
		public void mostrar(int nivelIdentacion)
		{
			Console.WriteLine("{0}{1}",  new string(' ', nivelIdentacion * 2), this.nombre);
		}
	}
}
