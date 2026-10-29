/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 28/10/2026
 * Time: 14:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Chain_Of__Responsability
{
	/// <summary>
	/// Description of Director.
	/// </summary>
	public class Director: AprobadorDeGastos
	{
		public override void aprobar(SolicitudDeGasto solicitud)
        {
            Console.WriteLine("El Director aprobó: " + solicitud.Descripcion);
        }

	}
}
