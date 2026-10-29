/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 28/10/2026
 * Time: 22:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Singleton
{
	/// <summary>
	/// Description of ConfiguracionDelSistema.
	/// </summary>
	public class ConfiguracionDelSistema
	{
		private static ConfiguracionDelSistema instancia;

		private Dictionary<string, string> valores;

		private ConfiguracionDelSistema()
		{
			valores = new Dictionary<string, string>();
		}

		public static ConfiguracionDelSistema obtenerInstancia()
		{
			if (instancia == null)
			{
				instancia = new ConfiguracionDelSistema();
			}

			return instancia;
		}

		public void establecerValor(string clave, string valor)
		{
			valores[clave] = valor;
		}

		public string obtenerValor(string clave)
		{
			if (valores.ContainsKey(clave))
			{
				return valores[clave];
			}

			return null;
		}
	}
}
