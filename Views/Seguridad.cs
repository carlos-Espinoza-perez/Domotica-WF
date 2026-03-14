using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Domotica.Controllers;
using Domotica.Models;
using Domotica.Views;
using FontAwesome.Sharp;

namespace Domotica.Views
{
    public partial class Seguridad : Form
    {
        private readonly SeguridadController _controller;

        public Seguridad()
        {
            InitializeComponent();
            _controller = SeguridadController.Instancia;
            CargarDatos();
        }

        private void CargarDatos()
        {
            ActualizarContadores();
            ActualizarControlesAcceso();
            ActualizarListaCamaras();
        }

        // ==========================================
        // Actualización de Contadores
        // ==========================================

        private void ActualizarContadores()
        {
            int totalSensoresMovimiento = _controller.ObtenerSensoresMovimiento().Count;
            int totalSensoresPuerta = _controller.ObtenerControlesAcceso().Count;
            int totalCamaras = _controller.ObtenerCamaras().Count;
            int totalCerraduras = _controller.ObtenerControlesAcceso().FindAll(c => c.EstaBloqueado).Count;

            Label4SensoresMovimiento.Text = totalSensoresMovimiento.ToString();
            label6SensoresDePuerta.Text = totalSensoresPuerta.ToString();
            Label3Camaras.Text = totalCamaras.ToString();
            Label2CerradurasInteligentes.Text = totalCerraduras.ToString();
        }

        // ==========================================
        // Control de Acceso
        // ==========================================

        private void ActualizarControlesAcceso()
        {
            List<ControlAcceso> controles = _controller.ObtenerControlesAcceso();
            
            // Limpiar controles existentes en el TableLayoutPanel
            foreach (Control control in tableLayoutPanel2.Controls)
            {
                if (control is Panel panel && panel.Tag != null)
                {
                    panel.Dispose();
                }
            }
            tableLayoutPanel2.Controls.Clear();
            tableLayoutPanel2.RowStyles.Clear();

            // Configurar filas dinámicamente
            int filas = (int)Math.Ceiling(controles.Count / 2.0);
            tableLayoutPanel2.RowCount = filas;
            
            for (int i = 0; i < filas; i++)
            {
                tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            }

            // Agregar controles
            for (int i = 0; i < controles.Count; i++)
            {
                Panel panelControl = CrearPanelControlAcceso(controles[i]);
                int fila = i / 2;
                int columna = i % 2;
                tableLayoutPanel2.Controls.Add(panelControl, columna, fila);
            }
        }

        private Panel CrearPanelControlAcceso(ControlAcceso control)
        {
            Panel panel = new Panel
            {
                BackColor = Color.FromArgb(248, 249, 250),
                Dock = DockStyle.Fill,
                Margin = new Padding(3),
                Tag = control.Id
            };

            Label lblNombre = new Label
            {
                Text = control.Nombre,
                Font = new Font("Segoe UI", 9.5f),
                ForeColor = Color.FromArgb(44, 62, 80),
                Location = new Point(10, 15),
                AutoSize = true,
                BackColor = Color.Transparent
            };

            IconPictureBox toggle = new IconPictureBox
            {
                BackColor = Color.Transparent,
                IconChar = control.EstaBloqueado ? IconChar.ToggleOn : IconChar.ToggleOff,
                IconColor = control.EstaBloqueado ? Color.FromArgb(52, 152, 219) : Color.LightGray,
                IconFont = IconFont.Solid,
                IconSize = 26,
                Location = new Point(panel.Width - 50, 12),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Size = new Size(36, 26),
                Cursor = Cursors.Hand,
                Tag = control.Id
            };
            toggle.Click += ToggleControlAcceso_Click;

            panel.Controls.Add(lblNombre);
            panel.Controls.Add(toggle);

            return panel;
        }

        private void ToggleControlAcceso_Click(object sender, EventArgs e)
        {
            IconPictureBox toggle = sender as IconPictureBox;
            if (toggle == null) return;

            int id = (int)toggle.Tag;
            List<ControlAcceso> controles = _controller.ObtenerControlesAcceso();
            ControlAcceso control = controles.Find(c => c.Id == id);
            
            if (control != null)
            {
                if (control.EstaBloqueado)
                    _controller.DesbloquearAcceso(id);
                else
                    _controller.BloquearAcceso(id);

                ActualizarControlesAcceso();
                ActualizarContadores();
            }
        }

        // ==========================================
        // Feed de Cámaras
        // ==========================================

        private void ActualizarListaCamaras()
        {
            List<Camara> camaras = _controller.ObtenerCamaras();
            
            // Limpiar lista existente
            foreach (Control control in tableLayoutPanel3.Controls)
            {
                if (control is Panel panel && panel.Tag != null)
                {
                    panel.Dispose();
                }
            }
            tableLayoutPanel3.Controls.Clear();
            tableLayoutPanel3.RowStyles.Clear();

            // Configurar filas
            tableLayoutPanel3.RowCount = camaras.Count;
            for (int i = 0; i < camaras.Count; i++)
            {
                tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 45));
            }

            // Agregar cámaras
            for (int i = 0; i < camaras.Count; i++)
            {
                Panel panelCamara = CrearPanelCamara(camaras[i]);
                tableLayoutPanel3.Controls.Add(panelCamara, 0, i);
            }
        }

        private Panel CrearPanelCamara(Camara camara)
        {
            Panel panel = new Panel
            {
                BackColor = Color.FromArgb(248, 249, 250),
                Dock = DockStyle.Fill,
                Margin = new Padding(3),
                Tag = camara.Id
            };

            Label lblNombre = new Label
            {
                Text = camara.Ubicacion,
                Font = new Font("Segoe UI", 9f),
                ForeColor = Color.FromArgb(44, 62, 80),
                Location = new Point(10, 13),
                AutoSize = true,
                BackColor = Color.Transparent
            };

            panel.Controls.Add(lblNombre);
            panel.Cursor = Cursors.Hand;
            panel.Click += (s, e) => SeleccionarCamara(camara);

            return panel;
        }

        private void SeleccionarCamara(Camara camara)
        {
            // Aquí podrías mostrar el feed de la cámara seleccionada
            MessageBox.Show($"Cámara: {camara.Ubicacion}\nEstado: {(camara.EstaGrabando ? "Grabando" : "En espera")}\nResolución: {camara.Resolucion}",
                "Información de Cámara", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ==========================================
        // Toggle Sistema de Seguridad
        // ==========================================

        private void ToggleSistemaSeguridad_Click(object sender, EventArgs e)
        {
            IconPictureBox toggle = sender as IconPictureBox;
            if (toggle == null) return;

            // Aquí podrías implementar la lógica para activar/desactivar todo el sistema
            bool nuevoEstado = toggle.IconChar == IconChar.ToggleOff;
            
            toggle.IconChar = nuevoEstado ? IconChar.ToggleOn : IconChar.ToggleOff;
            toggle.IconColor = nuevoEstado ? Color.FromArgb(52, 152, 219) : Color.LightGray;

            MessageBox.Show($"Sistema de seguridad {(nuevoEstado ? "activado" : "desactivado")}",
                "Sistema de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ==========================================
        // Botón Agregar (Modal)
        // ==========================================

        private void btnArmado_Click(object sender, EventArgs e)
        {
            // Mostrar modal para agregar sensor
            using (FormAgregarSensor formAgregar = new FormAgregarSensor())
            {
                if (formAgregar.ShowDialog() == DialogResult.OK)
                {
                    // Recargar datos después de agregar
                    CargarDatos();
                }
            }
        }
    }
}
