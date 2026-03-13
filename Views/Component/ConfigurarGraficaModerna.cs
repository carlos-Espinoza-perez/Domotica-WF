using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class GraficaTendencia : Control
{
    // Datos y etiquetas por defecto (Iguales a tu diseño)
    public List<int> Valores { get; set; } = new List<int> { 22, 20, 23, 26, 25, 23 };
    public List<string> Horas { get; set; } = new List<string> { "00:00", "04:00", "08:00", "12:00", "16:00", "20:00" };

    // Configuración visual
    private int valorMaximo = 28;
    private Color colorLinea = Color.FromArgb(52, 152, 219); // Azul Domótica
    private Font fuenteEjes = new Font("Segoe UI", 9f);
    private Color colorTexto = Color.DimGray;
    private Color colorCuadricula = Color.FromArgb(220, 220, 220);

    public GraficaTendencia()
    {
        // 1. Le damos permiso explícito al control para manejar transparencias
        SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        SetStyle(ControlStyles.UserPaint, true);

        // 2. Ahora sí, aplicamos el fondo y las configuraciones base
        this.BackColor = Color.Transparent; // ¡Ya no lanzará error!
        this.DoubleBuffered = true;
        this.ResizeRedraw = true;
        this.MinimumSize = new Size(200, 100);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

        // 1. Calcular márgenes para dejar espacio a los textos
        int margenIzq = 35;
        int margenInf = 25;
        int margenSup = 10;
        int margenDer = 10;

        Rectangle areaGrafica = new Rectangle(
            margenIzq,
            margenSup,
            this.Width - margenIzq - margenDer,
            this.Height - margenSup - margenInf
        );

        // Si el área es muy pequeña, no dibujamos para evitar errores matemáticos
        if (areaGrafica.Width <= 0 || areaGrafica.Height <= 0) return;

        // 2. Dibujar la cuadrícula y etiquetas del Eje Y (28, 21, 14, 7, 0)
        int[] pasosY = { 28, 21, 14, 7, 0 };
        using (Pen penCuadricula = new Pen(colorCuadricula, 1) { DashStyle = DashStyle.Dash })
        using (SolidBrush brochaTexto = new SolidBrush(colorTexto))
        using (StringFormat formatoY = new StringFormat { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Center })
        {
            foreach (int paso in pasosY)
            {
                // Calcular la posición Y en píxeles
                float posY = areaGrafica.Bottom - ((float)paso / valorMaximo) * areaGrafica.Height;

                // Dibujar línea punteada
                g.DrawLine(penCuadricula, areaGrafica.Left, posY, areaGrafica.Right, posY);

                // Dibujar el número (Ej: "28")
                g.DrawString(paso.ToString(), fuenteEjes, brochaTexto, new RectangleF(0, posY - 10, margenIzq - 5, 20), formatoY);
            }

            // 3. Dibujar Eje X (Horas) y sus líneas verticales
            float xStep = (float)areaGrafica.Width / (Horas.Count - 1);
            using (StringFormat formatoX = new StringFormat { Alignment = StringAlignment.Center })
            {
                for (int i = 0; i < Horas.Count; i++)
                {
                    float posX = areaGrafica.Left + (i * xStep);

                    // Línea vertical punteada
                    g.DrawLine(penCuadricula, posX, areaGrafica.Top, posX, areaGrafica.Bottom);

                    // Texto de la hora (Ej: "04:00")
                    g.DrawString(Horas[i], fuenteEjes, brochaTexto, new RectangleF(posX - 25, areaGrafica.Bottom + 5, 50, 20), formatoX);
                }
            }
        }

        // 4. Calcular los puntos exactos de la curva basados en los Valores
        PointF[] puntos = new PointF[Valores.Count];
        float stepX = (float)areaGrafica.Width / (Valores.Count - 1);

        for (int i = 0; i < Valores.Count; i++)
        {
            float x = areaGrafica.Left + (i * stepX);
            // Invertimos la Y porque en pantallas el Y=0 está arriba
            float y = areaGrafica.Bottom - ((float)Valores[i] / valorMaximo) * areaGrafica.Height;
            puntos[i] = new PointF(x, y);
        }

        // 5. Dibujar el Relleno Degradado debajo de la curva
        using (GraphicsPath pathArea = new GraphicsPath())
        {
            // Agregamos la curva suave (0.3f es la tensión perfecta para que no haga picos raros)
            pathArea.AddCurve(puntos, 0.3f);

            // Cerramos la figura bajando hasta el eje X
            pathArea.AddLine(puntos[puntos.Length - 1].X, areaGrafica.Bottom, puntos[0].X, areaGrafica.Bottom);
            pathArea.CloseFigure();

            // Degradado de azul al 60% de opacidad hacia blanco/transparente
            using (LinearGradientBrush brochaDegradado = new LinearGradientBrush(
                areaGrafica,
                Color.FromArgb(150, colorLinea),
                Color.FromArgb(10, colorLinea),
                90f))
            {
                g.FillPath(brochaDegradado, pathArea);
            }
        }

        // 6. Dibujar la línea sólida superior de la curva
        using (Pen penCurva = new Pen(colorLinea, 2f))
        {
            g.DrawCurve(penCurva, puntos, 0.3f);
        }
    }
}