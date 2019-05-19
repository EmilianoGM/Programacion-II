using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05.Entidades
{
  public class Tinta
  {
    #region Atributos
    private ConsoleColor _color;
    private ETipoTinta _tipoTinta;
    #endregion
    #region Constructores
    public Tinta() : this(ConsoleColor.Black, ETipoTinta.Comun)
    {
    }
    public Tinta(ConsoleColor color) : this(color, ETipoTinta.Comun)
    {
    }
    public Tinta(ConsoleColor color, ETipoTinta tipoTinta)
    {
      this._tipoTinta = tipoTinta;
      this._color = color;
    }
    #endregion
    #region Metodos
    private string Mostrar()
    {
      return this._color.ToString() + " - " + this._tipoTinta.ToString();
    }
    public static string Mostrar(Tinta tinta)
    {
      return tinta.Mostrar();
    }
    public static bool operator == (Tinta tinta1, Tinta tinta2)
    {
      bool retorno = tinta1._color == tinta2._color && tinta1._tipoTinta == tinta2._tipoTinta;
      return retorno;
    }
    public static bool operator != (Tinta tinta1, Tinta tinta2)
    {
      return !(tinta1 == tinta2);
    }
    #endregion
  }
}
