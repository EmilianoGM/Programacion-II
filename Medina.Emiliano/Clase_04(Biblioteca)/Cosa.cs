using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_04.Entidades
{
  public class Cosa
  {
    #region Ätributos
    public int entero;
    public string cadena;
    public DateTime fecha;
    #endregion
    #region Constructores
    public Cosa()
    {
      this.entero = 10;
      this.cadena = "Sin valor";
      this.fecha = DateTime.Now;
    }
    public Cosa(int nuevoEntero) : this()
    {
      this.entero = nuevoEntero;
    }
    public Cosa(int nuevoEntero, DateTime nuevaFecha) : this(nuevoEntero)
    {
      this.fecha = nuevaFecha;
    }
    public Cosa(int nuevoEntero, DateTime nuevaFecha, string nuevaCadena) : this(nuevoEntero, nuevaFecha)
    {
      this.cadena = nuevaCadena;
    }
    #endregion
    #region Metodos
    public string Mostrar()
    {
      return this.entero.ToString() + " - " + this.cadena + " - " + this.fecha.ToString();
    }
    public static string Mostrar(Cosa cosa)
    {
      return cosa.Mostrar();
    }
    public void EstablecerValor(int nuevoEntero)
    {
      this.entero = nuevoEntero;
    }
    public void EstablecerValor(string nuevaCadena)
    {
      this.cadena = nuevaCadena;
    }
    public void EstablecerValor(DateTime nuevaFecha)
    {
      this.fecha = nuevaFecha;
    }
    #endregion
  }
}
