/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 28/10/2026
 * Time: 14:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Chain_Of__Responsability
{
	/// <summary>
	/// Description of SolicitudDegasto.
	/// </summary>
	public class SolicitudDeGasto
	{
		private double monto;
		private string descripcion;
		
		public double Monto
		{
			get {return monto;}
			set {value=monto;}
		}
		public string Descripcion
		{
			get {return descripcion;}
			set {value=descripcion;}
		}
		public SolicitudDeGasto(double monto, string descripcion)
		{
			this.monto=monto;
			this.descripcion=descripcion;
		}
	}
}
