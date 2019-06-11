using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Clase_20.EntidadesSQL
{
  public class Persona
  {
    private int id;
    private string nombre;
    private string apellido;
    private int edad;

    public string Nombre
    {
      get
      {
        return this.nombre;
      }
    }

    public string Apellido
    {
      get
      {
        return this.apellido;
      }
    }

    public string Edad
    {
      get
      {
        return this.edad.ToString();
      }
    }

    public Persona(int id, string nombre, string apellido, int edad)
    {
      this.id = id;
      this.nombre = nombre;
      this.apellido = apellido;
      this.edad = edad;
    }

    public override string ToString()
    {
      return "Id: " + this.id.ToString() + " - Nombre: " + this.nombre + " - Apellido: " + this.apellido + " - Edad: " + this.edad.ToString();
    }

    
  }
}
