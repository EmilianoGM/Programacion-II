using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_18.Entidades
{
  public class Deposito<T>
  {
    private int _capacidadMaxima;
    private List<T> _lista;
    public Deposito(int capacidad)
    {
      this._lista = new List<T>();
      this._capacidadMaxima = capacidad;
    }

    public bool Agregar(T a)
    {
      return this + a;
    }

    public bool Remover(T a)
    {
      return this - a;
    }

    public static bool operator +(Deposito<T> d, T a)
    {
      if (d._lista.Count < d._capacidadMaxima)
      {
        d._lista.Add(a);
        return true;
      }
      else
      {
        return false;
      }
    }

    private int GetIndice(T a)
    {
      return this._lista.IndexOf(a);
    }

    public static bool operator -(Deposito<T> d, T a)
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
      foreach (T a in this._lista)
      {
        retorno += a.ToString() + "\n";
      }
      return retorno;
    }
  }
}
