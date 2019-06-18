using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_22.WindowsForm
{
  public partial class frmTest2 : Form
  {
    public frmTest2()
    {
      InitializeComponent();
      this.Load += new System.EventHandler(this.Inicializar);
    }

    private void Inicializar(object sender, EventArgs e)
    {
      this.btnBoton1.Click += new System.EventHandler(this.MiManejador);
    }

    private void MiManejador(object sender, EventArgs e)
    {
      if(sender is Button)
      {
        MessageBox.Show(((Button)sender).Name);
        if(sender == this.btnBoton1)
        {
          this.btnBoton1.Click -= new System.EventHandler(this.MiManejador);
          this.btnBoton2.Click += new System.EventHandler(this.MiManejador);
        }
        else if(sender == this.btnBoton2)
        {
          this.btnBoton2.Click -= new System.EventHandler(this.MiManejador);
          this.btnBoton3.Click += new System.EventHandler(this.MiManejador);
        }
        else if(sender == this.btnBoton3)
        {
          this.btnBoton3.Click -= new System.EventHandler(this.MiManejador);
          this.btnBoton1.Click += new System.EventHandler(this.MiManejador);
        }
      }
    }

    private void btnOperar_Click(object sender, EventArgs e)
    {
      MiDelegado delegado = new MiDelegado(Manejadora.Sumar);
      //delegado.Invoke(3, 2);
      //delegado(3, 4);
      Manejadora manejadora = new Manejadora();
      MiDelegado delegadoDos = new MiDelegado(manejadora.Restar);
      //delegadoDos.Invoke(4, 1);
      MiDelegado delegadoTres = (MiDelegado)MiDelegado.Combine(delegado, delegadoDos);
      //delegadoTres.Invoke(8, 2);

      /*
      MessageBox.Show(delegado.Method.ToString());
      MessageBox.Show(delegadoDos.Target.ToString());
      string c = "";
      foreach(Delegate d in delegado.GetInvocationList())
      {
        c += d.Target.ToString() + " - ";
      }
      MessageBox.Show(c);
      */

      MiDelegado delegadoCuatro = (MiDelegado)MiDelegado.Combine(delegadoTres, new MiDelegado(manejadora.Multiplicar));
      //delegadoCuatro.Invoke(15, 3);

      manejadora.OtraSuma(delegado, 20, 11);
    }
  }
}
