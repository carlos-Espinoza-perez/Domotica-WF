using System;
using System.Drawing;
using System.Windows.Forms;
using Domotica.Models;

namespace Domotica.Views
{
    public partial class FormAgregarMultimedia : Form
    {
        private object _dispositivoOriginal;
        private bool _esTelevision;

        public Television TelevisionResultado { get; private set; }
        public SistemaMusica MusicaResultado { get; private set; }

        public FormAgregarMultimedia(bool esTelevision, object dispositivoEditar = null)
        {
            InitializeComponent();
            _esTelevision = esTelevision;
            _dispositivoOriginal = dispositivoEditar;

            ConfigurarUI();
        }

        private void ConfigurarUI()
        {
            if (_esTelevision)
            {
                this.Text = _dispositivoOriginal != null ? "Editar Televisión" : "Agregar Televisión";
                lblTitulo.Text = this.Text;
                lblExtra.Text = "Canal Inicial";
                nudExtra.Minimum = 1;
                nudExtra.Maximum = 999;
                chkEncendida.Text = "Encendida al inicio";

                if (_dispositivoOriginal is Television tv)
                {
                    txtNombre.Text = tv.Nombre;
                    nudExtra.Value = tv.CanalActual;
                    chkEncendida.Checked = tv.EstaEncendido;
                }
                else
                {
                    nudExtra.Value = 1;
                    chkEncendida.Checked = true;
                }
            }
            else
            {
                this.Text = _dispositivoOriginal != null ? "Editar Sistema de Música" : "Agregar Sistema de Música";
                lblTitulo.Text = this.Text;
                lblExtra.Text = "Volumen Inicial (%)";
                nudExtra.Minimum = 0;
                nudExtra.Maximum = 100;
                chkEncendida.Text = "Reproduciendo al inicio";

                if (_dispositivoOriginal is SistemaMusica sm)
                {
                    txtNombre.Text = sm.Nombre;
                    nudExtra.Value = sm.Volumen;
                    chkEncendida.Checked = sm.EstaEncendido;
                }
                else
                {
                    nudExtra.Value = 50;
                    chkEncendida.Checked = true;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            if (_esTelevision)
            {
                int id = (_dispositivoOriginal is Television tv) ? tv.Id : 0;
                TelevisionResultado = new Television(
                    id: id,
                    nombre: txtNombre.Text.Trim(),
                    encendido: chkEncendida.Checked,
                    canalActual: (int)nudExtra.Value,
                    volumen: 50, // Valor por defecto
                    fuenteEntrada: FuenteEntrada.TV,
                    modoImagen: ModoImagen.Estandar
                );
            }
            else
            {
                int id = (_dispositivoOriginal is SistemaMusica sm) ? sm.Id : 0;
                MusicaResultado = new SistemaMusica(
                    id: id,
                    nombre: txtNombre.Text.Trim(),
                    encendido: chkEncendida.Checked,
                    volumen: (int)nudExtra.Value
                );
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
