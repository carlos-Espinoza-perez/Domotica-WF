using System;
using System.Drawing;
using System.Windows.Forms;
using Domotica.Models;

namespace Domotica.Views
{
    /// <summary>
    /// Modal para agregar o editar una luz.
    /// </summary>
    public partial class FormAgregarLuz : Form
    {
        private Luz _luzOriginal;

        /// <summary>
        /// La luz resultante después de guardar. Null si el usuario cancela.
        /// </summary>
        public Luz LuzResultado { get; private set; }

        // Modo EDICIÓN cuando se pasa una luz existente
        public FormAgregarLuz(Luz luzEditar = null)
        {
            InitializeComponent();
            _luzOriginal = luzEditar;

            if (_luzOriginal != null)
            {
                // Modo edición: prellenar campos
                txtNombre.Text = _luzOriginal.Nombre;
                nudIntensidad.Value = _luzOriginal.Intensidad;
                chkEncendida.Checked = _luzOriginal.EstaEncendido;
                switch (_luzOriginal.TemperaturaColor)
                {
                    case TemperaturaColor.Calido: rbCalido.Checked = true; break;
                    case TemperaturaColor.Frio:   rbFrio.Checked = true;   break;
                    case TemperaturaColor.Color:  rbColor.Checked = true;  break;
                }
                this.Text = "Editar Luz";
                lblTitulo.Text = "Editar Luz";
            }
            else
            {
                // Modo agregar
                rbCalido.Checked = true;
                chkEncendida.Checked = true;
                nudIntensidad.Value = 75;
                this.Text = "Agregar Luz";
                lblTitulo.Text = "Agregar Nueva Luz";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre de la luz no puede estar vacío.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            TemperaturaColor temp = TemperaturaColor.Calido;
            if (rbFrio.Checked)  temp = TemperaturaColor.Frio;
            if (rbColor.Checked) temp = TemperaturaColor.Color;

            if (_luzOriginal != null)
            {
                // Modo edición: conservar el ID original
                LuzResultado = new Luz(
                    _luzOriginal.Id,
                    txtNombre.Text.Trim(),
                    chkEncendida.Checked,
                    (int)nudIntensidad.Value,
                    temp
                );
            }
            else
            {
                // Modo agregar: id 0, el controlador asignará el real
                LuzResultado = new Luz(
                    0,
                    txtNombre.Text.Trim(),
                    chkEncendida.Checked,
                    (int)nudIntensidad.Value,
                    temp
                );
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LuzResultado = null;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
