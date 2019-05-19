using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    public class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;
        public static string Imprimir()
        {
            //return Sello.mensaje; //se agrega la clase
            return ArmarFormatoMensaje(Sello.mensaje);  
        }
        public static void Borrar()
        {
            Sello.mensaje = "";  //se agrega la clase
        }
        public static void ImprimirEnColor()
        {
            ConsoleColor colorAnterior = Console.ForegroundColor;
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
            Console.ForegroundColor = colorAnterior;
        }
        private static string ArmarFormatoMensaje(string nuevoMensaje)
        {
            string primerFila = "*";
            for(int i = 0; i < nuevoMensaje.Length; i++)
            {
                primerFila += "*";
            }
            primerFila += "*\n";
            string segundaFila = "*" + nuevoMensaje + "*\n";
            nuevoMensaje = primerFila + segundaFila + primerFila;
            return nuevoMensaje;
        }
    }
}
