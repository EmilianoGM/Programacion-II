using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
  public abstract class Vehiculo
  {
    protected string _patente;
    protected byte _cantidadRuedas;

    protected EMarca _marca;

    public EMarca Marca
    {
      get { return _marca; }
    }

    public Vehiculo(string patente, byte cantidadRuedas, EMarca marca)
    {
      this._patente = patente;
      this._cantidadRuedas = cantidadRuedas;
      this._marca = marca;
    }

    /*
    protected string Mostrar()
    {
      return this._patente + " - " + this._cantidadRuedas.ToString() + " - " + this.Marca.ToString();
    }
    */
    public static bool operator == (Vehiculo vehiculoUno, Vehiculo vehiculoDos)
    {
      return (vehiculoUno._patente.Equals(vehiculoDos._patente) && vehiculoUno._marca == vehiculoDos._marca);
    }

    public static bool operator != (Vehiculo vehiculoUno, Vehiculo vehiculoDos)
    {
      return !(vehiculoUno == vehiculoDos);
    }

    /*---Clase_10---*/
    public override string ToString()
    {
      return this._patente + " - " + this._cantidadRuedas.ToString() + " - " + this.Marca.ToString();
    }

    public abstract double Precio { get; set; }

    public abstract double CalcularPrecioConIVA();
  } 
}
