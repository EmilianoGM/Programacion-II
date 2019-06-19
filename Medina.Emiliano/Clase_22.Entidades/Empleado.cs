using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_22.Entidades
{
  public class Empleado
  {
    //Eventos - Atributos - Propiedades - Metodos
    public event DelegadoSueldo limiteSueldo;

    private string _nombre;
    private int _legajo;
    private float _sueldo;

    public string Nombre
    {
      get
      {
        return this._nombre;
      }
      set
      {
        this._nombre = value;
      }
    }

    public int Legajo
    {
      get
      {
        return this._legajo;
      }
      set
      {
        this._legajo = value;
      }
    }

    public float Sueldo
    {
      get
      {
        return this._sueldo;
      }
      set
      {
        if(value > 12000)
        {
          this.limiteSueldo(this, value);
        }
        this._sueldo = value;
      }
    }

    public override string ToString()
    {
      return "Nombre: " + this._nombre + " - Legajo: " + this._legajo.ToString() + " - Sueldo: " + this._sueldo.ToString();
    }
  }
}
