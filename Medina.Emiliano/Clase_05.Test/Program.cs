using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_05.Entidades;

namespace Clase_05.Test
{
  class Program
  {
    static void Main(string[] args)
    {
      /* Parte 1 */
      Tinta tinta1 = new Tinta();
      Tinta tinta2 = new Tinta(ConsoleColor.Green);
      Tinta tinta3 = new Tinta(ConsoleColor.Red, ETipoTinta.ConBrillito);
      /*-----*/
      /* Parte 2 */
      Tinta tinta4 = new Tinta();
      if (tinta1.Equals(tinta4))
      {
        Console.WriteLine("Son iguales");
      } else
      {
        Console.WriteLine("No son iguales");
      }
      if (tinta1 == tinta4)
      {
        Console.WriteLine("Sobrecarga de operador: Son iguales");
      }
      else
      {
        Console.WriteLine("Sobrecarga de operador: No son iguales");
      }
      /*-----*/
      /* Parte 3*/
      Pluma pluma1 = new Pluma("Bic", tinta3, 30);
      pluma1 = pluma1 + tinta3;
      Console.WriteLine((string)pluma1);
      /* Parte 1 */
      /*
      Console.WriteLine(Tinta.Mostrar(tinta1));
      Console.WriteLine(Tinta.Mostrar(tinta2));
      Console.WriteLine(Tinta.Mostrar(tinta3));
      */
      /*-----*/
      Console.ReadKey();
    }
  }
}
