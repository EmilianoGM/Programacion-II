using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades.Estacionamientos.starter;

namespace UnitTestProject1
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod1()
    {
      Estacionamiento algo = new Estacionamiento(5);
      Assert.IsNotNull(algo.Autos);
    }
    [TestMethod]
    public void EspacioEstacionamientoIncorrecto()
    {
      Estacionamiento e = new Estacionamiento(101);
      Estacionamiento b = new Estacionamiento(0);
      if (e.EspacioDisponible != 101)
      {
        Assert.Fail("Espacio incorrecto {0}", e.EspacioDisponible);
      }
      Assert.AreNotEqual(b.EspacioDisponible, 1);
    }
    [TestMethod]
    public void ChequearAutosEstacionamiento()
    {
      Estacionamiento c = new Estacionamiento(2);
      Auto uno = new Auto("AAA012", ConsoleColor.Black);
      Auto dos = new Auto("AAA013", ConsoleColor.Blue);
      Auto tres = new Auto("AAA014", ConsoleColor.Red);
      try
      {
        c += uno;
        c += dos;
        c += tres;
        Assert.Fail("Se agrego mas autos del espacio disponible");
      } catch(Exception e)
      {
        Assert.IsInstanceOfType(e, typeof(EstacionamientoLlenoException));
      }
    }
    [TestMethod]
    public void AgregarAutoEspacioDisponible()
    {
      Estacionamiento d = new Estacionamiento(2);
      Auto cuatro = new Auto("BBB012", ConsoleColor.Black);
      Auto cinco = new Auto("AAA013", ConsoleColor.Blue);
      d += cuatro;
      Assert.AreEqual(d.EspacioDisponible, 1);
      d += cinco;
      Assert.AreEqual(d.EspacioDisponible, 0);
    }
  }
}
