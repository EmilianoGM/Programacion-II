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
  public partial class FrmPaleta : Form
  {
    private Paleta _paleta;

    public FrmPaleta()
    {
      InitializeComponent();
      this._paleta = 5;
    }

    private void FormPaleta_Load(object sender, EventArgs e)
    {
    }

    private void btnMas_Click(object sender, EventArgs e)
    {
      FrmTempera formTempera = new FrmTempera();
      formTempera.ShowDialog();
      if (formTempera.DialogResult == DialogResult.OK)
      {
        this._paleta += formTempera.MiTempera;
        this.cargarLista(this._paleta);
      }
    }

    private void btnMenos_Click(object sender, EventArgs e)
    {
      int indice = this.lstLista.SelectedIndex;
      if (indice > -1)
      {
        Tempera auxTempera = this._paleta.TemperasList[indice];
        FrmTempera formTempera = new FrmTempera(auxTempera, false);
        formTempera.ShowDialog();
        if (formTempera.DialogResult == DialogResult.OK)
        {
          this._paleta -= auxTempera;
          this.cargarLista(this._paleta);
        }
      } else
      {
        MessageBox.Show("Selecciona un item");
      }
    }

    private void lstLista_DobleClick(object sender, EventArgs e)
    {
      int indice = this.lstLista.SelectedIndex;
      Tempera auxTempera = this._paleta.TemperasList[indice];
      FrmTempera formTempera = new FrmTempera(auxTempera, true);
      formTempera.ShowDialog();
      if (formTempera.DialogResult == DialogResult.OK)
      {
        this._paleta.TemperasList[indice] = formTempera.MiTempera;
        this.cargarLista(this._paleta);
      }
    }

    private void cargarLista(Paleta paleta)
    {
      this.lstLista.Items.Clear();
      if (!(Paleta.Equals(paleta, null)) && !(paleta.TemperasList.Equals(null)))
      {
        List<Tempera> auxTemperasList = paleta.TemperasList;
        foreach (Tempera tempera in auxTemperasList)
        {
          this.lstLista.Items.Add(Tempera.Mostrar(tempera));
        }
      }
    }
  }
}
