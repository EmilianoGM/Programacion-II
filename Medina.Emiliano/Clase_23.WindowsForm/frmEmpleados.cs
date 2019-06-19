using Clase_22.Entidades;
using System;
using System.IO;
using System.Windows.Forms;

namespace Clase_23.WindowsForm
{
  public partial class frmEmpleados : Form
  {
    public frmEmpleados()
    {
      InitializeComponent();
      foreach(ETipoManejador manejador in Enum.GetValues(typeof(ETipoManejador)))
      {
        this.cmbManejador.Items.Add(manejador);
      }
    }

    private void frmEmpleados_Load(object sender, EventArgs e)
    {

    }

    private void btnCrear_Click(object sender, EventArgs e)
    {
      EmpleadoMejorado empleado = new EmpleadoMejorado();
      empleado.limiteSueldo += new DelSueldo(LimiteSueldoEmpleado);
      empleado.limiteSueldo += new DelSueldo(GuardarLog);
      if(this.cmbManejador.SelectedIndex > -1)
      {
        if ((ETipoManejador)this.cmbManejador.SelectedItem == ETipoManejador.limiteSueldo)
        {
          empleado.limiteSueldo -= new DelSueldo(GuardarLog);
        }
        else if ((ETipoManejador)this.cmbManejador.SelectedItem == ETipoManejador.log)
        {
          empleado.limiteSueldo -= new DelSueldo(LimiteSueldoEmpleado);
        }
        empleado.Nombre = this.txtNombre.Text;
        empleado.Legajo = Int32.Parse(this.txtLegajo.Text);
        empleado.Sueldo = float.Parse(this.txtSueldo.Text);
      }
      else
      {
        MessageBox.Show("No se a seleccionado ningun manejador");
      }

    }

    public static void LimiteSueldoEmpleado(EmpleadoMejorado e, EmpleadoSueldoArgs args)
    {
      MessageBox.Show("Al empleado\n" + e.Nombre + "\nSe le quizo asignar un sueldo de " + args.Sueldo.ToString());
    }

    public void GuardarLog(EmpleadoMejorado e, EmpleadoSueldoArgs args)
    {
      try
      {
        StreamWriter archivo = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"\incidentes.log", true);
        archivo.WriteLine(DateTime.Now.ToString());
        archivo.WriteLine("Empleado:{0} Legajo:{1} Sueldo a asignar:{2}", e.Nombre, e.Legajo, args.Sueldo);
        archivo.Close();
      }
      catch (Exception exception)
      {
        Console.WriteLine(exception.Message);
      }
    }
  }
}
