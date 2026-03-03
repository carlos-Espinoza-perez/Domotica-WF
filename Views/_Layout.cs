using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domotica.Views
{
    public partial class _Layout : Form
    {
        public _Layout()
        {
            InitializeComponent();

            AbrirFormEnPanel(new Inicio());
            ActivarBotonMenu(sidebar_opt_inicio);

            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                  ControlStyles.UserPaint |
                  ControlStyles.DoubleBuffer, true);
        }

        private void ButtonToggleSideBar_Click(object sender, EventArgs e)
        {
            if (!timerSideBar.Enabled)
            {
                timerSideBar.Start();
            }
        }


        bool sidebarExpandida = true; // Estado inicial
        const int anchoMax = 230;     // Ancho del panel abierto
        const int anchoMin = 0;       // Ancho del panel cerrado
        const int velocidad = 20;     // Cuántos píxeles se mueve por tick

        private void timerSideBar_Tick(object sender, EventArgs e)
        {
            if (sidebarExpandida) 
            {
                SideBar.Width -= velocidad;
                if (SideBar.Width <= anchoMin)
                {
                    SideBar.Width = anchoMin;
                    timerSideBar.Stop();
                    sidebarExpandida = false; 
                }
            }
            else 
            {
                SideBar.Width += velocidad;
                if (SideBar.Width >= anchoMax)
                {
                    SideBar.Width = anchoMax;
                    timerSideBar.Stop();
                    sidebarExpandida = true; 
                }
            }
        }




        // Mouse hover en los paneles del sidebar
        private void SetBackgroundToHover(object sender, EventArgs e)
        {
            Control control = sender as Control;

            Panel panel = control as Panel ?? control.Parent as Panel;

            if (panel != null)
            {
                panel.BackColor = Color.FromArgb(52, 73, 94);
            }
        }

        private void RemoveBackgroundToHover(object sender, EventArgs e)
        {
            Control control = sender as Control;
            Panel panel = control as Panel ?? control.Parent as Panel;

            if (panel.Name == botonActivo?.Name) // Si es el botón activo, no cambiamos el color
                return;

            if (panel != null)
            {
                Point posicionRaton = panel.PointToClient(Cursor.Position);

                if (!panel.ClientRectangle.Contains(posicionRaton))
                {
                    panel.BackColor = Color.Transparent;
                }
            }
        }


        // Manejo de vistas en el panel principal
        private Panel botonActivo = null;

        private void ActivarBotonMenu(Panel panelSeleccionado)
        {
            if (botonActivo != null && botonActivo != panelSeleccionado)
            {
                botonActivo.BackColor = Color.Transparent;
            }

            botonActivo = panelSeleccionado;
            botonActivo.BackColor = Color.FromArgb(52, 73, 94);
        }

        private void AbrirFormEnPanel(object formHijo)
        {
            if (this.PanelContenido.Controls.Count > 0)
                this.PanelContenido.Controls.RemoveAt(0);

            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;

            this.PanelContenido.Controls.Add(fh);
            this.PanelContenido.Tag = fh;
            fh.Show();
        }

        private void sidebar_opt_inicio_Click(object sender, EventArgs e)
        {
            ActivarBotonMenu(sidebar_opt_inicio); // Pasamos el panel exacto
            AbrirFormEnPanel(new Inicio());
        }

        private void sidebar_opt_iluminacion_Click(object sender, EventArgs e)
        {
            ActivarBotonMenu(sidebar_opt_iluminacion);
            AbrirFormEnPanel(new Iluminacion());
        }

        private void sidebar_opt_clima_Click(object sender, EventArgs e)
        {
            ActivarBotonMenu(sidebar_opt_clima);
            AbrirFormEnPanel(new Clima());
        }

        private void sidebar_opt_seguridad_Click(object sender, EventArgs e)
        {
            ActivarBotonMenu(sidebar_opt_seguridad);
            AbrirFormEnPanel(new Seguridad());
        }

        private void sidebar_opt_multimedia_Click(object sender, EventArgs e)
        {
            ActivarBotonMenu(sidebar_opt_multimedia);
            AbrirFormEnPanel(new Multimedia());
        }


    }
}
