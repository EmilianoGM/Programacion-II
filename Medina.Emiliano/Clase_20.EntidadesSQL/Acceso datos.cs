using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Clase_20.EntidadesSQL
{
  public class AccesoDatos
  {
    private SqlConnection _conexion;
    private SqlCommand _comando;
    public AccesoDatos()
    {
      this._conexion = new SqlConnection(Properties.Settings.Default.conexion_bd);   
    }

    public List<Persona> TraerTodos()
    {
      this._comando = new SqlCommand();
      this._comando.Connection = this._conexion;
      this._comando.CommandType = CommandType.Text;
      this._comando.CommandText = "SELECT id, nombre, apellido, edad FROM Padron.dbo.Personas";

      List<Persona> retorno = new List<Persona>();

      try
      {
        this._conexion.Open();
        SqlDataReader sqlDataReader = this._comando.ExecuteReader();
        while (sqlDataReader.Read())
        {
          // sqlDataReader[] --> Puedo acceder por indice o nombre de columna
          Persona persona = new Persona((int)sqlDataReader["id"], (string)sqlDataReader["nombre"], (string)sqlDataReader["apellido"],
            (int)sqlDataReader["edad"]); //casteo porque devuelve object
          retorno.Add(persona);
        }
        this._conexion.Close();
      }
      catch(Exception e)
      {
        Console.WriteLine(e.Message);
      }
      return retorno;
    }

    public bool AgregarPersona(Persona persona)
    {
      this._comando = new SqlCommand();
      this._comando.Connection = this._conexion;
      this._comando.CommandType = CommandType.Text;
      this._comando.CommandText = "INSERT INTO  Padron.dbo.Personas (nombre, apellido, edad) values ('" + persona.Nombre
        + "','" + persona.Apellido + "'," + persona.Edad + ")";
      try
      {
        this._conexion.Open();
        if (this._comando.ExecuteNonQuery() > 0)
        {
          this._conexion.Close();
          return true;
        }
      } catch(Exception e)
      {
        this._conexion.Close();
        Console.WriteLine(e.Message);
      }
      return false;
    }
  }
}
