using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introducir algo: ");
            string introUsuario = System.Console.ReadLine();
            System.Console.WriteLine("Usted introdujo: {0}", introUsuario);
            Console.ReadKey();
        }
    }

}
