using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;                                                                                                                                               

namespace Clase_16.WindowsForm
{
  public partial class frmPrincipal : Form
  {
    private string rutaDeAcceso;
    public frmPrincipal()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
      this.openFileDialog1.Title = "Seleccione un archivo a abrir";
      this.openFileDialog1.DefaultExt = ".txt";
      this.openFileDialog1.AddExtension = true;
      this.openFileDialog1.Filter = "*(.txt)| *.TXT";
    }

    private void btnEnviar_Click(object sender, EventArgs e)
    {
      if (!String.IsNullOrEmpty(this.rutaDeAcceso))
      {
        try
        {
          //StreamReader archivo = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"\prueba.txt", true);
          //StreamWriter archivo = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\nuevoDos.txt", true);
          StreamWriter archivo = new StreamWriter(this.rutaDeAcceso, true);
          archivo.WriteLine(txtValor.Text);
          archivo.Close();
        }
        catch (Exception exception)
        {
          txtValor.Text = "Error";
        }
      }
      else
      {
        MessageBox.Show("Debe especificar una ruta de acceso");
      }
    }

    private void btnTraer_Click(object sender, EventArgs e)
    {
      if (!String.IsNullOrEmpty(this.rutaDeAcceso))
      {
        try
        {
          //StreamReader archivo = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"\prueba.txt");
          //StreamReader archivo = new StreamReader(@"C:\Users\alumno\Desktop\nuevo.txt");
          StreamReader archivo = new StreamReader(this.rutaDeAcceso);
          this.lstVisor.Items.Clear();
          /*
          //segunda forma - asigna el valor de read line dentro del while no en la declaracion de la variable
          string l;
          while((l = archivo.ReadLine()) != null)
          {
            this.lstVisor.Items.Add(archivo.ReadLine());
          }
          */
          while (!archivo.EndOfStream)
          {
            this.lstVisor.Items.Add(archivo.ReadLine());
          }
          archivo.Close();
        }
        catch (Exception exception)
        {
          txtValor.Text = "Error";
        }
      }
      else
      {
        MessageBox.Show("Debe especificar una ruta de acceso");
      }
    }

    private void btnBuscar_Click(object sender, EventArgs e)
    {
      DialogResult resultado = this.openFileDialog1.ShowDialog();
      if (resultado == DialogResult.OK)
      {
        this.rutaDeAcceso = this.openFileDialog1.FileName;
      }
    }
  }
}
