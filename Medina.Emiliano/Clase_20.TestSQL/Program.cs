using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_20.EntidadesSQL;
using System.Data;

namespace Clase_20.TestSQL
{
  class Program
  {
    static void Main(string[] args)
    {
      /* Clase 20
      Persona persona = new Persona(4, "Emiliano", "Medina", 39);
      AccesoDatos accesoDatos = new AccesoDatos();
      List<Persona> personas = accesoDatos.TraerTodos();
      foreach(Persona p in personas)
      {
        Console.WriteLine(p.ToString());
      }

      //accesoDatos.AgregarPersona(persona);
      */
      /*----CLASE 21----*/
      //Console.WriteLine(accesoDatos.EliminarPersona(8));

      //Console.WriteLine(accesoDatos.ModificarPersona(personas[5]));
      AccesoDatos accesoDatos = new AccesoDatos();
      DataTable dataTable = accesoDatos.TraerTablaPersonas();
      DataRowCollection rowCollection = dataTable.Rows;
      for (int i = 0; i < rowCollection.Count; i++)
      {
        DataRow dataRow = rowCollection[i];
        Persona persona = new Persona((int)dataRow["id"], (string)dataRow["nombre"], (string)dataRow["apellido"], (int)dataRow["edad"]);
        Console.WriteLine(persona.ToString());
      }
      DataTable dataTableXML = new DataTable();
      /*GUARDAR*/
      //dataTable.WriteXmlSchema(AppDomain.CurrentDomain.BaseDirectory + @"\Personas_esquema.xml");
      //dataTable.WriteXml(AppDomain.CurrentDomain.BaseDirectory + @"\Personas_datos.xml");

      /*LEER*/
      dataTableXML.ReadXmlSchema(AppDomain.CurrentDomain.BaseDirectory + @"\Personas_esquema.xml");
      dataTableXML.ReadXml(AppDomain.CurrentDomain.BaseDirectory + @"\Personas_datos.xml");
      Console.ReadKey();
    }
  }
}
