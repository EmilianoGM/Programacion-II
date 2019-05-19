using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_04.Entidades;

namespace Clase_04.WindowForms
{
  public partial class FrmCosa : Form
  {
    public FrmCosa()
    {
      InitializeComponent();
    }

    private void FrmCosa_Load(object sender, EventArgs e)
    {
      this.button1.Text = "BotonCambiado";
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Cosa nuevaCosa = new Cosa();
      MessageBox.Show(nuevaCosa.Mostrar());
      this.ForeColor = Color.DarkOrange;
  
    }
  }
}
