using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_18.Entidades
{
  public class DepositoDeAutos
  {
    private int _capacidadMaxima;
    private List<Auto> _lista;
    public DepositoDeAutos(int capacidad)
    {
      this._lista = new List<Auto>();
      this._capacidadMaxima = capacidad;
    }

    public bool Agregar(Auto a)
    {
      return this + a;
    }

    public bool Remover(Auto a)
    {
      return this - a;
    }

    public static bool operator +(DepositoDeAutos d, Auto a)
    {
      if(d._lista.Count < d._capacidadMaxima)
      {
        d._lista.Add(a);
        return true;
      }
      else
      {
        return false;
      }
    }

    private int GetIndice(Auto a)
    {
      return this._lista.IndexOf(a);
    }

    public static bool operator -(DepositoDeAutos d, Auto a)
    {
      int indice = d.GetIndice(a);
      if (indice > -1)
      {
        d._lista.RemoveAt(indice);
        return true;
      }
      else
      {
        return false;
      }
    }

    public override string ToString()
    {
      string retorno = "Capacidad maxima: " + this._capacidadMaxima.ToString() + "\nListado de Autos:\n";
      foreach (Auto a in this._lista)
      {
        retorno += a.ToString() + "\n";
      }
      return retorno;
    }
  }
}
