using System;
using System.Windows.Forms;

namespace Clase_22.WindowsForm
{
  public partial class frmTest : Form
  {
    public frmTest()
    {
      InitializeComponent();
      /*objeto.evento*/
      Manejadora manejadora = new Manejadora();
      this.btnBoton.Click += new System.EventHandler(manejadora.ManejadorDos);
      this.btnBoton.Click += new System.EventHandler(Manejadora.Manejador);
      this.lblEtiqueta.Click += new System.EventHandler(Manejadora.Manejador);
      this.txtCuadroTexto.Click += new System.EventHandler(Manejadora.Manejador);
    }

    private void botonMensaje(object sender, EventArgs e)
    {
      MessageBox.Show("boton clickeado");
      //this.lblEtiqueta.Click += new System.EventHandler(this.lblEtiqueta_Click);
      //this.txtCuadroTexto.Click += new System.EventHandler(this.txtCuadroTexto_Click);
    }

    private void lblEtiqueta_Click(object sender, EventArgs e)
    {
      MessageBox.Show("label clickeado");
      //this.lblEtiqueta.Click -= new System.EventHandler(this.lblEtiqueta_Click);
    }

    private void txtCuadroTexto_Click(object sender, EventArgs e)
    {
      MessageBox.Show("cuadro de texto clickeado");
    }

    private void frmTest_Load(object sender, EventArgs e)
    {

    }
  }
}
