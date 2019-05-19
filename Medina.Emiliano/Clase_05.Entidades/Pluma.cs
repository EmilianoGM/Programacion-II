using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05.Entidades
{
  public class Pluma
  {
    #region Atributos
    private string _marca;
    private Tinta _tinta;
    private int _cantidad;
    #endregion
    #region Constructores
    public Pluma(): this("sin marca", null, 0)
    {

    }
    public Pluma(string marca) : this(marca, null, 0)
    {

    }
    public Pluma(string marca, Tinta tinta) : this(marca, tinta, 0)
    {

    }
    public Pluma(string marca, Tinta tinta, int cantidad)
    {
      this._marca = marca;
      this._tinta = tinta;
      this._cantidad = cantidad;
    }
    #endregion
    #region Metodos
    private string Mostrar()
    {
      return "Marca: " + this._marca + " - Cantidad: " + this._cantidad.ToString() + " - Tinta: " + Tinta.Mostrar(this._tinta);
    }
    public static bool operator == (Pluma pluma, Tinta tinta)
    {
      return pluma._tinta == tinta;
    }
    public static bool operator != (Pluma pluma, Tinta tinta)
    {
      return !(pluma == tinta);
    }
    public static explicit operator string(Pluma pluma)
    {
      return pluma.Mostrar();
    }
    public static Pluma operator + (Pluma pluma, Tinta tinta)
    {
      if(pluma == tinta)
      {
        if(pluma._cantidad + 10 > 100)
        {
          pluma._cantidad = 100;
        } else
        {
          pluma._cantidad += 10;
        }
      }
      return pluma;
    }
    #endregion
  }
}
