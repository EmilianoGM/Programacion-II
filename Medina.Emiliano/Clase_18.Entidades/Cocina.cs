using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_18.Entidades
{
  public class Cocina
  {
    private int _codigo;
    private bool _esIndustrial;
    private double _precio;

    public int Codigo
    {
      get
      {
        return this._codigo;
      }
    }

    public bool EsIndustrial
    {
      get
      {
        return this._esIndustrial;
      }
    }

    public double Precio
    {
      get
      {
        return this._precio;
      }
    }

    public Cocina(int codigo, double precio, bool esIndustrial)
    {
      this._codigo = codigo;
      this._esIndustrial = esIndustrial;
      this._precio = precio;
    }

    public static bool operator ==(Cocina a, Cocina b)
    {
      if(a._codigo == b._codigo)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public static bool operator !=(Cocina a, Cocina b)
    {
      return !(a == b);
    }

    public override string ToString()
    {
      return "Codigo: " + this._codigo.ToString() + " - Precio: " + this._precio.ToString() + " - Es industrial? " + this._esIndustrial.ToString();
    }

    public override bool Equals(object obj)
    {
      if(obj is Cocina)
      {
        return this == (Cocina)obj;
      }
      else
      {
        return false;
      }
    }
  }
}
