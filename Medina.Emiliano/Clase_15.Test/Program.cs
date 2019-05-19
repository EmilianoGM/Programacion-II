using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_15.Entidades;

namespace Clase_15.Test
{
  class Program
  {
    static void Main(string[] args)
    {
      bool flag;
      int numero;
      Console.WriteLine("Escriba un numero:");
      flag = ParseadoraDeEnteros.TryParse(Console.ReadLine(), out numero);
      if (flag)
      {
        Console.WriteLine("Su numero es {0}", numero);
      }
      Console.ReadKey();
    }
  }
}
