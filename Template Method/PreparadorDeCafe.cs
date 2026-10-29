/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 28/10/2026
 * Time: 14:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Template_Method
{
	/// <summary>
	/// Description of PreparadorDeCafe.
	/// </summary>
	public class PreparadorDeCafe: PreparadorDeBebida
	{
		public override void agregarBaseDeSaborizante()
        {
            Console.WriteLine("Agregando café...");
        }
	}
}
