/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 28/10/2026
 * Time: 13:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Composite
{
	/// <summary>
	/// Description of Carpeta.
	/// </summary>
	public class Carpeta: IElementoSistemaArchivos
	{
		private string nombre;
		private List<IElementoSistemaArchivos> elementos;

		public Carpeta(string nombre)
		{
			this.nombre = nombre;
			elementos = new List<IElementoSistemaArchivos>();
		}

		public void agregar(IElementoSistemaArchivos elemento)
		{
			elementos.Add(elemento);
		}

		public int obtenerTamano()
		{
			int total = 0;

			foreach (IElementoSistemaArchivos elemento in elementos)
			{
				total += elemento.obtenerTamano();
			}

			return total;
		}

		public void mostrar(int nivelDeIndentacion)
		{
			Console.WriteLine(new string(' ', nivelDeIndentacion * 2) + this.nombre);

			foreach (IElementoSistemaArchivos elemento in elementos)
			{
				elemento.mostrar(nivelDeIndentacion + 1);
			}
		}
	}
}
