using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class PanelRedondeado : Panel
{
    // --- Propiedades Configurables ---
    private int radioBordes = 15;
    [Category("Tarjeta"), Description("Radio de las esquinas redondeadas (px)")]
    public int RadioBordes
    {
        get { return radioBordes; }
        set { radioBordes = value; this.Invalidate(); }
    }

    private Color colorFondo = Color.White;
    [Category("Tarjeta"), Description("Color de fondo del panel")]
    public Color ColorFondo
    {
        get { return colorFondo; }
        set { colorFondo = value; this.Invalidate(); }
    }

    private int grosorBorde = 1;
    [Category("Tarjeta"), Description("Grosor del borde en píxeles")]
    public int GrosorBorde
    {
        get { return grosorBorde; }
        set { grosorBorde = value; this.Invalidate(); }
    }

    // Color gris sutil por defecto para el borde (LightGray o un tono personalizado)
    private Color colorBorde = Color.FromArgb(200, 200, 200);
    [Category("Tarjeta"), Description("Color del borde")]
    public Color ColorBorde
    {
        get { return colorBorde; }
        set { colorBorde = value; this.Invalidate(); }
    }

    public PanelRedondeado()
    {
        this.DoubleBuffered = true;
        this.BackColor = Color.Transparent; // Necesario para que las esquinas no se vean cuadradas

        this.ResizeRedraw = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias; // Evita bordes pixelados

        // Calculamos el área del panel dejando espacio para el grosor del borde
        Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

        if (RadioBordes > 0)
        {
            using (GraphicsPath path = ObtenerPathRedondeado(rect, RadioBordes))
            {
                // 1. Pintamos el fondo de la tarjeta
                using (SolidBrush brochaFondo = new SolidBrush(ColorFondo))
                {
                    g.FillPath(brochaFondo, path);
                }

                // 2. Dibujamos la línea del borde gris
                if (GrosorBorde > 0)
                {
                    using (Pen lapizBorde = new Pen(ColorBorde, GrosorBorde))
                    {
                        g.DrawPath(lapizBorde, path);
                    }
                }
            }
        }
        else
        {
            // Si el radio es 0, dibujamos un rectángulo normal
            using (SolidBrush brochaFondo = new SolidBrush(ColorFondo))
            {
                g.FillRectangle(brochaFondo, rect);
            }
            if (GrosorBorde > 0)
            {
                using (Pen lapizBorde = new Pen(ColorBorde, GrosorBorde))
                {
                    g.DrawRectangle(lapizBorde, rect);
                }
            }
        }
    }

    private GraphicsPath ObtenerPathRedondeado(Rectangle rect, int radio)
    {
        GraphicsPath path = new GraphicsPath();
        float d = radio * 2F;

        // Dibujamos los 4 arcos de las esquinas
        path.AddArc(rect.X, rect.Y, d, d, 180, 90);
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
        path.CloseFigure();

        return path;
    }
}