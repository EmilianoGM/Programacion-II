using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_04.Entidades;

namespace Clase_04.Test
{
  class Program
  {
    static void Main(string[] args)
    {
      Cosa nuevaCosa = new Cosa();
      nuevaCosa.EstablecerValor(3);
      nuevaCosa.EstablecerValor("Hola");
      nuevaCosa.EstablecerValor(DateTime.Now);
      Console.WriteLine(nuevaCosa.Mostrar());
      Cosa nuevaCosaDos = new Cosa(15);
      Console.WriteLine(Cosa.Mostrar(nuevaCosaDos));
      Cosa nuevaCosaTres = new Cosa(4, new DateTime(2014, 2, 1));
      Console.WriteLine(Cosa.Mostrar(nuevaCosaTres));
      Cosa nuevaCosaCuatro = new Cosa(7, new DateTime(2014, 2, 1), "Hola de nuevo");
      Console.WriteLine(nuevaCosaCuatro.Mostrar());
      Console.ReadLine();
    }
  }
}
