using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_22.Entidades;
using System.IO;

namespace Clase_23.Test
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      Program program = new Program();
      Empleado empleado = new Empleado();
      empleado.limiteSueldo += new DelegadoSueldo(LimiteSueldoEmpleado);
      empleado.limiteSueldo += new DelegadoSueldo(program.GuardarLog);
      empleado.Nombre = "Pedro Perez";
      empleado.Legajo = 1;
      empleado.Sueldo = 15100;
      */
 
      Console.WriteLine("Fin");
      Console.ReadKey();
    }

    public static void LimiteSueldoEmpleado(Empleado e, float sueldo)
    {
      Console.WriteLine("Al empleado\n" + e.Nombre + "\nSe le quizo asignar un sueldo de " + sueldo.ToString());
    }

    public void GuardarLog(Empleado e, float sueldo)
    {
      try
      {
        StreamWriter archivo = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"\incidentes.log", true);
        archivo.WriteLine(DateTime.Now.ToString());
        archivo.WriteLine("Empleado:{0} Legajo:{1} Sueldo a asignar:{2}", e.Nombre, e.Legajo, sueldo);
        archivo.Close();
      } catch (Exception exception)
      {
        Console.WriteLine(exception.Message);
      }
    }
  }
}
