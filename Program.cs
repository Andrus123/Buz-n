/*
 * Creado por SharpDevelop.
 * Usuario: andru
 * Fecha: 31/3/2021
 * Hora: 19:28
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Buzón
{
	class Program
	{
		public static void Main(string[] args)
		{
			Buzón b1 = new Buzón();
			Buzón b2 = new Buzón();
			b1.Mostrar();
			b2.leer();
			b1.Mostrar("01/06/16");
			
			b1.Contar("España");
			b2.Contar("Peru");
			
			b1.Mostrar(b1,b2);
		
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}