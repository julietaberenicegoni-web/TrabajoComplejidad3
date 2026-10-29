/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 27/10/2026
 * Time: 16:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TrabajoPracticoN3.Adapter
{
	/// <summary>
	/// Description of ReproductorMp3.
	/// </summary>
	public class ReproductorMp3: IReproductor
	{
		public ReproductorMp3()
		{
		}
		public void reproducir(string archivo)
		{
			Console.WriteLine("Reproduciendo archivo MP3: {0}", archivo);
		}
	}
}
