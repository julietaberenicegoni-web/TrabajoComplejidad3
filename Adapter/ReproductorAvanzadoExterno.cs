/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 27/10/2026
 * Time: 17:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TrabajoPracticoN3.Adapter
{
	/// <summary>
	/// Description of ReproductorAvanzadoExterno.
	/// </summary>
	public class ReproductorAvanzadoExterno
	{
		public ReproductorAvanzadoExterno()
		{
		}
		public void ReproducirArchivoAVI(string archivo)
		{
			Console.WriteLine("Reproduciendo archivo AVI: {0}", archivo);
		}
		public void ReproducirArchivoMp4(string archivo)
		{
			Console.WriteLine("Reproduciendo archivo MP4: {0}", archivo);
		}
	}
}
