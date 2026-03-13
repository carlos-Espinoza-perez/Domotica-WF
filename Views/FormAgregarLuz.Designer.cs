using System.Drawing;
using System.Windows.Forms;

namespace Domotica.Views
{
    partial class FormAgregarLuz
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo          = new System.Windows.Forms.Label();
            this.lblNombre          = new System.Windows.Forms.Label();
            this.txtNombre          = new System.Windows.Forms.TextBox();
            this.lblIntensidad      = new System.Windows.Forms.Label();
            this.nudIntensidad      = new System.Windows.Forms.NumericUpDown();
            this.chkEncendida       = new System.Windows.Forms.CheckBox();
            this.lblTemperatura     = new System.Windows.Forms.Label();
            this.rbCalido           = new System.Windows.Forms.RadioButton();
            this.rbFrio             = new System.Windows.Forms.RadioButton();
            this.rbColor            = new System.Windows.Forms.RadioButton();
            this.panelBotones       = new System.Windows.Forms.Panel();
            this.btnGuardar         = new System.Windows.Forms.Button();
            this.btnCancelar        = new System.Windows.Forms.Button();
            this.panelLinea         = new System.Windows.Forms.Panel();

            ((System.ComponentModel.ISupportInitialize)(this.nudIntensidad)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(340, 30);
            this.lblTitulo.Text = "Agregar Nueva Luz";

            // panelLinea
            this.panelLinea.BackColor = System.Drawing.Color.FromArgb(220, 224, 230);
            this.panelLinea.Location = new System.Drawing.Point(20, 55);
            this.panelLinea.Name = "panelLinea";
            this.panelLinea.Size = new System.Drawing.Size(340, 1);

            // lblNombre
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblNombre.Location = new System.Drawing.Point(20, 75);
            this.lblNombre.Text = "Nombre de la luz";

            // txtNombre
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.Location = new System.Drawing.Point(20, 97);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(340, 27);

            // lblIntensidad
            this.lblIntensidad.AutoSize = true;
            this.lblIntensidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIntensidad.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblIntensidad.Location = new System.Drawing.Point(20, 140);
            this.lblIntensidad.Text = "Intensidad inicial (%)";

            // nudIntensidad
            this.nudIntensidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudIntensidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudIntensidad.Location = new System.Drawing.Point(20, 162);
            this.nudIntensidad.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.nudIntensidad.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.nudIntensidad.Name = "nudIntensidad";
            this.nudIntensidad.Size = new System.Drawing.Size(340, 27);
            this.nudIntensidad.Value = new decimal(new int[] { 75, 0, 0, 0 });

            // lblTemperatura
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTemperatura.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblTemperatura.Location = new System.Drawing.Point(20, 210);
            this.lblTemperatura.Text = "Temperatura de color";

            // rbCalido
            this.rbCalido.AutoSize = true;
            this.rbCalido.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rbCalido.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.rbCalido.Location = new System.Drawing.Point(20, 233);
            this.rbCalido.Name = "rbCalido";
            this.rbCalido.Size = new System.Drawing.Size(70, 21);
            this.rbCalido.Text = "Cálido";

            // rbFrio
            this.rbFrio.AutoSize = true;
            this.rbFrio.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rbFrio.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.rbFrio.Location = new System.Drawing.Point(110, 233);
            this.rbFrio.Name = "rbFrio";
            this.rbFrio.Size = new System.Drawing.Size(55, 21);
            this.rbFrio.Text = "Frío";

            // rbColor
            this.rbColor.AutoSize = true;
            this.rbColor.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rbColor.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.rbColor.Location = new System.Drawing.Point(200, 233);
            this.rbColor.Name = "rbColor";
            this.rbColor.Size = new System.Drawing.Size(62, 21);
            this.rbColor.Text = "Color";

            // chkEncendida
            this.chkEncendida.AutoSize = true;
            this.chkEncendida.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.chkEncendida.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.chkEncendida.Location = new System.Drawing.Point(20, 275);
            this.chkEncendida.Name = "chkEncendida";
            this.chkEncendida.Size = new System.Drawing.Size(107, 21);
            this.chkEncendida.Text = "Encendida al inicio";

            // panelBotones
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.panelBotones.Controls.Add(this.btnGuardar);
            this.panelBotones.Controls.Add(this.btnCancelar);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotones.Location = new System.Drawing.Point(0, 320);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(380, 60);

            // btnGuardar
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(165, 13);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 34);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // btnCancelar
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.btnCancelar.Location = new System.Drawing.Point(275, 13);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 34);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // FormAgregarLuz
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 380);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelLinea);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblIntensidad);
            this.Controls.Add(this.nudIntensidad);
            this.Controls.Add(this.lblTemperatura);
            this.Controls.Add(this.rbCalido);
            this.Controls.Add(this.rbFrio);
            this.Controls.Add(this.rbColor);
            this.Controls.Add(this.chkEncendida);
            this.Controls.Add(this.panelBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Luz";

            ((System.ComponentModel.ISupportInitialize)(this.nudIntensidad)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelLinea;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblIntensidad;
        private System.Windows.Forms.NumericUpDown nudIntensidad;
        private System.Windows.Forms.CheckBox chkEncendida;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.RadioButton rbCalido;
        private System.Windows.Forms.RadioButton rbFrio;
        private System.Windows.Forms.RadioButton rbColor;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
