using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_18.Entidades
{
  public class DepositoDeCocinas
  {
    private int _capacidadMaxima;
    private List<Cocina> _lista;
    public DepositoDeCocinas(int capacidad)
    {
      this._lista = new List<Cocina>();
      this._capacidadMaxima = capacidad;
    }

    public bool Agregar(Cocina c)
    {
      return this + c;
    }

    public bool Remover(Cocina c)
    {
      return this - c;
    }

    public static bool operator +(DepositoDeCocinas d, Cocina c)
    {
      if (d._lista.Count < d._capacidadMaxima)
      {
        d._lista.Add(c);
        return true;
      }
      else
      {
        return false;
      }
    }

    private int GetIndice(Cocina c)
    {
      return this._lista.IndexOf(c);
    }

    public static bool operator -(DepositoDeCocinas d, Cocina c)
    {
      int indice = d.GetIndice(c);
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
      string retorno = "Capacidad maxima: " + this._capacidadMaxima.ToString() + "\nListado de Cocinass:\n";
      foreach(Cocina c in this._lista)
      {
        retorno += c.ToString() + "\n";
      }
      return retorno;
    }
  }
}
