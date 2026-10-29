/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 27/10/2026
 * Time: 19:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Proxy
{
	/// <summary>
	/// Description of DocumentoReal.
	/// </summary>
	public class DocumentoReal: IDocumento
	{
		public DocumentoReal()
		{
			Console.WriteLine("Cargando documento...");
		}

		public string Leer(string usuario)
		{
			return "Contenido del documento confidencial";
		}
	}
}
