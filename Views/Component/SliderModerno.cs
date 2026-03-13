using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class SliderModerno : Control
{
    // --- Evento para detectar cuando el usuario mueve el slider ---
    public event EventHandler ValueChanged;

    // --- Propiedades ---
    private int _minimo = 0;
    public int Minimo { get { return _minimo; } set { _minimo = value; Invalidate(); } }

    private int _maximo = 100;
    public int Maximo { get { return _maximo; } set { _maximo = value; Invalidate(); } }

    private int _valor = 50;
    public int Valor
    {
        get { return _valor; }
        set
        {
            // Aseguramos que el valor no se salga de los límites
            _valor = Math.Max(_minimo, Math.Min(_maximo, value));
            ValueChanged?.Invoke(this, EventArgs.Empty);
            Invalidate();
        }
    }

    // Colores personalizables
    public Color ColorPistaVacia { get; set; } = Color.FromArgb(220, 224, 230); // Gris claro
    public Color ColorPistaLlena { get; set; } = Color.FromArgb(52, 152, 219);  // Azul estilo domótica
    public Color ColorBoton { get; set; } = Color.White;

    // Variables internas para el ratón
    private bool arrastrando = false;
    private int tamañoBoton = 16;
    private int altoPista = 12;

    public SliderModerno()
    {
        SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        SetStyle(ControlStyles.UserPaint, true);

        // 2. Aplicamos el fondo transparente
        this.BackColor = Color.Transparent;


        this.DoubleBuffered = true;
        this.Height = 30; // Altura por defecto
        this.Cursor = Cursors.Hand;
    }

    // --- Dibujo del control ---
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        int centroY = this.Height / 2;
        int margen = tamañoBoton / 2;
        int anchoUtil = this.Width - (margen * 2);

        // 1. Dibujar la pista gris (Fondo)
        using (Pen penFondo = new Pen(ColorPistaVacia, altoPista) { StartCap = LineCap.Round, EndCap = LineCap.Round })
        {
            g.DrawLine(penFondo, margen, centroY, this.Width - margen, centroY);
        }

        // 2. Calcular la posición del botón basada en el Valor actual
        float porcentaje = (float)(Valor - Minimo) / (Maximo - Minimo);
        int posicionX = margen + (int)(porcentaje * anchoUtil);

        // 3. Dibujar la pista azul (Llena)
        if (posicionX > margen)
        {
            using (Pen penLleno = new Pen(ColorPistaLlena, altoPista) { StartCap = LineCap.Round, EndCap = LineCap.Round })
            {
                g.DrawLine(penLleno, margen, centroY, posicionX, centroY);
            }
        }

        // 4. Dibujar el Botón (Thumb)
        Rectangle rectBoton = new Rectangle(posicionX - margen, centroY - margen, tamañoBoton, tamañoBoton);

        using (SolidBrush brochaBoton = new SolidBrush(ColorBoton))
        using (Pen bordeBoton = new Pen(Color.FromArgb(180, 180, 180), 1)) // Borde gris sutil
        {
            g.FillEllipse(brochaBoton, rectBoton);
            g.DrawEllipse(bordeBoton, rectBoton);
        }
    }

    // --- Lógica del Ratón ---
    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);
        if (e.Button == MouseButtons.Left)
        {
            arrastrando = true;
            ActualizarValorDesdeRaton(e.X);
        }
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
        base.OnMouseMove(e);
        if (arrastrando)
        {
            ActualizarValorDesdeRaton(e.X);
        }
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
        base.OnMouseUp(e);
        arrastrando = false;
    }

    private void ActualizarValorDesdeRaton(int mouseX)
    {
        int margen = tamañoBoton / 2;
        int anchoUtil = this.Width - (margen * 2);

        // Evitar divisiones por cero o posiciones fuera de control
        if (anchoUtil <= 0) return;

        // Calcular el nuevo valor basado en la posición X del ratón
        float porcentaje = (float)(mouseX - margen) / anchoUtil;
        porcentaje = Math.Max(0, Math.Min(1, porcentaje)); // Limitar entre 0 y 1

        this.Valor = Minimo + (int)(porcentaje * (Maximo - Minimo));
    }
}