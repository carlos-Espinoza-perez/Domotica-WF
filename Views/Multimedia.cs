using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Domotica.Controllers;
using Domotica.Models;

namespace Domotica.Views
{
    public partial class Multimedia : Form
    {
        private readonly MultimediaController _controller;

        // Diccionarios para mapear ID de dispositivo -> controles UI
        private Dictionary<int, IconPictureBox> _togglesMap = new Dictionary<int, IconPictureBox>();
        private Dictionary<int, SliderModerno> _slidersMap = new Dictionary<int, SliderModerno>();
        private Dictionary<int, Label> _lblVolumenMap = new Dictionary<int, Label>();
        private Dictionary<int, IconPictureBox> _iconosMap = new Dictionary<int, IconPictureBox>();

        public Multimedia()
        {
            InitializeComponent();
            _controller = MultimediaController.Instancia;
            CargarDispositivos();
        }

        // ==========================================
        // Carga y refresco de dispositivos
        // ==========================================

        private void CargarDispositivos()
        {
            flowLayoutPanel1.Controls.Clear();
            _togglesMap.Clear();
            _slidersMap.Clear();
            _lblVolumenMap.Clear();
            _iconosMap.Clear();

            MostrarSistemasMusica();
            MostrarTelevisiones();
        }

        private void MostrarSistemasMusica()
        {
            List<SistemaMusica> sistemas = _controller.ObtenerSistemasMusica();
            foreach (SistemaMusica sistema in sistemas)
            {
                PanelRedondeado card = CrearTarjetaSistemaMusica(sistema);
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void MostrarTelevisiones()
        {
            List<Television> televisiones = _controller.ObtenerTelevisiones();
            foreach (Television tv in televisiones)
            {
                PanelRedondeado card = CrearTarjetaTelevision(tv);
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private PanelRedondeado CrearTarjetaSistemaMusica(SistemaMusica sistema)
        {
            // ---- Panel contenedor ----
            PanelRedondeado card = new PanelRedondeado
            {
                BackColor = Color.Transparent,
                ColorBorde = Color.FromArgb(210, 215, 220),
                ColorFondo = Color.White,
                GrosorBorde = 1,
                RadioBordes = 5,
                Size = new Size(305, 260),
                Margin = new Padding(5, 5, 20, 20),
                Tag = sistema.Id
            };

            // Menú contextual (Editar / Eliminar)
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add("✏ Editar", null, (s, e) => EditarSistemaMusica(sistema.Id));
            menu.Items.Add("🗑 Eliminar", null, (s, e) => EliminarSistemaMusica(sistema.Id));
            card.ContextMenuStrip = menu;

            // ---- Icono música ----
            IconPictureBox iconMusic = new IconPictureBox
            {
                BackColor = Color.White,
                IconChar = IconChar.Music,
                IconColor = sistema.EstaEncendido ? Color.FromArgb(155, 89, 182) : Color.LightGray,
                IconFont = IconFont.Solid,
                IconSize = 20,
                Location = new Point(15, 20),
                Size = new Size(22, 22),
                TabStop = false,
                SizeMode = PictureBoxSizeMode.CenterImage
            };
            _iconosMap[sistema.Id] = iconMusic;

            // ---- Label nombre ----
            Label lblNombre = new Label
            {
                AutoSize = true,
                BackColor = Color.White,
                Font = new Font("Segoe UI", 9.5f),
                ForeColor = Color.FromArgb(44, 62, 80),
                Location = new Point(42, 20),
                Text = sistema.Nombre
            };

            // ---- Toggle ----
            IconPictureBox toggle = new IconPictureBox
            {
                BackColor = Color.White,
                IconChar = sistema.EstaEncendido ? IconChar.ToggleOn : IconChar.ToggleOff,
                IconColor = sistema.EstaEncendido ? Color.FromArgb(155, 89, 182) : Color.LightGray,
                ForeColor = sistema.EstaEncendido ? Color.FromArgb(155, 89, 182) : Color.LightGray,
                IconFont = IconFont.Solid,
                IconSize = 26,
                Location = new Point(260, 14),
                Size = new Size(36, 26),
                Cursor = Cursors.Hand,
                TabStop = false,
                Tag = sistema.Id
            };
            toggle.Click += ToggleMusica_Click;
            _togglesMap[sistema.Id] = toggle;

            // ---- Label "Canción" ----
            Label lblCancion = new Label
            {
                AutoSize = true,
                BackColor = Color.White,
                Font = new Font("Segoe UI", 8f),
                ForeColor = Color.Gray,
                Location = new Point(15, 55),
                Text = "Canción"
            };

            // ---- Label canción actual ----
            Label lblCancionActual = new Label
            {
                BackColor = Color.White,
                Font = new Font("Segoe UI", 8f),
                ForeColor = Color.FromArgb(44, 62, 80),
                Location = new Point(15, 73),
                Size = new Size(275, 30),
                Text = sistema.CancionActual
            };

            // ---- Label "Volumen" ----
            Label lblVolumen = new Label
            {
                AutoSize = true,
                BackColor = Color.White,
                Font = new Font("Segoe UI", 8f),
                ForeColor = Color.Gray,
                Location = new Point(15, 110),
                Text = "Volumen"
            };

            // ---- Label % volumen ----
            Label lblPct = new Label
            {
                AutoSize = true,
                BackColor = Color.White,
                Font = new Font("Segoe UI", 8f),
                ForeColor = Color.FromArgb(44, 62, 80),
                Location = new Point(265, 110),
                Text = sistema.Volumen + "%",
                TextAlign = ContentAlignment.TopRight
            };
            _lblVolumenMap[sistema.Id] = lblPct;

            // ---- Slider volumen ----
            SliderModerno slider = new SliderModerno
            {
                BackColor = Color.Transparent,
                ColorBoton = Color.White,
                ColorPistaLlena = sistema.EstaEncendido
                    ? Color.FromArgb(155, 89, 182)
                    : Color.FromArgb(200, 180, 210),
                ColorPistaVacia = Color.FromArgb(220, 224, 230),
                Location = new Point(15, 128),
                Maximo = 100,
                Minimo = 0,
                Size = new Size(275, 25),
                Valor = sistema.Volumen,
                Enabled = sistema.EstaEncendido,
                Tag = sistema.Id
            };
            slider.ValueChanged += SliderVolumen_ValueChanged;
            _slidersMap[sistema.Id] = slider;

            // ---- Botones de control ----
            Button btnPlay = CrearBotonControl("▶", sistema.Id, "play", new Point(15, 170));
            Button btnPause = CrearBotonControl("⏸", sistema.Id, "pause", new Point(110, 170));
            Button btnStop = CrearBotonControl("⏹", sistema.Id, "stop", new Point(205, 170));

            // ---- Separador visual ----
            Panel sep = new Panel
            {
                BackColor = Color.FromArgb(220, 224, 230),
                Location = new Point(15, 48),
                Size = new Size(275, 1)
            };

            card.Controls.AddRange(new Control[] {
                iconMusic, lblNombre, toggle,
                sep, lblCancion, lblCancionActual,
                lblVolumen, lblPct, slider,
                btnPlay, btnPause, btnStop
            });

            return card;
        }

        private PanelRedondeado CrearTarjetaTelevision(Television tv)
        {
            // ---- Panel contenedor ----
            PanelRedondeado card = new PanelRedondeado
            {
                BackColor = Color.Transparent,
                ColorBorde = Color.FromArgb(210, 215, 220),
                ColorFondo = Color.White,
                GrosorBorde = 1,
                RadioBordes = 5,
                Size = new Size(305, 260),
                Margin = new Padding(5, 5, 20, 20),
                Tag = tv.Id
            };

            // Menú contextual (Editar / Eliminar)
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add("✏ Editar", null, (s, e) => EditarTelevision(tv.Id));
            menu.Items.Add("🗑 Eliminar", null, (s, e) => EliminarTelevision(tv.Id));
            card.ContextMenuStrip = menu;

            // ---- Icono TV ----
            IconPictureBox iconTv = new IconPictureBox
            {
                BackColor = Color.White,
                IconChar = IconChar.Tv,
                IconColor = tv.EstaEncendido ? Color.FromArgb(52, 152, 219) : Color.LightGray,
                IconFont = IconFont.Solid,
                IconSize = 20,
                Location = new Point(15, 20),
                Size = new Size(22, 22),
                TabStop = false,
                SizeMode = PictureBoxSizeMode.CenterImage
            };
            _iconosMap[tv.Id] = iconTv;

            // ---- Label nombre ----
            Label lblNombre = new Label
            {
                AutoSize = true,
                BackColor = Color.White,
                Font = new Font("Segoe UI", 9.5f),
                ForeColor = Color.FromArgb(44, 62, 80),
                Location = new Point(42, 20),
                Text = tv.Nombre
            };

            // ---- Toggle ----
            IconPictureBox toggle = new IconPictureBox
            {
                BackColor = Color.White,
                IconChar = tv.EstaEncendido ? IconChar.ToggleOn : IconChar.ToggleOff,
                IconColor = tv.EstaEncendido ? Color.FromArgb(52, 152, 219) : Color.LightGray,
                ForeColor = tv.EstaEncendido ? Color.FromArgb(52, 152, 219) : Color.LightGray,
                IconFont = IconFont.Solid,
                IconSize = 26,
                Location = new Point(260, 14),
                Size = new Size(36, 26),
                Cursor = Cursors.Hand,
                TabStop = false,
                Tag = tv.Id
            };
            toggle.Click += ToggleTV_Click;
            _togglesMap[tv.Id] = toggle;

            // ---- Label "Canal / Fuente" ----
            Label lblCanal = new Label
            {
                AutoSize = true,
                BackColor = Color.White,
                Font = new Font("Segoe UI", 8f),
                ForeColor = Color.Gray,
                Location = new Point(15, 55),
                Text = "Canal / Fuente"
            };

            // ---- Label canal/fuente actual ----
            string infoCanal = tv.FuenteEntrada == FuenteEntrada.TV
                ? $"Canal {tv.CanalActual}"
                : tv.FuenteEntrada.ToString();
            Label lblCanalActual = new Label
            {
                BackColor = Color.White,
                Font = new Font("Segoe UI", 8f),
                ForeColor = Color.FromArgb(44, 62, 80),
                Location = new Point(15, 73),
                Size = new Size(275, 30),
                Text = infoCanal
            };

            // ---- Label "Volumen" ----
            Label lblVolumen = new Label
            {
                AutoSize = true,
                BackColor = Color.White,
                Font = new Font("Segoe UI", 8f),
                ForeColor = Color.Gray,
                Location = new Point(15, 110),
                Text = "Volumen"
            };

            // ---- Label % volumen ----
            Label lblPct = new Label
            {
                AutoSize = true,
                BackColor = Color.White,
                Font = new Font("Segoe UI", 8f),
                ForeColor = Color.FromArgb(44, 62, 80),
                Location = new Point(265, 110),
                Text = tv.Volumen + "%",
                TextAlign = ContentAlignment.TopRight
            };
            _lblVolumenMap[tv.Id] = lblPct;

            // ---- Slider volumen ----
            SliderModerno slider = new SliderModerno
            {
                BackColor = Color.Transparent,
                ColorBoton = Color.White,
                ColorPistaLlena = tv.EstaEncendido
                    ? Color.FromArgb(52, 152, 219)
                    : Color.FromArgb(160, 200, 235),
                ColorPistaVacia = Color.FromArgb(220, 224, 230),
                Location = new Point(15, 128),
                Maximo = 100,
                Minimo = 0,
                Size = new Size(275, 25),
                Valor = tv.Volumen,
                Enabled = tv.EstaEncendido,
                Tag = tv.Id
            };
            slider.ValueChanged += SliderVolumen_ValueChanged;
            _slidersMap[tv.Id] = slider;

            // ---- Botones de control de canal ----
            Button btnCanalMenos = CrearBotonControl("CH-", tv.Id, "ch-", new Point(15, 170));
            Button btnCanalMas = CrearBotonControl("CH+", tv.Id, "ch+", new Point(110, 170));
            Button btnFuente = CrearBotonControl("Fuente", tv.Id, "source", new Point(205, 170));

            // ---- Separador visual ----
            Panel sep = new Panel
            {
                BackColor = Color.FromArgb(220, 224, 230),
                Location = new Point(15, 48),
                Size = new Size(275, 1)
            };

            card.Controls.AddRange(new Control[] {
                iconTv, lblNombre, toggle,
                sep, lblCanal, lblCanalActual,
                lblVolumen, lblPct, slider,
                btnCanalMenos, btnCanalMas, btnFuente
            });

            return card;
        }

        private Button CrearBotonControl(string texto, int dispositivoId, string accion, Point ubicacion)
        {
            Button btn = new Button
            {
                BackColor = Color.FromArgb(248, 249, 250),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 8.5f),
                ForeColor = Color.FromArgb(80, 80, 80),
                Location = ubicacion,
                Size = new Size(85, 28),
                Text = texto,
                Cursor = Cursors.Hand,
                Tag = $"{dispositivoId}|{accion}",
                UseVisualStyleBackColor = false
            };
            btn.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 230);
            btn.Click += BtnControl_Click;
            return btn;
        }

        // ==========================================
        // Eventos de controles
        // ==========================================

        private void ToggleMusica_Click(object sender, EventArgs e)
        {
            IconPictureBox toggle = sender as IconPictureBox;
            if (toggle == null) return;

            int id = (int)toggle.Tag;
            _controller.ConmutarEstadoMusica(id);

            // Recargar para reflejar cambios
            CargarDispositivos();
        }

        private void ToggleTV_Click(object sender, EventArgs e)
        {
            IconPictureBox toggle = sender as IconPictureBox;
            if (toggle == null) return;

            int id = (int)toggle.Tag;
            _controller.ConmutarEstadoTelevision(id);

            // Recargar para reflejar cambios
            CargarDispositivos();
        }

        private void SliderVolumen_ValueChanged(object sender, EventArgs e)
        {
            SliderModerno slider = sender as SliderModerno;
            if (slider == null) return;

            int id = (int)slider.Tag;
            _controller.CambiarVolumen(id, slider.Valor);

            if (_lblVolumenMap.ContainsKey(id))
                _lblVolumenMap[id].Text = slider.Valor + "%";
        }

        private void BtnControl_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            string[] partes = btn.Tag.ToString().Split('|');
            int id = int.Parse(partes[0]);
            string accion = partes[1];

            switch (accion)
            {
                case "play":
                    _controller.Reproducir(id);
                    CargarDispositivos();
                    break;
                case "pause":
                    _controller.Pausar(id);
                    CargarDispositivos(); // Refrescar para mostrar estado "Pausado" si aplica
                    break;
                case "stop":
                    _controller.Detener(id);
                    CargarDispositivos();
                    break;
                case "ch-":
                    List<Television> tvs = _controller.ObtenerTelevisiones();
                    Television tv = tvs.Find(t => t.Id == id);
                    if (tv != null && tv.CanalActual > 1)
                    {
                        _controller.CambiarCanal(id, tv.CanalActual - 1);
                        CargarDispositivos();
                    }
                    break;
                case "ch+":
                    tvs = _controller.ObtenerTelevisiones();
                    tv = tvs.Find(t => t.Id == id);
                    if (tv != null && tv.CanalActual < 999)
                    {
                        _controller.CambiarCanal(id, tv.CanalActual + 1);
                        CargarDispositivos();
                    }
                    break;
                case "source":
                    // Ciclar entre fuentes de entrada
                    tvs = _controller.ObtenerTelevisiones();
                    tv = tvs.Find(t => t.Id == id);
                    if (tv != null)
                    {
                        FuenteEntrada[] fuentes = (FuenteEntrada[])Enum.GetValues(typeof(FuenteEntrada));
                        int indiceActual = Array.IndexOf(fuentes, tv.FuenteEntrada);
                        int siguienteIndice = (indiceActual + 1) % fuentes.Length;
                        _controller.CambiarFuenteEntrada(id, fuentes[siguienteIndice].ToString());
                        CargarDispositivos();
                    }
                    break;
            }
        }

        private void btnAgregarDispositivo_Click(object sender, EventArgs e)
        {
            // Mostrar menú para elegir tipo de dispositivo
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add("🎵 Sistema de Música", null, (s, ev) => AgregarSistemaMusica());
            menu.Items.Add("📺 Televisión", null, (s, ev) => AgregarTelevision());
            menu.Show(btnAgregarDispositivo, new Point(0, btnAgregarDispositivo.Height));
        }

        // ==========================================
        // CRUD - Sistemas de Música
        // ==========================================

        private void AgregarSistemaMusica()
        {
            using (var form = new FormAgregarMultimedia(false))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _controller.AgregarSistemaMusica(form.MusicaResultado);
                    CargarDispositivos();
                }
            }
        }

        private void EditarSistemaMusica(int id)
        {
            SistemaMusica sm = _controller.ObtenerSistemasMusica().Find(s => s.Id == id);
            if (sm == null) return;

            using (var form = new FormAgregarMultimedia(false, sm))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _controller.EditarSistemaMusica(form.MusicaResultado);
                    CargarDispositivos();
                }
            }
        }

        private void EliminarSistemaMusica(int id)
        {
            List<SistemaMusica> sistemas = _controller.ObtenerSistemasMusica();
            SistemaMusica sistema = sistemas.Find(s => s.Id == id);
            if (sistema == null) return;

            DialogResult res = MessageBox.Show(
                $"¿Deseas eliminar el sistema de música '{sistema.Nombre}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                _controller.EliminarSistemaMusica(id);
                CargarDispositivos();
            }
        }

        // ==========================================
        // CRUD - Televisiones
        // ==========================================

        private void AgregarTelevision()
        {
            using (var form = new FormAgregarMultimedia(true))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _controller.AgregarTelevision(form.TelevisionResultado);
                    CargarDispositivos();
                }
            }
        }

        private void EditarTelevision(int id)
        {
            Television tv = _controller.ObtenerTelevisiones().Find(t => t.Id == id);
            if (tv == null) return;

            using (var form = new FormAgregarMultimedia(true, tv))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _controller.EditarTelevision(form.TelevisionResultado);
                    CargarDispositivos();
                }
            }
        }

        private void EliminarTelevision(int id)
        {
            List<Television> televisiones = _controller.ObtenerTelevisiones();
            Television tv = televisiones.Find(t => t.Id == id);
            if (tv == null) return;

            DialogResult res = MessageBox.Show(
                $"¿Deseas eliminar la televisión '{tv.Nombre}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                _controller.EliminarTelevision(id);
                CargarDispositivos();
            }
        }
    }
}
