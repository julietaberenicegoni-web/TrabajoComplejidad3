/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 28/10/2026
 * Time: 14:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Template_Method
{
	/// <summary>
	/// Description of PreparadorDeTe.
	/// </summary>
	public class PreparadorDeTe: PreparadorDeBebida
	{
		public override void agregarBaseDeSaborizante()
        {
            Console.WriteLine("Agregando té...");
        }

        public override void agregarCondimentos()
        {
            Console.WriteLine("Agregando miel y limón...");
        }
	}
}
