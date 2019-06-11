using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_20.EntidadesSQL;

namespace Clase_20.TestSQL
{
  class Program
  {
    static void Main(string[] args)
    {
      Persona persona = new Persona(4, "Emiliano", "Medina", 39);
      AccesoDatos accesoDatos = new AccesoDatos();
      List<Persona> personas = accesoDatos.TraerTodos();
      foreach(Persona p in personas)
      {
        Console.WriteLine(p.ToString());
      }

      accesoDatos.AgregarPersona(persona);

      Console.ReadKey();
    }
  }
}
