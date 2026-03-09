using System;
using System.Windows.Forms;

namespace Domotica.Views
{
    public partial class FormIluminacion : Form
    {
        public FormIluminacion()
        {
            InitializeComponent();
            this.Text = "Iluminación";
            
            // Inicializar valores
            trackBarSalaIntensidad.Value = 70;
            trackBarCocinaIntensidad.Value = 80;
            trackBarDormitorioIntensidad.Value = 50;
            trackBarBañoIntensidad.Value = 60;
            
            // Actualizar labels
            lblSalaIntensidad.Text = "70%";
            lblCocinaIntensidad.Text = "80%";
            lblDormitorioIntensidad.Text = "50%";
            lblBañoIntensidad.Text = "60%";
        }

        private void trackBarSalaIntensidad_Scroll(object sender, EventArgs e)
        {
            lblSalaIntensidad.Text = trackBarSalaIntensidad.Value + "%";
            panelSalaColor.BackColor = GetColorFromIntensity(trackBarSalaIntensidad.Value);
        }

        private void trackBarCocinaIntensidad_Scroll(object sender, EventArgs e)
        {
            lblCocinaIntensidad.Text = trackBarCocinaIntensidad.Value + "%";
            panelCocinaColor.BackColor = GetColorFromIntensity(trackBarCocinaIntensidad.Value);
        }

        private void trackBarDormitorioIntensidad_Scroll(object sender, EventArgs e)
        {
            lblDormitorioIntensidad.Text = trackBarDormitorioIntensidad.Value + "%";
            panelDormitorioColor.BackColor = GetColorFromIntensity(trackBarDormitorioIntensidad.Value);
        }

        private void trackBarBañoIntensidad_Scroll(object sender, EventArgs e)
        {
            lblBañoIntensidad.Text = trackBarBañoIntensidad.Value + "%";
            panelBañoColor.BackColor = GetColorFromIntensity(trackBarBañoIntensidad.Value);
        }

        private System.Drawing.Color GetColorFromIntensity(int intensity)
        {
            // Crear un color que varía de oscuro a amarillo brillante según la intensidad
            int brightness = (int)(255 * intensity / 100.0);
            return System.Drawing.Color.FromArgb(brightness, brightness, Math.Max(0, brightness - 50));
        }

        private void btnTemperaturaCalida_Click(object sender, EventArgs e)
        {
            btnTemperaturaCalida.BackColor = System.Drawing.Color.FromArgb(255, 180, 0);
            btnTemperaturaFria.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
            MessageBox.Show("Temperatura de luz: CÁLIDA (3000K)", "Iluminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTemperaturaFria_Click(object sender, EventArgs e)
        {
            btnTemperaturaFria.BackColor = System.Drawing.Color.FromArgb(100, 200, 255);
            btnTemperaturaCalida.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
            MessageBox.Show("Temperatura de luz: FRÍA (6500K)", "Iluminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTodoEncendido_Click(object sender, EventArgs e)
        {
            trackBarSalaIntensidad.Value = 100;
            trackBarCocinaIntensidad.Value = 100;
            trackBarDormitorioIntensidad.Value = 100;
            trackBarBañoIntensidad.Value = 100;
        }

        private void btnTodoApagado_Click(object sender, EventArgs e)
        {
            trackBarSalaIntensidad.Value = 0;
            trackBarCocinaIntensidad.Value = 0;
            trackBarDormitorioIntensidad.Value = 0;
            trackBarBañoIntensidad.Value = 0;
        }
    }
}
