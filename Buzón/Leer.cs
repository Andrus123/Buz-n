/*
 * Created by SharpDevelop.
 * User: Carmen Rosa
 * Date: 25/09/2007
 * Time: 09:35 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
class Leer {
        /// Lee un string
        /// <returns>una cadena leida por consola</returns>
        public static string Cadena() {
            return Console.ReadLine();
        }
       
        /// Lee un dato short (Int16)
        /// <returns>un short leida por consola</returns>
        public static short Short() {
            short dato = 0;
            try {
                dato = short.Parse(Console.ReadLine());
            }
            catch( OverflowException ) {
                Console.WriteLine("El numero esta por encima del limite del tipo de dato Short, asignado por defecto 0");
            }
            catch( ArgumentException ) {
                Console.WriteLine("Introdusca un numero valido, asignado por defecto 0");
            }
            catch( FormatException ) {
                Console.WriteLine("Formato no valido, asignado por defecto 0");
            }
            return dato;
        }
        /// Lee un dato int (Int32)
        /// <returns>un int leida por consola</returns>
        public static int Integer() {
            int dato = 0;
            try {
                dato = int.Parse(Console.ReadLine());
            }
            catch( OverflowException ) {
                Console.WriteLine("El numero esta por encima del limite del tipo de dato int, asignado por defecto 0");
            }
            catch( ArgumentException ) {
                Console.WriteLine("Introdusca un numero valido, asignado por defecto 0");
            }
            catch( FormatException ) {
                Console.WriteLine("Formato no valido, asignado por defecto 0");
            }
            return dato;
        }
        /// Lee un dato long (Int64)
        /// <returns>un long leida por consola</returns>
        public static long Long() {
            long dato = 0;
            try {
                dato = long.Parse(Console.ReadLine());
            }
            catch( OverflowException ) {
                Console.WriteLine("El numero esta por encima del limite del tipo de dato Long, asignado por defecto 0");
            }
            catch( ArgumentException ) {
                Console.WriteLine("Introdusca un numero valido, asignado por defecto 0");
            }
            catch( FormatException ) {
                Console.WriteLine("Formato no valido, asignado por defecto 0");
            }
            return dato;
        }
        /// Lee un dato float (precision de 7 digitos) ±1,5e-45 a ±3,4e38
        /// <returns>un float leido por consola</returns>
        public static float Float() {
            float dato = 0;
            try {
                dato = float.Parse(Console.ReadLine());
            }
            catch( ArgumentException ) {
                Console.WriteLine("Introdusca un numero valido, asignado por defecto 0");
            }
            catch( FormatException ) {
                Console.WriteLine("Formato no valido, asignado por defecto 0");
            }
            return dato;
        }
        /// Lee un dato double (precision de 15 digitos) ±5,0e-324 a ±1,7e308
        /// <returns>un double leido por consola</returns>
        public static double Double() {
            double dato = 0;
            try {
                dato = double.Parse(Console.ReadLine());
            }
            catch( ArgumentException ) {
                Console.WriteLine("Introdusca un numero valido, asignado por defecto 0");
            }
            catch( FormatException ) {
                Console.WriteLine("Formato no valido, asignado por defecto 0");
            }
            catch( OverflowException ) {
                Console.WriteLine("El numero esta por encima del limite del tipo de dato double, asignado por defecto 0");
            }
            return dato;
        }
        /// Lee un dato double (precision de 28-29 dígitos)
        /// <returns>un decimal leido por consola</returns>
        public static decimal Decimal() {
            decimal dato = 0;
            try {
                dato = decimal.Parse(Console.ReadLine());
            }
            catch( ArgumentException ) {
                Console.WriteLine("Introdusca un numero valido, asignado por defecto 0");
            }
            catch( FormatException ) {
                Console.WriteLine("Formato no valido, asignado por defecto 0");
            }
            catch( OverflowException ) {
                Console.WriteLine("El numero esta por encima del limite del tipo de dato Decimal, asignado por defecto 0");
            }
            return dato;
        }
}
