using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Domotica.Controllers;
using Domotica.Models;
using FontAwesome.Sharp;

namespace Domotica.Views
{
    public partial class FormIluminacion : Form
    {
        private readonly IluminacionController _controller;

        // Diccionarios para mapear ID de luz -> controles UI de esa tarjeta
        private Dictionary<int, IconPictureBox> _togglesMap = new Dictionary<int, IconPictureBox>();
        private Dictionary<int, SliderModerno> _slidersMap  = new Dictionary<int, SliderModerno>();
        private Dictionary<int, Label> _lblIntensidadMap    = new Dictionary<int, Label>();
        private Dictionary<int, IconPictureBox> _iconosMap  = new Dictionary<int, IconPictureBox>();

        public FormIluminacion()
        {
            InitializeComponent();
            _controller = IluminacionController.Instancia;
            CargarTarjetas();
        }

        // ==========================================
        // Carga y refresco de tarjetas dinámicas
        // ==========================================

        private void CargarTarjetas()
        {
            flowLayoutPanel1.Controls.Clear();
            _togglesMap.Clear();
            _slidersMap.Clear();
            _lblIntensidadMap.Clear();
            _iconosMap.Clear();

            List<Luz> luces = _controller.ObtenerLuces();
            foreach (Luz luz in luces)
            {
                PanelRedondeado card = CrearTarjetaLuz(luz);
                flowLayoutPanel1.Controls.Add(card);
            }

            ActualizarContador();
        }

        private PanelRedondeado CrearTarjetaLuz(Luz luz)
        {
            // ---- Panel contenedor ----
            PanelRedondeado card = new PanelRedondeado
            {
                BackColor  = Color.Transparent,
                ColorBorde = Color.FromArgb(210, 215, 220),
                ColorFondo = Color.White,
                GrosorBorde = 1,
                RadioBordes = 5,
                Size   = new Size(305, 200),
                Margin = new Padding(5, 5, 20, 20),
                Tag    = luz.Id
            };

            // Menú contextual (Editar / Eliminar)
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add("✏ Editar", null, (s, e) => EditarLuz(luz.Id));
            menu.Items.Add("🗑 Eliminar", null, (s, e) => EliminarLuz(luz.Id));
            card.ContextMenuStrip = menu;

            // ---- Icono bombilla ----
            IconPictureBox iconBulb = new IconPictureBox
            {
                BackColor  = Color.White,
                IconChar   = IconChar.Lightbulb,
                IconColor  = luz.EstaEncendido ? Color.Orange : Color.LightGray,
                IconFont   = luz.EstaEncendido ? IconFont.Solid : IconFont.Regular,
                IconSize   = 20,
                Location   = new Point(15, 20),
                Size       = new Size(22, 22),
                TabStop    = false,
                SizeMode   = System.Windows.Forms.PictureBoxSizeMode.CenterImage
            };
            _iconosMap[luz.Id] = iconBulb;

            // ---- Label nombre ----
            Label lblNombre = new Label
            {
                AutoSize  = true,
                BackColor = Color.White,
                Font      = new Font("Segoe UI", 9.5f),
                ForeColor = Color.FromArgb(44, 62, 80),
                Location  = new Point(42, 20),
                Text      = luz.Nombre
            };

            // ---- Toggle ----
            IconPictureBox toggle = new IconPictureBox
            {
                BackColor  = Color.White,
                IconChar   = luz.EstaEncendido ? IconChar.ToggleOn : IconChar.ToggleOff,
                IconColor  = luz.EstaEncendido ? Color.FromArgb(52, 152, 219) : Color.LightGray,
                ForeColor  = luz.EstaEncendido ? Color.FromArgb(52, 152, 219) : Color.LightGray,
                IconFont   = IconFont.Solid,
                IconSize   = 26,
                Location   = new Point(260, 14),
                Size       = new Size(36, 26),
                Cursor     = Cursors.Hand,
                TabStop    = false,
                Tag        = luz.Id
            };
            toggle.Click += Toggle_Click;
            _togglesMap[luz.Id] = toggle;

            // ---- Label "Brillo" ----
            Label lblBrillo = new Label
            {
                AutoSize  = true,
                BackColor = Color.White,
                Font      = new Font("Segoe UI", 8f),
                ForeColor = Color.Gray,
                Location  = new Point(15, 55),
                Text      = "Brillo"
            };

            // ---- Label % intensidad ----
            Label lblPct = new Label
            {
                AutoSize  = true,
                BackColor = Color.White,
                Font      = new Font("Segoe UI", 8f),
                ForeColor = Color.FromArgb(44, 62, 80),
                Location  = new Point(265, 55),
                Text      = luz.Intensidad + "%",
                TextAlign = ContentAlignment.TopRight
            };
            _lblIntensidadMap[luz.Id] = lblPct;

            // ---- Slider ----
            SliderModerno slider = new SliderModerno
            {
                BackColor        = Color.Transparent,
                ColorBoton       = Color.White,
                ColorPistaLlena  = luz.EstaEncendido
                    ? Color.FromArgb(52, 152, 219)
                    : Color.FromArgb(160, 200, 235),
                ColorPistaVacia  = Color.FromArgb(220, 224, 230),
                Location  = new Point(15, 73),
                Maximo    = 100,
                Minimo    = 0,
                Size      = new Size(275, 25),
                Valor     = luz.Intensidad,
                Enabled   = luz.EstaEncendido,
                Tag       = luz.Id
            };
            slider.ValueChanged += Slider_ValueChanged;
            _slidersMap[luz.Id] = slider;

            // ---- Botones temperatura ----
            Button btnCalido  = CrearBtnTemp("Cálido",  luz.Id, TemperaturaColor.Calido,  new Point(15,  115), luz.TemperaturaColor);
            Button btnFrio    = CrearBtnTemp("Frío",    luz.Id, TemperaturaColor.Frio,    new Point(110, 115), luz.TemperaturaColor);
            Button btnColor   = CrearBtnTemp("Color",   luz.Id, TemperaturaColor.Color,   new Point(205, 115), luz.TemperaturaColor);

            // ---- Separador visual ----
            Panel sep = new Panel
            {
                BackColor = Color.FromArgb(220, 224, 230),
                Location  = new Point(15, 48),
                Size      = new Size(275, 1)
            };

            card.Controls.AddRange(new Control[] {
                iconBulb, lblNombre, toggle,
                sep, lblBrillo, lblPct, slider,
                btnCalido, btnFrio, btnColor
            });

            return card;
        }

        private Button CrearBtnTemp(string texto, int luzId, TemperaturaColor temp, Point ubicacion, TemperaturaColor actual)
        {
            bool activo = actual == temp;
            Button btn = new Button
            {
                BackColor = activo
                    ? Color.FromArgb(52, 152, 219)
                    : Color.FromArgb(248, 249, 250),
                FlatStyle = FlatStyle.Flat,
                Font      = new Font("Segoe UI", 8.5f),
                ForeColor = activo ? Color.White : Color.FromArgb(80, 80, 80),
                Location  = ubicacion,
                Size      = new Size(85, 28),
                Text      = texto,
                Cursor    = Cursors.Hand,
                Tag       = $"{luzId}|{(int)temp}",
                UseVisualStyleBackColor = false
            };
            btn.FlatAppearance.BorderColor = activo
                ? Color.FromArgb(52, 152, 219)
                : Color.FromArgb(220, 224, 230);
            btn.Click += BtnTemperatura_Click;
            return btn;
        }

        // ==========================================
        // Eventos de controles
        // ==========================================

        private void Toggle_Click(object sender, EventArgs e)
        {
            IconPictureBox toggle = sender as IconPictureBox;
            if (toggle == null) return;

            int id = (int)toggle.Tag;
            _controller.ConmutarLuz(id);

            // Refrescar solo esa tarjeta (más eficiente que recargar todo)
            List<Luz> luces = _controller.ObtenerLuces();
            Luz luz = luces.Find(l => l.Id == id);
            if (luz == null) return;

            // Actualizar icono toggle
            toggle.IconChar  = luz.EstaEncendido ? IconChar.ToggleOn  : IconChar.ToggleOff;
            toggle.IconColor = luz.EstaEncendido ? Color.FromArgb(52, 152, 219) : Color.LightGray;
            toggle.ForeColor = toggle.IconColor;

            // Actualizar icono bombilla
            if (_iconosMap.ContainsKey(id))
            {
                _iconosMap[id].IconColor = luz.EstaEncendido ? Color.Orange : Color.LightGray;
                _iconosMap[id].IconFont  = luz.EstaEncendido ? IconFont.Solid : IconFont.Regular;
            }

            // Habilitar/deshabilitar slider
            if (_slidersMap.ContainsKey(id))
                _slidersMap[id].Enabled = luz.EstaEncendido;

            ActualizarContador();
        }

        private void Slider_ValueChanged(object sender, EventArgs e)
        {
            SliderModerno slider = sender as SliderModerno;
            if (slider == null) return;

            int id = (int)slider.Tag;
            _controller.CambiarIntensidad(id, slider.Valor);

            if (_lblIntensidadMap.ContainsKey(id))
                _lblIntensidadMap[id].Text = slider.Valor + "%";
        }

        private void BtnTemperatura_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            string[] partes = btn.Tag.ToString().Split('|');
            int luzId = int.Parse(partes[0]);
            TemperaturaColor temp = (TemperaturaColor)int.Parse(partes[1]);

            _controller.CambiarTemperatura(luzId, temp);

            // Recargar para reflejar el botón activo resaltado
            CargarTarjetas();
        }

        private void btnAgregarLuz_Click(object sender, EventArgs e)
        {
            using (FormAgregarLuz modal = new FormAgregarLuz())
            {
                if (modal.ShowDialog(this) == System.Windows.Forms.DialogResult.OK && modal.LuzResultado != null)
                {
                    _controller.AgregarLuz(modal.LuzResultado);
                    CargarTarjetas();
                }
            }
        }

        private void EditarLuz(int id)
        {
            List<Luz> luces = _controller.ObtenerLuces();
            Luz luz = luces.Find(l => l.Id == id);
            if (luz == null) return;

            using (FormAgregarLuz modal = new FormAgregarLuz(luz))
            {
                if (modal.ShowDialog(this) == System.Windows.Forms.DialogResult.OK && modal.LuzResultado != null)
                {
                    _controller.EditarLuz(modal.LuzResultado);
                    CargarTarjetas();
                }
            }
        }

        private void EliminarLuz(int id)
        {
            List<Luz> luces = _controller.ObtenerLuces();
            Luz luz = luces.Find(l => l.Id == id);
            if (luz == null) return;

            DialogResult res = MessageBox.Show(
                $"¿Deseas eliminar la luz '{luz.Nombre}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                _controller.EliminarLuz(id);
                CargarTarjetas();
            }
        }

        private void ActualizarContador()
        {
            int encendidas = _controller.ContarEncendidas();
            int total      = _controller.ContarTotal();
            lblConnectedLights.Text = $"{encendidas} de {total} Luces Encendidas";
        }
    }
}
