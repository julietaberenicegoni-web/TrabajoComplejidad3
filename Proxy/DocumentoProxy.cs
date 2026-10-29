/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 27/10/2026
 * Time: 19:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Proxy
{
	/// <summary>
	/// Description of DocumentoProxy.
	/// </summary>
	public class DocumentoProxy: IDocumento
	{
		private DocumentoReal documento;
		public DocumentoProxy()
		{
		}
		public string Leer (string usuario)
		{
			if (usuario != "admin")
			{
				return "Acceso denegado";
			}

			if (documento == null)
			{
				documento = new DocumentoReal();
			}

			return documento.Leer(usuario);
		}
	}
}
