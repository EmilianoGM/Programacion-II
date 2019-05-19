using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_06.Entidades
{
  public class Tempera
  {
    private ConsoleColor _color;
    public ConsoleColor MiColor
    {
      get { return _color; }
    }
    private string _marca;
    public string MiMarca
    {
      get { return _marca; }
    }
    private sbyte _cantidad;

    public Tempera(ConsoleColor color, string marca, sbyte cantidad)
    {
      this._color = color;
      this._marca = marca;
      this._cantidad = cantidad;
    }
    private string Mostrar()
    {
      return this._color.ToString() + " - " + this._marca + " - " + this._cantidad;
    }
    public static string Mostrar(Tempera tempera)
    {
      return tempera.Mostrar();
    }
    public static bool operator ==(Tempera temperaUno, Tempera temperaDos)
    {
      if (Tempera.Equals(temperaUno, null) && Tempera.Equals(temperaDos, null))
      {
        return true;
      }
      else if ((Tempera.Equals(temperaUno, null) && Tempera.Equals(temperaDos, null) == false) || (Tempera.Equals(temperaUno, null) == false && Tempera.Equals(temperaDos, null)))
      {
        return false;
      }
      return (temperaUno._color == temperaDos._color && temperaUno._marca.Equals(temperaDos._marca));
    }
    public static bool operator !=(Tempera temperaUno, Tempera temperaDos)
    {
      return !(temperaUno == temperaDos);
    }
    public static Tempera operator +(Tempera tempera, sbyte cantidad)
    {
      tempera._cantidad += cantidad;
      return tempera;
    }
    public static Tempera operator +(Tempera temperaUno, Tempera temperaDos)
    {
      if (temperaUno == temperaDos)
      {
        temperaUno = temperaUno + temperaDos._cantidad;
      }
      return temperaUno;
    }
    public static implicit operator sbyte(Tempera tempera)
    {
      return tempera._cantidad;
    }
  }

  public class Paleta
  {
    private List<Tempera> _temperasList;

    public List<Tempera> TemperasList
    {
      get { return _temperasList; }
    }

    //private Tempera[] _temperas;
    private int _cantidadMaxima;

    private Paleta() : this(5)
    {
    }
    private Paleta(int cantidad)
    {
      this._cantidadMaxima = cantidad;
      this._temperasList = new List<Tempera>();
    }
    public static implicit operator Paleta(int cantidad)
    {
      Paleta paleta = new Paleta(cantidad);
      return paleta;
    }
    public static bool operator ==(Paleta paleta, Tempera tempera)
    {
      bool retorno = false;
      if (Paleta.Equals(paleta, null) || tempera == null || paleta._temperasList.Equals(null))
      {
        retorno = false;
      }
      if (paleta._temperasList.Contains(tempera))
      {
        retorno = true;
      }
      return retorno;
    }
    public static bool operator !=(Paleta paleta, Tempera tempera)
    {
      return !(paleta == tempera);
    }
    public static Paleta operator +(Paleta paleta, Tempera tempera)
    {
      if (Paleta.Equals(paleta, null) || tempera == null || paleta._temperasList.Equals(null))
      {
        return paleta;
      }
      if (paleta._temperasList.Count < paleta._cantidadMaxima)
      {
        paleta._temperasList.Add(tempera);
      }
      return paleta;
    }
    public static Paleta operator -(Paleta paleta, Tempera tempera)
    {
      if (Paleta.Equals(paleta, null) || tempera == null || paleta._temperasList.Equals(null))
      {
        return paleta;
      }
      paleta._temperasList.Remove(tempera);
      return paleta;
    }
    /*
    private string Mostrar()
    {
        string retorno = "Cantidad maxima: " + this._cantidadMaxima.ToString() + " - Temperas: ";
        {
            foreach (Tempera tempera in this._temperas)
            {
                if (tempera != null)
                {
                    retorno += Tempera.Mostrar(tempera) + "\n";
                }
            }
        }
        return retorno;
    }
    public static explicit operator string(Paleta paleta)
    {
        return paleta.Mostrar();
    }
    */

    /* -------------- Codigo anterior --------------------
    public static bool operator ==(Paleta paleta, Tempera tempera)
    {
        bool retorno = false;
        if (Paleta.Equals(paleta, null) || tempera == null)
        {
            retorno = false;
        }
        foreach (Tempera auxTempera in paleta._temperas)
        {
            if (auxTempera == tempera)
            {
                retorno = true;
            }
        }
        return retorno;
    }
    private int ObtenerIndice()
    {
        for (int i = 0; i < this._temperas.Length; i++)
        {
            if (this._temperas[i] == null)
            {
                return i;
            }
        }
        return -1;
    }
    public static bool operator !=(Paleta paleta, Tempera tempera)
    {
        return !(paleta == tempera);
    }
    public static Paleta operator +(Paleta paleta, Tempera tempera)
    {
        int indice = paleta.ObtenerIndice();
        if (paleta != tempera && indice != -1)
        {
            paleta._temperas[indice] = tempera;
        }
        return paleta;
    }
    */
  }
}
