using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
  public class Auto : Vehiculo
  {
    protected int _cantidadAsientos;

    public Auto(string patente, byte cantidadRuedas, EMarca marca, int cantidadAsientos) : base(patente, cantidadRuedas, marca)
    {
      this._cantidadAsientos = cantidadAsientos;
    }

    /*
    public string MostrarAuto()
    {
      return base.Mostrar() + " - " + this._cantidadAsientos.ToString();
    }
    */

    /*---Clase_10---*/

    public override string ToString()
    {
      return base.ToString() + " - " + this._cantidadAsientos.ToString();
    }

    public override double Precio { get; set; }
    public override double CalcularPrecioConIVA()
    {
      return this.Precio + (this.Precio * 0.021);
    }
  }
}
