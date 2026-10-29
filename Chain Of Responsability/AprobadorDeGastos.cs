/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 28/10/2026
 * Time: 14:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Chain_Of__Responsability
{
	/// <summary>
	/// Description of AprobadorDeGastos.
	/// </summary>
	public abstract class AprobadorDeGastos
	{
		protected AprobadorDeGastos sucesor;

        public void EstablecerSucesor(AprobadorDeGastos siguiente)
        {
            sucesor = siguiente;
        }

        public virtual void aprobar(SolicitudDeGasto solicitud)
        {
            if (sucesor != null)
            {
                sucesor.aprobar(solicitud);
            }
            else
            {
                Console.WriteLine("Nadie pudo aprobar la solicitud.");
            }
        }
	}
}
