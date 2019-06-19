namespace Clase_23.WindowsForm
{
  partial class frmEmpleados
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.cmbManejador = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.lblManejador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(80, 93);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(100, 20);
            this.txtLegajo.TabIndex = 0;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(80, 135);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(100, 20);
            this.txtSueldo.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(80, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(198, 53);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // cmbManejador
            // 
            this.cmbManejador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbManejador.FormattingEnabled = true;
            this.cmbManejador.Location = new System.Drawing.Point(80, 196);
            this.cmbManejador.Name = "cmbManejador";
            this.cmbManejador.Size = new System.Drawing.Size(100, 21);
            this.cmbManejador.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(80, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(81, 76);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(39, 13);
            this.lblLegajo.TabIndex = 6;
            this.lblLegajo.Text = "Legajo";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(80, 119);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(40, 13);
            this.lblSueldo.TabIndex = 7;
            this.lblSueldo.Text = "Sueldo";
            // 
            // lblManejador
            // 
            this.lblManejador.AutoSize = true;
            this.lblManejador.Location = new System.Drawing.Point(85, 180);
            this.lblManejador.Name = "lblManejador";
            this.lblManejador.Size = new System.Drawing.Size(57, 13);
            this.lblManejador.TabIndex = 8;
            this.lblManejador.Text = "Manejador";
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 243);
            this.Controls.Add(this.lblManejador);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cmbManejador);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtLegajo);
            this.Name = "frmEmpleados";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtLegajo;
    private System.Windows.Forms.TextBox txtSueldo;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.Button btnCrear;
    private System.Windows.Forms.ComboBox cmbManejador;
    private System.Windows.Forms.Label lblNombre;
    private System.Windows.Forms.Label lblLegajo;
    private System.Windows.Forms.Label lblSueldo;
    private System.Windows.Forms.Label lblManejador;
  }
}

