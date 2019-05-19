using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "hola";
            Sello.color = ConsoleColor.Red;
            Console.WriteLine(Sello.Imprimir());
            Sello.ImprimirEnColor();
            Console.WriteLine(Sello.Imprimir());
            Sello.Borrar();
            Console.WriteLine(Sello.Imprimir());
            Console.ReadKey();
        }
    }
}
