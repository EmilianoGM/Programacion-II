using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehiculos;

namespace Clase_09.Test
{
  class Program
  {
    static void Main(string[] args)
    {
      Auto nuevoAuto = new Auto("AAA000", 4, EMarca.Fiat, 5);
      Auto nuevoDos = new Auto("AAA001", 4, EMarca.Honda, 5);
      Auto nuevoTres = new Auto("AAA002", 4, EMarca.Ford, 5);
      Camion nuevoCamion = new Camion("ADC345", 6, EMarca.Iveco, 5000);
      Lavadero lavadero = new Lavadero(50, 200, 25);
      lavadero += nuevoAuto;
      lavadero += nuevoCamion;
      lavadero += nuevoTres;
      lavadero += nuevoDos;
      List<Vehiculo> vehiculosLavadero = new List<Vehiculo>(lavadero.MisVehiculos);
      vehiculosLavadero.Sort(Lavadero.OrdenarVehiculosPorPatente);
      //Console.WriteLine(nuevoAuto.ToString());
      Console.WriteLine(lavadero.MiLavadero);
      Console.WriteLine("Total facturado:" + lavadero.MostrarTotalFacturado(EVehiculos.Auto).ToString());
      Console.WriteLine("");
      vehiculosLavadero.ForEach(Console.WriteLine);
      Console.ReadKey();
    }
  }
}
