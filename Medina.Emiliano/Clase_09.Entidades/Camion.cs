using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
  public class Camion : Vehiculo
  {
    public double _tara;

    public Camion(string patente, byte cantidadRuedas, EMarca marca, double tara) : base(patente, cantidadRuedas, marca)
    {
      this._tara = tara;
    }
    /*
    public string MostrarCamion()
    {
      return base.Mostrar() + " - " + this._tara.ToString();
    }
    */

    /*---Clase_10---*/

    public override string ToString()
    {
      return base.ToString() + " - " + this._tara.ToString();
    }

    public override double Precio { get; set; }
    public override double CalcularPrecioConIVA()
    {
      return this.Precio + (this.Precio * 0.021);
    }
  }
}
