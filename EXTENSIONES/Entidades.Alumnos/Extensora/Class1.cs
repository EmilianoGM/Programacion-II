using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa.Sellada;

namespace Extensora
{
  public static class Extensora
  {
    public static string Mostrar(this PersonaExternaSellada p)
    {
      return p.Nombre;
    }
  }
}
