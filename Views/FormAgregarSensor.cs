using System;
using System.Drawing;
using System.Windows.Forms;
using Domotica.Controllers;
using Domotica.Models;

namespace Domotica.Views
{
    public partial class FormAgregarSensor : Form
    {
        private readonly SeguridadController _controller;

        public FormAgregarSensor()
        {
            InitializeComponent();
            _controller = SeguridadController.Instancia;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor ingrese un nombre para el sensor.", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tipoSeleccionado = cmbTipo.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(tipoSeleccionado))
            {
                MessageBox.Show("Por favor seleccione un tipo de sensor.", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                switch (tipoSeleccionado)
                {
                    case "Cámara":
                        AgregarCamara();
                        break;
                    case "Sensor Movimiento":
                        AgregarSensorMovimiento();
                        break;
                    case "Alarma":
                        AgregarAlarma();
                        break;
                    case "Control Acceso":
                        AgregarControlAcceso();
                        break;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el sensor: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarCamara()
        {
            Camara camara = new Camara(
                id: 0,
                nombre: txtNombre.Text,
                encendido: true,
                resolucion: "1080p",
                estaGrabando: false,
                deteccionMovimiento: true,
                ubicacion: txtNombre.Text
            );
            _controller.AgregarCamara(camara);
        }

        private void AgregarSensorMovimiento()
        {
            SensorMovimiento sensor = new SensorMovimiento(
                id: 0,
                nombre: txtNombre.Text,
                encendido: true,
                sensibilidad: 5,
                zonaCobertura: txtNombre.Text
            );
            _controller.AgregarSensorMovimiento(sensor);
        }

        private void AgregarAlarma()
        {
            Alarma alarma = new Alarma(
                id: 0,
                nombre: txtNombre.Text,
                encendido: true,
                estaArmada: false,
                tipoAlarma: TipoAlarma.Intrusion,
                nivelVolumen: 80
            );
            _controller.AgregarAlarma(alarma);
        }

        private void AgregarControlAcceso()
        {
            ControlAcceso control = new ControlAcceso(
                id: 0,
                nombre: txtNombre.Text,
                encendido: true,
                estaBloqueado: true,
                metodoAutenticacion: MetodoAutenticacion.Tarjeta
            );
            _controller.AgregarControlAcceso(control);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Aquí podrías mostrar campos adicionales según el tipo seleccionado
        }
    }
}
