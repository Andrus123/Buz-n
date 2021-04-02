/*
 * Creado por SharpDevelop.
 * Usuario: andru
 * Fecha: 31/3/2021
 * Hora: 19:30
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Buzón
{
	/// <summary>
	/// Description of Buzón.
	/// </summary>
	public class Buzón
	{
		private int Numero_Mensajes;
		private string[,] Mensaje = new string[50, 3];
		public Buzón()
		{
			this.Numero_Mensajes = 3;
			Mensaje[0, 0] = "España"; Mensaje[0, 1] = "02/02/16"; Mensaje[0, 2] = "Hola :)";
			Mensaje[1, 0] = "Bolivia"; Mensaje[1, 1] = "03/08/16"; Mensaje[1, 2] = "Te extraño:(";
			Mensaje[2, 0] = "Argentina"; Mensaje[2, 1] = "01/06/16"; Mensaje[2, 2] = "Gracias por todo ^_^";
		}
		
		public Buzón(int nmensj)
		{
			this.Numero_Mensajes = nmensj;
			for (int i = 0; i < 50; i++) {
				for (int j = 0; j < 3; j++) {
					Mensaje[i, j] = " ";
				}
			}
		}
		
		public void leer()
		{
			Console.WriteLine("Cantidad de Mensajes: ");
			this.Numero_Mensajes = Leer.Integer();
			for (int i = 0; i < getNumero_Mensajes(); i++) {
				for (int j = 0; j < 3; j++) {
					if (j == 0) {
						Console.WriteLine("Origen: ");
					}
					if (j == 1) {
						Console.WriteLine("Fecha: ");
					}
					if (j == 2) {
						Console.WriteLine("Texto: ");
					}
					Mensaje[i, j] = Leer.Cadena();
				}
			}
		}
		
		public void Mostrar()
		{
			Console.WriteLine("Cantidad de Mensajes: " + getNumero_Mensajes());
			Console.WriteLine("Pais:       Fecha:       Texto:    ");
			for (int i = 0; i < getNumero_Mensajes(); i++) {
				Console.WriteLine(getMensaje(i, 0) + "    " + getMensaje(i, 1) + "   " + getMensaje(i, 2));
			}
		}
		
		//Getters y Setters
		public int getNumero_Mensajes()
		{
			return Numero_Mensajes;
		}
		public void setNumero_Mensajes(int nmensj)
		{
			this.Numero_Mensajes = nmensj;
		}
		public String[,] getMensaje()
		{
			return Mensaje;
		}
		public String getMensaje(int i, int j)
		{
			return Mensaje[i, j];
		}
		public void setMensaje(String[,] Mensaje)
		{
			this.Mensaje = Mensaje;
		}
		public void setMensaje(int i, int j, String m)
		{
			this.Mensaje[i, j] = m;
		}
		//Mostrar los mensajes recibidos en la fecha x
		public void Mostrar(string x)
		{
			bool sw = true;
			for (int i = 0; i < getNumero_Mensajes(); i++) {
				if (x == Mensaje[i, 1]) {
					Console.WriteLine("Mensaje: " + getMensaje(i, 2));
					sw = false;
				}
			}
			if (sw)
				Console.WriteLine("No hay Mensajes Recibidos");
		}
		//Contar los mensajes recibidos cuyo origen sea x
		public void Contar(string x)
		{
			int c = 0;
			for (int i = 0; i < getNumero_Mensajes(); i++) {
				if (x == Mensaje[i, 0]) {
					c++;
				}
			}
			Console.WriteLine("Hay " + c + " mensajes provenientes de : " + x);
		}
		//Sean 2 Buzones mostrar el que tenga la mayor cantidad de mensajes
		public void Mostrar(Buzón b1, Buzón b2)
		{
			if (b1.getNumero_Mensajes() > b2.getNumero_Mensajes()) {
				b1.Mostrar();
			}
			if (b1.getNumero_Mensajes() < b2.getNumero_Mensajes()) {
				b2.Mostrar();
			}
		}
	}
}
