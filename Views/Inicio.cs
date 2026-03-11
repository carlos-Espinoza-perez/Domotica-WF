using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Domotica.Controllers;
using Domotica.Models;

namespace Domotica.Views
{
    public partial class Inicio : Form
    {
        private readonly InicioController _inicioController;
        private readonly IluminacionController _iluminacionController;
        private System.Windows.Forms.Timer _reloj;

        public Inicio()
        {
            InitializeComponent();

            _inicioController = InicioController.Instancia;
            _iluminacionController = IluminacionController.Instancia;

            IniciarReloj();
            CargarDatos();
            ConfigurarEventos();
        }

        private void ConfigurarEventos()
        {
            // Botones de luces
            button5.Click += (s, e) => { _inicioController.ConmutarControlRapido("Sala de Estar"); CargarDatos(); };
            button6.Click += (s, e) => { _inicioController.ConmutarControlRapido("Cocina"); CargarDatos(); };
            button7.Click += (s, e) => { _inicioController.ConmutarControlRapido("Exterior"); CargarDatos(); };
            
            // Seguridad
            button8.Click += (s, e) => { _inicioController.ConmutarControlRapido("Puerta Principal"); CargarDatos(); };
            
            // Multimedia
            button9.Click += (s, e) => { _inicioController.ConmutarControlRapido("Música"); CargarDatos(); };
            button10.Click += (s, e) => { _inicioController.ConmutarControlRapido("Televisión"); CargarDatos(); };

            // Termostato
            sliderModerno1.ValueChanged += (s, e) => { 
                var termostatos = ClimaController.Instancia.ObtenerTermostatos();
                if (termostatos.Count > 0) {
                    ClimaController.Instancia.CambiarTemperaturaObjetivo(termostatos[0].Id, sliderModerno1.Valor);
                    label26.Text = $"{sliderModerno1.Valor:F1} °C";
                }
            };
            
            button11.Click += (s, e) => CambiarModoTermostato("Refrigeracion");
            button12.Click += (s, e) => CambiarModoTermostato("Calefaccion");
            button13.Click += (s, e) => CambiarModoTermostato("Auto");
        }

        private void CambiarModoTermostato(string modo)
        {
            var termostatos = ClimaController.Instancia.ObtenerTermostatos();
            if (termostatos.Count > 0)
            {
                var id = termostatos[0].Id;
                ClimaController.Instancia.CambiarModoOperacion(id, modo);

                // Lógica inteligente: ajustar temperatura según modo
                double nuevaTemp = 22.0;
                switch (modo.ToLower())
                {
                    case "refrigeracion": nuevaTemp = 18.0; break;
                    case "calefaccion": nuevaTemp = 26.0; break;
                    case "auto": nuevaTemp = 22.0; break;
                }

                ClimaController.Instancia.CambiarTemperaturaObjetivo(id, nuevaTemp);
                
                // Actualizar UI inmediatamente
                sliderModerno1.Valor = (int)nuevaTemp;
                label26.Text = $"{nuevaTemp:F1} °C";

                MessageBox.Show($"Modo cambiado a {modo} y temperatura ajustada a {nuevaTemp}°C", "Termostato", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CargarDatos()
        {
            // Sensores principales
            var temp = _inicioController.ObtenerResumenSensor("Temperatura");
            if (temp != null) label12.Text = $"{temp.Valor:F1} °C";

            var hum = _inicioController.ObtenerResumenSensor("Humedad");
            if (hum != null) label3.Text = $"{hum.Valor}%";

            var energy = _inicioController.ObtenerResumenSensor("Energía");
            if (energy != null) label13.Text = $"{energy.Valor}W";

            var seg = _inicioController.ObtenerResumenSensor("Seguridad");
            if (seg != null) label16.Text = seg.Estado;

            // Controles rápidos (sincronizar colores y texto)
            ActualizarEstadoBoton(button5, "Sala de Estar");
            ActualizarEstadoBoton(button6, "Cocina");
            ActualizarEstadoBoton(button7, "Exterior");
            ActualizarEstadoBoton(button8, "Puerta Principal");
            ActualizarEstadoBoton(button9, "Música");
            ActualizarEstadoBoton(button10, "Televisión");

            // Termostato inicial
            var term = ClimaController.Instancia.ObtenerTermostatos().FirstOrDefault();
            if (term != null)
            {
                sliderModerno1.Valor = (int)term.TemperaturaObjetivo;
                label26.Text = $"{term.TemperaturaObjetivo:F1} °C";
            }
        }

        private void ActualizarEstadoBoton(Button btn, string nombre)
        {
            var controles = _inicioController.ObtenerControlesRapidos();
            var item = controles.Find(c => c.Nombre == nombre);
            if (item != null)
            {
                btn.Text = item.EstaEncendido ? (nombre == "Puerta Principal" ? "Abierta" : "Encendido") : (nombre == "Puerta Principal" ? "Bloqueada" : "Apagado");
                btn.BackColor = item.EstaEncendido ? Color.FromArgb(52, 152, 219) : Color.White;
                btn.ForeColor = item.EstaEncendido ? Color.White : Color.Gray;
            }
        }

        // Reloj en tiempo real para el label de hora de la vista
        private void IniciarReloj()
        {
            _reloj = new System.Windows.Forms.Timer();
            _reloj.Interval = 1000;
            _reloj.Tick += Reloj_Tick;
            _reloj.Start();

            // Forzar primera actualización
            ActualizarHora();
        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            ActualizarHora();
            // Actualizar sensores cada minuto o según se requiera
            if (DateTime.Now.Second == 0) CargarDatos();
        }

        private void ActualizarHora()
        {
            // label7 es el reloj grande, label8 es la fecha
            if (label7 != null)
            {
                label7.Text = DateTime.Now.ToString("hh:mm tt").ToUpper();
            }
            if (label8 != null)
            {
                // Formato: Martes, 10 de Marzo del 2026
                label8.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'del' yyyy", new System.Globalization.CultureInfo("es-ES"));
                // Capitalizar primera letra
                if (label8.Text.Length > 0)
                    label8.Text = char.ToUpper(label8.Text[0]) + label8.Text.Substring(1);
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _reloj?.Stop();
            _reloj?.Dispose();
            base.OnFormClosed(e);
        }

        private void iconPictureBox1_Click(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void panelRedondeado13_Paint(object sender, PaintEventArgs e) { }
        private void button13_Click(object sender, EventArgs e) { }
    }
}
