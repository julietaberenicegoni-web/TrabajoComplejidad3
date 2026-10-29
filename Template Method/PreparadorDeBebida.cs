/*
 * Created by SharpDevelop.
 * User: Julieta Goñi
 * Date: 28/10/2026
 * Time: 14:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Template_Method
{
	/// <summary>
	/// Description of PreparadorDeBebida.
	/// </summary>
	public abstract class PreparadorDeBebida
	{
		public void prepararBebida()
        {
            hervirAgua();
            agregarBaseDeSaborizante();
            verterEnTaza();
            agregarCondimentos();
        }

        public void hervirAgua()
        {
            Console.WriteLine("Hirviendo agua...");
        }

        public abstract void agregarBaseDeSaborizante();

        public void verterEnTaza()
        {
            Console.WriteLine("Vertiendo en la taza...");
        }

        public virtual void agregarCondimentos()
        {
            Console.WriteLine("Agregando condimentos por defecto...");
        }
	}
}
