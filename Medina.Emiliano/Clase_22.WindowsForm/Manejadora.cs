using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_22.WindowsForm
{
  public class Manejadora
  {
    public static void Manejador(object sender, EventArgs e)
    {
      if(sender is Button)
      {
        MessageBox.Show("Soy un boton");
      } else if(sender is Label)
      {
        MessageBox.Show("Soy un label");
      } else if(sender is TextBox)
      {
        MessageBox.Show("Soy un text box");
      }
      MessageBox.Show("Estoy en la clase manejadora");
    }

    public void ManejadorDos(object sender, EventArgs e)
    {
      MessageBox.Show("Metodo de intancia ManejadorDos");
    }

    public static void Sumar(int a, int b)
    {
      MessageBox.Show("Suma = " + (a + b).ToString());
    }

    public void Restar(int a , int b)
    {
      MessageBox.Show("Resta = " + (a - b).ToString());
    }

    public void Multiplicar(int a, int b)
    {
      MessageBox.Show("Multiplica = " + (a * b).ToString());
    }

    public void OtraSuma(MiDelegado delegado, int a, int b)
    {
      delegado(a, b);
    }
  }
}
