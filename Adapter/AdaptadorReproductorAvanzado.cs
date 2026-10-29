/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 27/10/2026
 * Time: 17:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TrabajoPracticoN3.Adapter
{
	/// <summary>
	/// Description of AdaptadorReproductorAvanzado.
	/// </summary>
	public class AdaptadorReproductorAvanzado: IReproductor
	{
		public ReproductorAvanzadoExterno reproductor;
		public AdaptadorReproductorAvanzado(ReproductorAvanzadoExterno reproductor)
		{
			this.reproductor=reproductor;
		}
		
		public void reproducir( string archivo)
		{
			string tipo = archivo.Substring(archivo.Length - 4);

			if (tipo == ".avi")
			{
				reproductor.ReproducirArchivoAVI(archivo);
			}
			else if (tipo == ".mp4")
			{
				reproductor.ReproducirArchivoMp4(archivo);
			}
		}
	}
}
