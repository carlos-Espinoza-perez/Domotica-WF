using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class PanelRedondeado : Panel
{
    // Codigo realizado por IA, basado en el diseño CSS de la tarjeta que se muestra en el proyecto.
    // --- Propiedades que aparecerán en el diseñador ---

    private int radioBordes = 15;
    [Category("Tarjeta"), Description("Radio de las esquinas redondeadas (px)")]
    public int RadioBordes
    {
        get { return radioBordes; }
        set { radioBordes = value; this.Invalidate(); } // Se redibuja al cambiar
    }

    private int tamañoSombra = 6; // Grosor visual de la sombra
    [Category("Tarjeta"), Description("Grosor de la sombra (px)")]
    public int TamañoSombra
    {
        get { return tamañoSombra; }
        set { tamañoSombra = value; ActualizarMargen(); this.Invalidate(); }
    }

    private Color colorTarjeta = Color.White;
    [Category("Tarjeta"), Description("Color del fondo de la tarjeta")]
    public Color ColorTarjeta
    {
        get { return colorTarjeta; }
        set { colorTarjeta = value; this.Invalidate(); }
    }

    // --- Constructor ---
    public PanelRedondeado()
    {
        this.DoubleBuffered = true; // Evita el parpadeo
        this.BackColor = Color.Transparent; // El fondo "real" es transparente
        ActualizarMargen(); // Deja espacio para la sombra
    }

    // Método para dejar un margen interno (Padding) automático
    // así el contenido no pisa la sombra ni los bordes redondeados.
    private void ActualizarMargen()
    {
        // Dejamos un margen proporcional al tamaño de la sombra
        int margen = TamañoSombra + 2;
        this.Padding = new Padding(margen);
    }

    // --- Método de Dibujo Principal ---
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias; // Curvas perfectas sin pixelar

        // 1. Calculamos el área real de la tarjeta blanca (sin la sombra)
        // La desplazamos 1px hacia abajo para simular la luz (box-shadow CSS y=1px)
        int xOffset = 0;
        int yOffset = 1;

        Rectangle areaTarjeta = new Rectangle(
            TamañoSombra / 2 + xOffset,
            TamañoSombra / 2 + yOffset,
            this.Width - TamañoSombra - 1,
            this.Height - TamañoSombra - 2
        );

        // Si el radio es 0, dibujamos un rectángulo normal (con sombra)
        if (RadioBordes <= 0)
        {
            // --- DIBUJAR SOMBRA RECTANGULAR ---
            using (SolidBrush brochaSombra = new SolidBrush(Color.FromArgb(25, 0, 0, 0))) // Negro 10%
            {
                g.FillRectangle(brochaSombra, areaTarjeta);
            }
            // --- DIBUJAR TARJETA RECTANGULAR ---
            using (SolidBrush brochaTarjeta = new SolidBrush(ColorTarjeta))
            {
                g.FillRectangle(brochaTarjeta, areaTarjeta);
            }
            return;
        }

        // --- DIBUJAR SOMBRA REDONDEADA (Simulación de desenfoque/blur) ---
        // Dibujamos capas transparentes concéntricas para simular el blur de 3px del CSS
        int alphaMaximoSombra = 20; // Opacidad muy baja (negro 8%)

        for (int i = TamañoSombra; i >= 1; i--)
        {
            using (GraphicsPath pathSombra = ObtenerPathRedondeado(
                new Rectangle(areaTarjeta.X - i, areaTarjeta.Y - i + 1, areaTarjeta.Width + (i * 2), areaTarjeta.Height + (i * 2)),
                RadioBordes + i))
            {
                // La opacidad baja a medida que se aleja del centro
                int alpha = Math.Max(0, alphaMaximoSombra - (i * 2));
                using (SolidBrush brochaSombra = new SolidBrush(Color.FromArgb(alpha, 0, 0, 0)))
                {
                    g.FillPath(brochaSombra, pathSombra);
                }
            }
        }

        // --- DIBUJAR TARJETA REDONDEADA (Fondo blanco sólido) ---
        using (GraphicsPath pathTarjeta = ObtenerPathRedondeado(areaTarjeta, RadioBordes))
        {
            using (SolidBrush brochaTarjeta = new SolidBrush(ColorTarjeta))
            {
                g.FillPath(brochaTarjeta, pathTarjeta);
            }
        }
    }

    // Función matemática para generar la figura redondeada con los 4 arcos
    private GraphicsPath ObtenerPathRedondeado(Rectangle rect, int radio)
    {
        GraphicsPath path = new GraphicsPath();

        // El radio no puede ser mayor a la mitad del tamaño de la tarjeta
        int diametro = Math.Min(radio * 2, Math.Min(rect.Width, rect.Height));
        if (diametro <= 0) { path.AddRectangle(rect); return path; }

        Rectangle arcRect = new Rectangle(rect.X, rect.Y, diametro, diametro);

        // Arriba Izquierda
        path.AddArc(arcRect, 180, 90);
        // Arriba Derecha
        arcRect.X = rect.Right - diametro;
        path.AddArc(arcRect, 270, 90);
        // Abajo Derecha
        arcRect.Y = rect.Bottom - diametro;
        path.AddArc(arcRect, 0, 90);
        // Abajo Izquierda
        arcRect.X = rect.Left;
        path.AddArc(arcRect, 90, 90);

        path.CloseFigure();
        return path;
    }
}