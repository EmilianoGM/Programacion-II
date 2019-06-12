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
      }
      catch(Exception e)
      {
        Console.WriteLine(e.Message);
      }
      finally
      {
        if (this._conexion.State.Equals(ConnectionState.Open))
        {
          this._conexion.Close();
        }
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
        if (this._comando.ExecuteNonQuery() > 0) // ExecuteNonQuery devuelve la cantidad de filas afectadas
        {
          return true;
        }
      } catch(Exception e)
      {       
        Console.WriteLine(e.Message);
      } finally
      {
        if (this._conexion.State.Equals(ConnectionState.Open))
        {
          this._conexion.Close();
        }
        
      }
      return false;
    }

    public bool ModificarPersona(Persona persona)
    {
      this._comando = new SqlCommand();
      this._comando.Connection = this._conexion;
      this._comando.CommandType = CommandType.Text;
      this._comando.CommandText = "UPDATE Padron.dbo.Personas SET nombre = 'Francisco', apellido = 'Gomez', edad = 99 WHERE id = "
        + persona.ID;
      try
      {
        this._conexion.Open();
        if (this._comando.ExecuteNonQuery() > 0)
        {
          return true;
        }
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
      finally
      {
        if (this._conexion.State.Equals(ConnectionState.Open))
        {
          this._conexion.Close();
        }
      }
      return false;
    }

    public bool EliminarPersona(int id)
    {
      this._comando = new SqlCommand();
      this._comando.Connection = this._conexion;
      this._comando.CommandType = CommandType.Text;
      this._comando.CommandText = "DELETE FROM Padron.dbo.Personas WHERE id = " + id.ToString();
      try
      {
        this._conexion.Open();
        if (this._comando.ExecuteNonQuery() > 0)
        {
          return true;
        }
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
      finally
      {
        if (this._conexion.State.Equals(ConnectionState.Open))
        {
          this._conexion.Close();
        }
      }
      return false;
    }

    public DataTable TraerTablaPersonas()
    {
      DataTable dataTable = new DataTable("Personas");
      this._comando = new SqlCommand();
      this._comando.Connection = this._conexion;
      this._comando.CommandType = CommandType.Text;

      this._comando.CommandText = "SELECT id, nombre, apellido, edad FROM Padron.dbo.Personas";

      try
      {
        this._conexion.Open();
        SqlDataReader sqlDataReader = this._comando.ExecuteReader();
        dataTable.Load(sqlDataReader);
      } catch(Exception e)
      {
        Console.WriteLine(e.Message);
      }
      finally
      {
        if (this._conexion.State.Equals(ConnectionState.Open))
        {
          this._conexion.Close();
        }
      }
        return dataTable;
    }
  }
}
