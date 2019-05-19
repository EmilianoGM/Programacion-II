using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_15.Entidades
{
  public class ErrorParserException : Exception
  {
    public ErrorParserException(string mensaje, Exception exception) : base("El string no podra ser convertido" + mensaje, exception)
    { }
  }
}
