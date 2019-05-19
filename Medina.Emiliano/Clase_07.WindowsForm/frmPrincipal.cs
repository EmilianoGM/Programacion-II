using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_07.WindowsForm
{
  public partial class FrmPrincipal : Form
  {
    public FrmPrincipal()
    {
      InitializeComponent();
      this.IsMdiContainer = true;
      this.WindowState = FormWindowState.Maximized;
    }

    private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FrmPaleta nuevaPaleta = new FrmPaleta();
      nuevaPaleta.MdiParent = this;
      nuevaPaleta.Show();
      nuevaPaleta.StartPosition = FormStartPosition.CenterParent;
    }

    private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
    {
      var resultado = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.OKCancel);
      if (resultado == DialogResult.Cancel)
      {
        e.Cancel = true;
      }
    }

    private void salirToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.FrmPrincipal_FormClosing(sender, new FormClosingEventArgs(CloseReason.UserClosing, true));
    }

    
  }
}
