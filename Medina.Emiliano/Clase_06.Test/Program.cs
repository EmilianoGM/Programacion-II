using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_06.Entidades;

namespace Clase_06.Test
{
  class Program
  {
    static void Main(string[] args)
    {
      Tempera nuevaTempera = new Tempera(ConsoleColor.Red, "Faber", 10);
      Tempera nuevaTemperaDos = new Tempera(ConsoleColor.Black, "Faber", 5);
      Tempera nuevaTemperaTres = new Tempera(ConsoleColor.Blue, "Faber", 7);
      Paleta nuevaPaleta = 2;
      nuevaPaleta = nuevaPaleta + nuevaTempera;
      nuevaPaleta = nuevaPaleta + nuevaTemperaDos;
      nuevaPaleta = nuevaPaleta + nuevaTemperaTres;
      Console.WriteLine((string)nuevaPaleta);
      Console.ReadKey();
    }
  }
}
