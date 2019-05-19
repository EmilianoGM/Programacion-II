using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_06.Entidades;

namespace Clase_07.WindowsForm
{
  public partial class FrmTempera : Form
  {
    private Tempera _tempera;

    public Tempera MiTempera
    {
      get { return _tempera; }
    }

    public FrmTempera()
    {
      InitializeComponent();
      foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
      {
        this.cmbColor.Items.Add(color);
      }
    }

    public FrmTempera(Tempera tempera, bool modificar) : this()
    {
      if(tempera != null)
      {
        sbyte cantidad = tempera;
        this.txtMarca.Text = tempera.MiMarca;
        this.cmbColor.SelectedItem = tempera.MiColor;
        this.txtCantidad.Text = cantidad.ToString();
      }
      if (!modificar)
      {
        this.txtMarca.Enabled = false;
        this.txtCantidad.Enabled = false;
        this.cmbColor.Enabled = false;
      }    
    }

    private void FrmTempera_Load(object sender, EventArgs e)
    {
 
    }

    private void btnAceptar_Click(object sender, EventArgs e)
    {
      string marca = this.txtMarca.Text;
      ConsoleColor color;
      sbyte cantidad;
      if(SByte.TryParse(this.txtCantidad.Text, out cantidad) && !(String.IsNullOrEmpty(marca)) && this.cmbColor.SelectedItem != null)
      {
        color = (ConsoleColor)this.cmbColor.SelectedItem;
        Tempera nuevaTempera = new Tempera(color, marca, cantidad);
        this._tempera = nuevaTempera;
        this.DialogResult = DialogResult.OK;
      } else
      {
        MessageBox.Show("Campo con valor incorrecto");
        this.DialogResult = DialogResult.Cancel;
      }
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
    }
  }
}
