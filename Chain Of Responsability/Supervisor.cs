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
	/// Description of Supervisor.
	/// </summary>
	public class Supervisor: AprobadorDeGastos
	{
		public override void aprobar(SolicitudDeGasto solicitud)
        {
            if (solicitud.Monto <= 1000)
            {
                Console.WriteLine("El Supervisor aprobó: " + solicitud.Descripcion);
            }
            else
            {
                base.aprobar(solicitud);
            }
        }
	}
}
