using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_20.EntidadesSQL;

namespace Clase_21.WindowsForm
{
  public partial class frmListado : Form
  {
    private List<Persona> _personas;
    private DataTable _tabla;

    public frmListado()
    {
      InitializeComponent();
      AccesoDatos accesoDatos = new AccesoDatos();
      this._personas = accesoDatos.TraerTodos();
      this._tabla = accesoDatos.TraerTablaPersonas();
    }

    private void frmListado_Load(object sender, EventArgs e)
    {
      this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      //this.dataGridView1.DataSource = this._personas;
      this.dataGridView1.DataSource = this._tabla;
    }
  }
}
