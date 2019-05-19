using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_15.Entidades
{
  public static class ParseadoraDeEnteros
  {
    public static bool TryParse(string datoIngresado, out int numeroDevuelto)
    {
      try
      {
        int AuxNumero = ParseadoraDeEnteros.Parse(datoIngresado);
        numeroDevuelto = AuxNumero;
        return true;
      } catch(ErrorParserException exception)
      {
        Console.WriteLine(exception.Message);
        numeroDevuelto = 0;
        return false;
      }
    }

    private static int Parse(string datoIngresado)
    {
      try
      {
        int auxNumero = int.Parse(datoIngresado);
        return auxNumero;
      }
      catch (FormatException exception)
      {
        throw new ErrorParserException(" por error de formato.", exception);
      }
      catch (OverflowException exception)
      {
        throw new ErrorParserException(" por tamaño del dato", exception);
      }
    }
  }
}
