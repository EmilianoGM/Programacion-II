using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otroNameSpace
{
  class Boligrafo
  {
    const short cantidadTintaMaxima = 100;
    private ConsoleColor color;
    private short tinta;
    public Boligrafo(short tinta, ConsoleColor color)
    {
      this.tinta = tinta;
      this.color = color;
    }
    public ConsoleColor GetColor()
    {
      return color;
    }
    public short GetTinta()
    {
      return tinta;
    }
    private void SetTinta(short tinta)
    {
      if(this.tinta + tinta > cantidadTintaMaxima)
      {
        this.tinta = cantidadTintaMaxima;
      } else if(this.tinta + tinta < 0)
      {
        this.tinta = 0;
      } else
      {
        this.tinta = (short)(this.tinta + tinta);
      }
    }
    public void Recargar()
    {
      SetTinta(cantidadTintaMaxima);
    }
    public bool Pintar(int gasto, out string dibujo)
    {
      dibujo = "No se puede dibujar, nivel de tinta cero";
      int nivelDeGasto = 0;
      if (this.tinta == 0)
      {
        return false;
      }
      if(gasto > this.tinta)
      {
        nivelDeGasto = this.tinta;
      } else
      {
        nivelDeGasto = gasto;
      }
      SetTinta((short)(gasto * (-1)));  
      return true;
    }
  }
}
