/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 26/10/2026
 * Time: 18:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using TrabajoPracticoN3.Adapter;

namespace TrabajoPracticoN3
{
	class Program
	{
		public static void Main(string[] args)
		{
			ReproductorMp3 RepMp3= new ReproductorMp3();
			ReproductorAvanzadoExterno RepAE= new ReproductorAvanzadoExterno();
			AdaptadorReproductorAvanzado adaptador= new AdaptadorReproductorAvanzado(RepAE);
			
			ReproducirArchivo(RepMp3, "archivo.mp3");
			ReproducirArchivo(adaptador, "archivo.avi");
			ReproducirArchivo(adaptador, "archivo.mp4");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void ReproducirArchivo( IReproductor reproductor, string archivo)
		{
			reproductor.reproducir(archivo);
		}
	}
}