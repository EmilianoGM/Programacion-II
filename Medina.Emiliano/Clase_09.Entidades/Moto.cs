using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
  public class Moto : Vehiculo
  {
    public double _cilindrada;
    public Moto(string patente, byte cantidadRuedas, EMarca marca, double cilindrada) : base(patente, cantidadRuedas, marca)
    {
      this._cilindrada = cilindrada;
    }
    /*
    public string MostrarMoto()
    {
      return base.Mostrar() + " - " + this._cilindrada.ToString();
    }
    */

    /*---Clase_10---*/

    public override string ToString()
    {
      return base.ToString() + " - " + this._cilindrada.ToString();
    }

    public override double Precio { get; set; }
    public override double CalcularPrecioConIVA()
    {
      return this.Precio + (this.Precio * 0.021);
    }
  }
}
