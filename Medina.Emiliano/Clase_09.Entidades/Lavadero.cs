using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
  public class Lavadero
  {
    private float _precioAuto;
    private float _precioCamion;
    private float _precioMoto;

    private List<Vehiculo> _vehiculos;

    public List<Vehiculo> MisVehiculos
    {
      get { return _vehiculos; }
    }

    public string MiLavadero
    {
      get {
        string retorno = "Precios vigentes:\nAuto: " + this._precioAuto.ToString() + " - Camion: " + this._precioCamion.ToString();
        retorno += " - Moto: " + this._precioMoto.ToString() + "\nVehiculos:\n";
        foreach(Vehiculo vehiculo in this.MisVehiculos)
        {
          retorno += vehiculo.ToString() + "\n";
        }
        return retorno;
      }
    }

    private Lavadero()
    {
      this._vehiculos = new List<Vehiculo>();
    }

    public Lavadero(float precioAuto, float precioCamion, float precioMoto) : this()
    {
      this._precioAuto = precioAuto;
      this._precioCamion = precioCamion;
      this._precioMoto = precioMoto;
    }

    public static bool operator ==(Lavadero lavadero, Vehiculo vehiculo)
    {
      return lavadero.MisVehiculos.Contains(vehiculo);
    }

    public static bool operator !=(Lavadero lavadero, Vehiculo vehiculo)
    {
      return !(lavadero == vehiculo);
    }

    public static Lavadero operator +(Lavadero lavadero, Vehiculo vehiculo)
    {
      if (lavadero != vehiculo)
      {
        lavadero.MisVehiculos.Add(vehiculo);
      }
      return lavadero;
    }

    public static Lavadero operator -(Lavadero lavadero, Vehiculo vehiculo)
    {
      if (lavadero == vehiculo)
      {
        lavadero.MisVehiculos.Remove(vehiculo);
      }
      return lavadero;
    }

    public double MostrarTotalFacturado()
    {
      double retorno = 0;
      foreach (Vehiculo vehiculo in this.MisVehiculos)
      {
        if (vehiculo is Auto)
        {
          retorno += this._precioAuto;
        }
        else if (vehiculo is Camion)
        {
          retorno += this._precioCamion;
        }
        else if (vehiculo is Moto)
        {
          retorno += this._precioMoto;
        }
      }
      return retorno;
    }

    public double MostrarTotalFacturado(EVehiculos eVehiculos)
    {
      double retorno = 0;
      if (eVehiculos == EVehiculos.Auto)
      {
        foreach (Vehiculo vehiculo in this.MisVehiculos)
        {
          if (vehiculo is Auto)
          {
            retorno += this._precioAuto;
          }
        }
      }
      else if (eVehiculos == EVehiculos.Camion)
      {
        foreach (Vehiculo vehiculo in this.MisVehiculos)
        {
          if (vehiculo is Camion)
          {
            retorno += this._precioCamion;
          }
        }
      }
      else if (eVehiculos == EVehiculos.Moto)
      {
        foreach (Vehiculo vehiculo in this.MisVehiculos)
        {
          if (vehiculo is Moto)
          {
            retorno += this._precioMoto;
          }
        }
      }
      return retorno;
    }

    public static int OrdenarVehiculosPorPatente(Vehiculo vehiculoUno, Vehiculo vehiculoDos)
    {
      return String.Compare(vehiculoUno.ToString(), vehiculoDos.ToString());
    }

    public int OrdenarVehiculosPorMarca(Vehiculo vehiculoUno, Vehiculo vehiculoDos)
    {
      return vehiculoUno.Marca.CompareTo(vehiculoDos.Marca);
    }
  }
}
