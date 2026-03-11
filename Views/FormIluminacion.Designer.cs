namespace Domotica.Views
{
    partial class FormIluminacion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblConnectedLights = new System.Windows.Forms.Label();
            this.btnAgregarLuz = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelRedondeadoSala = new PanelRedondeado();
            this.btnSalaColor = new System.Windows.Forms.Button();
            this.btnSalaFrio = new System.Windows.Forms.Button();
            this.btnSalaCalido = new System.Windows.Forms.Button();
            this.lblSalaIntensidad = new System.Windows.Forms.Label();
            this.sliderSalaIntensidad = new SliderModerno();
            this.lblSalaBrilloText = new System.Windows.Forms.Label();
            this.iconToggleSala = new FontAwesome.Sharp.IconPictureBox();
            this.lblSalaTitle = new System.Windows.Forms.Label();
            this.iconSala = new FontAwesome.Sharp.IconPictureBox();
            this.panelRedondeadoCocina = new PanelRedondeado();
            this.btnCocinaColor = new System.Windows.Forms.Button();
            this.btnCocinaFrio = new System.Windows.Forms.Button();
            this.btnCocinaCalido = new System.Windows.Forms.Button();
            this.lblCocinaIntensidad = new System.Windows.Forms.Label();
            this.sliderCocinaIntensidad = new SliderModerno();
            this.lblCocinaBrilloText = new System.Windows.Forms.Label();
            this.iconToggleCocina = new FontAwesome.Sharp.IconPictureBox();
            this.lblCocinaTitle = new System.Windows.Forms.Label();
            this.iconCocina = new FontAwesome.Sharp.IconPictureBox();
            this.panelRedondeadoDormitorio = new PanelRedondeado();
            this.btnDormitorioColor = new System.Windows.Forms.Button();
            this.btnDormitorioFrio = new System.Windows.Forms.Button();
            this.btnDormitorioCalido = new System.Windows.Forms.Button();
            this.lblDormitorioIntensidad = new System.Windows.Forms.Label();
            this.sliderDormitorioIntensidad = new SliderModerno();
            this.lblDormitorioBrilloText = new System.Windows.Forms.Label();
            this.iconToggleDormitorio = new FontAwesome.Sharp.IconPictureBox();
            this.lblDormitorioTitle = new System.Windows.Forms.Label();
            this.iconDormitorio = new FontAwesome.Sharp.IconPictureBox();
            this.panelRedondeadoExterior = new PanelRedondeado();
            this.btnExteriorColor = new System.Windows.Forms.Button();
            this.btnExteriorFrio = new System.Windows.Forms.Button();
            this.btnExteriorCalido = new System.Windows.Forms.Button();
            this.lblExteriorIntensidad = new System.Windows.Forms.Label();
            this.sliderExteriorIntensidad = new SliderModerno();
            this.lblExteriorBrilloText = new System.Windows.Forms.Label();
            this.iconToggleExterior = new FontAwesome.Sharp.IconPictureBox();
            this.lblExteriorTitle = new System.Windows.Forms.Label();
            this.iconExterior = new FontAwesome.Sharp.IconPictureBox();
            this.panelHeader.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelRedondeadoSala.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconToggleSala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSala)).BeginInit();
            this.panelRedondeadoCocina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconToggleCocina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCocina)).BeginInit();
            this.panelRedondeadoDormitorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconToggleDormitorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconDormitorio)).BeginInit();
            this.panelRedondeadoExterior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconToggleExterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExterior)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.Controls.Add(this.lblHeaderTitle);
            this.panelHeader.Controls.Add(this.lblConnectedLights);
            this.panelHeader.Controls.Add(this.btnAgregarLuz);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(27, 25);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1508, 40);
            this.panelHeader.TabIndex = 0;
            // 
            // btnAgregarLuz
            // 
            this.btnAgregarLuz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarLuz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAgregarLuz.FlatAppearance.BorderSize = 0;
            this.btnAgregarLuz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarLuz.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAgregarLuz.ForeColor = System.Drawing.Color.White;
            this.btnAgregarLuz.Location = new System.Drawing.Point(1254, 5);
            this.btnAgregarLuz.Name = "btnAgregarLuz";
            this.btnAgregarLuz.Size = new System.Drawing.Size(120, 28);
            this.btnAgregarLuz.TabIndex = 2;
            this.btnAgregarLuz.Text = "+ Agregar Luz";
            this.btnAgregarLuz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarLuz.UseVisualStyleBackColor = false;
            this.btnAgregarLuz.Click += new System.EventHandler(this.btnAgregarLuz_Click);
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(0, 5);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(168, 21);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Control de Iluminación";
            // 
            // lblConnectedLights
            // 
            this.lblConnectedLights.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConnectedLights.AutoSize = true;
            this.lblConnectedLights.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConnectedLights.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblConnectedLights.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblConnectedLights.Location = new System.Drawing.Point(1382, 5);
            this.lblConnectedLights.Name = "lblConnectedLights";
            this.lblConnectedLights.Padding = new System.Windows.Forms.Padding(5);
            this.lblConnectedLights.Size = new System.Drawing.Size(123, 27);
            this.lblConnectedLights.TabIndex = 1;
            this.lblConnectedLights.Text = "6 Luces Conectadas";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panelRedondeadoSala);
            this.flowLayoutPanel1.Controls.Add(this.panelRedondeadoCocina);
            this.flowLayoutPanel1.Controls.Add(this.panelRedondeadoDormitorio);
            this.flowLayoutPanel1.Controls.Add(this.panelRedondeadoExterior);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(27, 65);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1508, 575);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panelRedondeadoSala
            // 
            this.panelRedondeadoSala.BackColor = System.Drawing.Color.Transparent;
            this.panelRedondeadoSala.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(220)))));
            this.panelRedondeadoSala.ColorFondo = System.Drawing.Color.White;
            this.panelRedondeadoSala.Controls.Add(this.btnSalaColor);
            this.panelRedondeadoSala.Controls.Add(this.btnSalaFrio);
            this.panelRedondeadoSala.Controls.Add(this.btnSalaCalido);
            this.panelRedondeadoSala.Controls.Add(this.lblSalaIntensidad);
            this.panelRedondeadoSala.Controls.Add(this.sliderSalaIntensidad);
            this.panelRedondeadoSala.Controls.Add(this.lblSalaBrilloText);
            this.panelRedondeadoSala.Controls.Add(this.iconToggleSala);
            this.panelRedondeadoSala.Controls.Add(this.lblSalaTitle);
            this.panelRedondeadoSala.Controls.Add(this.iconSala);
            this.panelRedondeadoSala.GrosorBorde = 1;
            this.panelRedondeadoSala.Location = new System.Drawing.Point(5, 15);
            this.panelRedondeadoSala.Margin = new System.Windows.Forms.Padding(5, 5, 20, 20);
            this.panelRedondeadoSala.Name = "panelRedondeadoSala";
            this.panelRedondeadoSala.RadioBordes = 5;
            this.panelRedondeadoSala.Size = new System.Drawing.Size(305, 180);
            this.panelRedondeadoSala.TabIndex = 0;
            // 
            // btnSalaColor
            // 
            this.btnSalaColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnSalaColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.btnSalaColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalaColor.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnSalaColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnSalaColor.Location = new System.Drawing.Point(205, 135);
            this.btnSalaColor.Name = "btnSalaColor";
            this.btnSalaColor.Size = new System.Drawing.Size(85, 30);
            this.btnSalaColor.TabIndex = 8;
            this.btnSalaColor.Text = "Color";
            this.btnSalaColor.UseVisualStyleBackColor = false;
            // 
            // btnSalaFrio
            // 
            this.btnSalaFrio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnSalaFrio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.btnSalaFrio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalaFrio.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnSalaFrio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnSalaFrio.Location = new System.Drawing.Point(110, 135);
            this.btnSalaFrio.Name = "btnSalaFrio";
            this.btnSalaFrio.Size = new System.Drawing.Size(85, 30);
            this.btnSalaFrio.TabIndex = 7;
            this.btnSalaFrio.Text = "Frío";
            this.btnSalaFrio.UseVisualStyleBackColor = false;
            // 
            // btnSalaCalido
            // 
            this.btnSalaCalido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnSalaCalido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.btnSalaCalido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalaCalido.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnSalaCalido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnSalaCalido.Location = new System.Drawing.Point(15, 135);
            this.btnSalaCalido.Name = "btnSalaCalido";
            this.btnSalaCalido.Size = new System.Drawing.Size(85, 30);
            this.btnSalaCalido.TabIndex = 6;
            this.btnSalaCalido.Text = "Cálido";
            this.btnSalaCalido.UseVisualStyleBackColor = false;
            // 
            // lblSalaIntensidad
            // 
            this.lblSalaIntensidad.AutoSize = true;
            this.lblSalaIntensidad.BackColor = System.Drawing.Color.White;
            this.lblSalaIntensidad.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSalaIntensidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblSalaIntensidad.Location = new System.Drawing.Point(265, 75);
            this.lblSalaIntensidad.Name = "lblSalaIntensidad";
            this.lblSalaIntensidad.Size = new System.Drawing.Size(28, 13);
            this.lblSalaIntensidad.TabIndex = 4;
            this.lblSalaIntensidad.Text = "75%";
            this.lblSalaIntensidad.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // sliderSalaIntensidad
            // 
            this.sliderSalaIntensidad.BackColor = System.Drawing.Color.Transparent;
            this.sliderSalaIntensidad.ColorBoton = System.Drawing.Color.White;
            this.sliderSalaIntensidad.ColorPistaLlena = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.sliderSalaIntensidad.ColorPistaVacia = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.sliderSalaIntensidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sliderSalaIntensidad.Location = new System.Drawing.Point(15, 95);
            this.sliderSalaIntensidad.Maximo = 100;
            this.sliderSalaIntensidad.Minimo = 0;
            this.sliderSalaIntensidad.Name = "sliderSalaIntensidad";
            this.sliderSalaIntensidad.Size = new System.Drawing.Size(275, 25);
            this.sliderSalaIntensidad.TabIndex = 5;
            this.sliderSalaIntensidad.Valor = 75;
            // 
            // lblSalaBrilloText
            // 
            this.lblSalaBrilloText.AutoSize = true;
            this.lblSalaBrilloText.BackColor = System.Drawing.Color.White;
            this.lblSalaBrilloText.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSalaBrilloText.ForeColor = System.Drawing.Color.Gray;
            this.lblSalaBrilloText.Location = new System.Drawing.Point(15, 75);
            this.lblSalaBrilloText.Name = "lblSalaBrilloText";
            this.lblSalaBrilloText.Size = new System.Drawing.Size(34, 13);
            this.lblSalaBrilloText.TabIndex = 3;
            this.lblSalaBrilloText.Text = "Brillo";
            // 
            // iconToggleSala
            // 
            this.iconToggleSala.BackColor = System.Drawing.Color.White;
            this.iconToggleSala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconToggleSala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.iconToggleSala.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
            this.iconToggleSala.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.iconToggleSala.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconToggleSala.IconSize = 25;
            this.iconToggleSala.Location = new System.Drawing.Point(260, 16);
            this.iconToggleSala.Name = "iconToggleSala";
            this.iconToggleSala.Size = new System.Drawing.Size(35, 25);
            this.iconToggleSala.TabIndex = 2;
            this.iconToggleSala.TabStop = false;
            // 
            // lblSalaTitle
            // 
            this.lblSalaTitle.AutoSize = true;
            this.lblSalaTitle.BackColor = System.Drawing.Color.White;
            this.lblSalaTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSalaTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblSalaTitle.Location = new System.Drawing.Point(40, 20);
            this.lblSalaTitle.Name = "lblSalaTitle";
            this.lblSalaTitle.Size = new System.Drawing.Size(84, 17);
            this.lblSalaTitle.TabIndex = 1;
            this.lblSalaTitle.Text = "Sala de Estar";
            // 
            // iconSala
            // 
            this.iconSala.BackColor = System.Drawing.Color.White;
            this.iconSala.ForeColor = System.Drawing.Color.Orange;
            this.iconSala.IconChar = FontAwesome.Sharp.IconChar.Lightbulb;
            this.iconSala.IconColor = System.Drawing.Color.Orange;
            this.iconSala.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconSala.IconSize = 20;
            this.iconSala.Location = new System.Drawing.Point(15, 20);
            this.iconSala.Name = "iconSala";
            this.iconSala.Size = new System.Drawing.Size(20, 20);
            this.iconSala.TabIndex = 0;
            this.iconSala.TabStop = false;
            // 
            // panelRedondeadoCocina
            // 
            this.panelRedondeadoCocina.BackColor = System.Drawing.Color.Transparent;
            this.panelRedondeadoCocina.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(220)))));
            this.panelRedondeadoCocina.ColorFondo = System.Drawing.Color.White;
            this.panelRedondeadoCocina.Controls.Add(this.btnCocinaColor);
            this.panelRedondeadoCocina.Controls.Add(this.btnCocinaFrio);
            this.panelRedondeadoCocina.Controls.Add(this.btnCocinaCalido);
            this.panelRedondeadoCocina.Controls.Add(this.lblCocinaIntensidad);
            this.panelRedondeadoCocina.Controls.Add(this.sliderCocinaIntensidad);
            this.panelRedondeadoCocina.Controls.Add(this.lblCocinaBrilloText);
            this.panelRedondeadoCocina.Controls.Add(this.iconToggleCocina);
            this.panelRedondeadoCocina.Controls.Add(this.lblCocinaTitle);
            this.panelRedondeadoCocina.Controls.Add(this.iconCocina);
            this.panelRedondeadoCocina.GrosorBorde = 1;
            this.panelRedondeadoCocina.Location = new System.Drawing.Point(335, 15);
            this.panelRedondeadoCocina.Margin = new System.Windows.Forms.Padding(5, 5, 20, 20);
            this.panelRedondeadoCocina.Name = "panelRedondeadoCocina";
            this.panelRedondeadoCocina.RadioBordes = 5;
            this.panelRedondeadoCocina.Size = new System.Drawing.Size(305, 180);
            this.panelRedondeadoCocina.TabIndex = 1;
            // 
            // btnCocinaColor
            // 
            this.btnCocinaColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnCocinaColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnCocinaColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCocinaColor.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnCocinaColor.ForeColor = System.Drawing.Color.LightGray;
            this.btnCocinaColor.Location = new System.Drawing.Point(205, 135);
            this.btnCocinaColor.Name = "btnCocinaColor";
            this.btnCocinaColor.Size = new System.Drawing.Size(85, 30);
            this.btnCocinaColor.TabIndex = 8;
            this.btnCocinaColor.Text = "Color";
            this.btnCocinaColor.UseVisualStyleBackColor = false;
            // 
            // btnCocinaFrio
            // 
            this.btnCocinaFrio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnCocinaFrio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnCocinaFrio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCocinaFrio.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnCocinaFrio.ForeColor = System.Drawing.Color.LightGray;
            this.btnCocinaFrio.Location = new System.Drawing.Point(110, 135);
            this.btnCocinaFrio.Name = "btnCocinaFrio";
            this.btnCocinaFrio.Size = new System.Drawing.Size(85, 30);
            this.btnCocinaFrio.TabIndex = 7;
            this.btnCocinaFrio.Text = "Frío";
            this.btnCocinaFrio.UseVisualStyleBackColor = false;
            // 
            // btnCocinaCalido
            // 
            this.btnCocinaCalido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnCocinaCalido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnCocinaCalido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCocinaCalido.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnCocinaCalido.ForeColor = System.Drawing.Color.LightGray;
            this.btnCocinaCalido.Location = new System.Drawing.Point(15, 135);
            this.btnCocinaCalido.Name = "btnCocinaCalido";
            this.btnCocinaCalido.Size = new System.Drawing.Size(85, 30);
            this.btnCocinaCalido.TabIndex = 6;
            this.btnCocinaCalido.Text = "Cálido";
            this.btnCocinaCalido.UseVisualStyleBackColor = false;
            // 
            // lblCocinaIntensidad
            // 
            this.lblCocinaIntensidad.AutoSize = true;
            this.lblCocinaIntensidad.BackColor = System.Drawing.Color.White;
            this.lblCocinaIntensidad.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCocinaIntensidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblCocinaIntensidad.Location = new System.Drawing.Point(265, 75);
            this.lblCocinaIntensidad.Name = "lblCocinaIntensidad";
            this.lblCocinaIntensidad.Size = new System.Drawing.Size(28, 13);
            this.lblCocinaIntensidad.TabIndex = 4;
            this.lblCocinaIntensidad.Text = "60%";
            this.lblCocinaIntensidad.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // sliderCocinaIntensidad
            // 
            this.sliderCocinaIntensidad.BackColor = System.Drawing.Color.Transparent;
            this.sliderCocinaIntensidad.ColorBoton = System.Drawing.Color.White;
            this.sliderCocinaIntensidad.ColorPistaLlena = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(235)))));
            this.sliderCocinaIntensidad.ColorPistaVacia = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.sliderCocinaIntensidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sliderCocinaIntensidad.Location = new System.Drawing.Point(15, 95);
            this.sliderCocinaIntensidad.Maximo = 100;
            this.sliderCocinaIntensidad.Minimo = 0;
            this.sliderCocinaIntensidad.Name = "sliderCocinaIntensidad";
            this.sliderCocinaIntensidad.Size = new System.Drawing.Size(275, 25);
            this.sliderCocinaIntensidad.TabIndex = 5;
            this.sliderCocinaIntensidad.Valor = 60;
            // 
            // lblCocinaBrilloText
            // 
            this.lblCocinaBrilloText.AutoSize = true;
            this.lblCocinaBrilloText.BackColor = System.Drawing.Color.White;
            this.lblCocinaBrilloText.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCocinaBrilloText.ForeColor = System.Drawing.Color.Gray;
            this.lblCocinaBrilloText.Location = new System.Drawing.Point(15, 75);
            this.lblCocinaBrilloText.Name = "lblCocinaBrilloText";
            this.lblCocinaBrilloText.Size = new System.Drawing.Size(34, 13);
            this.lblCocinaBrilloText.TabIndex = 3;
            this.lblCocinaBrilloText.Text = "Brillo";
            // 
            // iconToggleCocina
            // 
            this.iconToggleCocina.BackColor = System.Drawing.Color.White;
            this.iconToggleCocina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconToggleCocina.ForeColor = System.Drawing.Color.LightGray;
            this.iconToggleCocina.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
            this.iconToggleCocina.IconColor = System.Drawing.Color.LightGray;
            this.iconToggleCocina.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconToggleCocina.IconSize = 25;
            this.iconToggleCocina.Location = new System.Drawing.Point(260, 16);
            this.iconToggleCocina.Name = "iconToggleCocina";
            this.iconToggleCocina.Size = new System.Drawing.Size(35, 25);
            this.iconToggleCocina.TabIndex = 2;
            this.iconToggleCocina.TabStop = false;
            // 
            // lblCocinaTitle
            // 
            this.lblCocinaTitle.AutoSize = true;
            this.lblCocinaTitle.BackColor = System.Drawing.Color.White;
            this.lblCocinaTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCocinaTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblCocinaTitle.Location = new System.Drawing.Point(40, 20);
            this.lblCocinaTitle.Name = "lblCocinaTitle";
            this.lblCocinaTitle.Size = new System.Drawing.Size(47, 17);
            this.lblCocinaTitle.TabIndex = 1;
            this.lblCocinaTitle.Text = "Cocina";
            // 
            // iconCocina
            // 
            this.iconCocina.BackColor = System.Drawing.Color.White;
            this.iconCocina.ForeColor = System.Drawing.Color.Gray;
            this.iconCocina.IconChar = FontAwesome.Sharp.IconChar.Lightbulb;
            this.iconCocina.IconColor = System.Drawing.Color.Gray;
            this.iconCocina.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.iconCocina.IconSize = 20;
            this.iconCocina.Location = new System.Drawing.Point(15, 20);
            this.iconCocina.Name = "iconCocina";
            this.iconCocina.Size = new System.Drawing.Size(20, 20);
            this.iconCocina.TabIndex = 0;
            this.iconCocina.TabStop = false;
            // 
            // panelRedondeadoDormitorio
            // 
            this.panelRedondeadoDormitorio.BackColor = System.Drawing.Color.Transparent;
            this.panelRedondeadoDormitorio.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(220)))));
            this.panelRedondeadoDormitorio.ColorFondo = System.Drawing.Color.White;
            this.panelRedondeadoDormitorio.Controls.Add(this.btnDormitorioColor);
            this.panelRedondeadoDormitorio.Controls.Add(this.btnDormitorioFrio);
            this.panelRedondeadoDormitorio.Controls.Add(this.btnDormitorioCalido);
            this.panelRedondeadoDormitorio.Controls.Add(this.lblDormitorioIntensidad);
            this.panelRedondeadoDormitorio.Controls.Add(this.sliderDormitorioIntensidad);
            this.panelRedondeadoDormitorio.Controls.Add(this.lblDormitorioBrilloText);
            this.panelRedondeadoDormitorio.Controls.Add(this.iconToggleDormitorio);
            this.panelRedondeadoDormitorio.Controls.Add(this.lblDormitorioTitle);
            this.panelRedondeadoDormitorio.Controls.Add(this.iconDormitorio);
            this.panelRedondeadoDormitorio.GrosorBorde = 1;
            this.panelRedondeadoDormitorio.Location = new System.Drawing.Point(665, 15);
            this.panelRedondeadoDormitorio.Margin = new System.Windows.Forms.Padding(5, 5, 20, 20);
            this.panelRedondeadoDormitorio.Name = "panelRedondeadoDormitorio";
            this.panelRedondeadoDormitorio.RadioBordes = 5;
            this.panelRedondeadoDormitorio.Size = new System.Drawing.Size(305, 180);
            this.panelRedondeadoDormitorio.TabIndex = 2;
            // 
            // btnDormitorioColor
            // 
            this.btnDormitorioColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnDormitorioColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDormitorioColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDormitorioColor.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnDormitorioColor.ForeColor = System.Drawing.Color.LightGray;
            this.btnDormitorioColor.Location = new System.Drawing.Point(205, 135);
            this.btnDormitorioColor.Name = "btnDormitorioColor";
            this.btnDormitorioColor.Size = new System.Drawing.Size(85, 30);
            this.btnDormitorioColor.TabIndex = 8;
            this.btnDormitorioColor.Text = "Color";
            this.btnDormitorioColor.UseVisualStyleBackColor = false;
            // 
            // btnDormitorioFrio
            // 
            this.btnDormitorioFrio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnDormitorioFrio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDormitorioFrio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDormitorioFrio.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnDormitorioFrio.ForeColor = System.Drawing.Color.LightGray;
            this.btnDormitorioFrio.Location = new System.Drawing.Point(110, 135);
            this.btnDormitorioFrio.Name = "btnDormitorioFrio";
            this.btnDormitorioFrio.Size = new System.Drawing.Size(85, 30);
            this.btnDormitorioFrio.TabIndex = 7;
            this.btnDormitorioFrio.Text = "Frío";
            this.btnDormitorioFrio.UseVisualStyleBackColor = false;
            // 
            // btnDormitorioCalido
            // 
            this.btnDormitorioCalido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnDormitorioCalido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDormitorioCalido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDormitorioCalido.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnDormitorioCalido.ForeColor = System.Drawing.Color.LightGray;
            this.btnDormitorioCalido.Location = new System.Drawing.Point(15, 135);
            this.btnDormitorioCalido.Name = "btnDormitorioCalido";
            this.btnDormitorioCalido.Size = new System.Drawing.Size(85, 30);
            this.btnDormitorioCalido.TabIndex = 6;
            this.btnDormitorioCalido.Text = "Cálido";
            this.btnDormitorioCalido.UseVisualStyleBackColor = false;
            // 
            // lblDormitorioIntensidad
            // 
            this.lblDormitorioIntensidad.AutoSize = true;
            this.lblDormitorioIntensidad.BackColor = System.Drawing.Color.White;
            this.lblDormitorioIntensidad.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDormitorioIntensidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblDormitorioIntensidad.Location = new System.Drawing.Point(265, 75);
            this.lblDormitorioIntensidad.Name = "lblDormitorioIntensidad";
            this.lblDormitorioIntensidad.Size = new System.Drawing.Size(28, 13);
            this.lblDormitorioIntensidad.TabIndex = 4;
            this.lblDormitorioIntensidad.Text = "40%";
            this.lblDormitorioIntensidad.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // sliderDormitorioIntensidad
            // 
            this.sliderDormitorioIntensidad.BackColor = System.Drawing.Color.Transparent;
            this.sliderDormitorioIntensidad.ColorBoton = System.Drawing.Color.White;
            this.sliderDormitorioIntensidad.ColorPistaLlena = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(235)))));
            this.sliderDormitorioIntensidad.ColorPistaVacia = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.sliderDormitorioIntensidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sliderDormitorioIntensidad.Location = new System.Drawing.Point(15, 95);
            this.sliderDormitorioIntensidad.Maximo = 100;
            this.sliderDormitorioIntensidad.Minimo = 0;
            this.sliderDormitorioIntensidad.Name = "sliderDormitorioIntensidad";
            this.sliderDormitorioIntensidad.Size = new System.Drawing.Size(275, 25);
            this.sliderDormitorioIntensidad.TabIndex = 5;
            this.sliderDormitorioIntensidad.Valor = 40;
            // 
            // lblDormitorioBrilloText
            // 
            this.lblDormitorioBrilloText.AutoSize = true;
            this.lblDormitorioBrilloText.BackColor = System.Drawing.Color.White;
            this.lblDormitorioBrilloText.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDormitorioBrilloText.ForeColor = System.Drawing.Color.Gray;
            this.lblDormitorioBrilloText.Location = new System.Drawing.Point(15, 75);
            this.lblDormitorioBrilloText.Name = "lblDormitorioBrilloText";
            this.lblDormitorioBrilloText.Size = new System.Drawing.Size(34, 13);
            this.lblDormitorioBrilloText.TabIndex = 3;
            this.lblDormitorioBrilloText.Text = "Brillo";
            // 
            // iconToggleDormitorio
            // 
            this.iconToggleDormitorio.BackColor = System.Drawing.Color.White;
            this.iconToggleDormitorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconToggleDormitorio.ForeColor = System.Drawing.Color.LightGray;
            this.iconToggleDormitorio.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
            this.iconToggleDormitorio.IconColor = System.Drawing.Color.LightGray;
            this.iconToggleDormitorio.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconToggleDormitorio.IconSize = 25;
            this.iconToggleDormitorio.Location = new System.Drawing.Point(260, 16);
            this.iconToggleDormitorio.Name = "iconToggleDormitorio";
            this.iconToggleDormitorio.Size = new System.Drawing.Size(35, 25);
            this.iconToggleDormitorio.TabIndex = 2;
            this.iconToggleDormitorio.TabStop = false;
            // 
            // lblDormitorioTitle
            // 
            this.lblDormitorioTitle.AutoSize = true;
            this.lblDormitorioTitle.BackColor = System.Drawing.Color.White;
            this.lblDormitorioTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDormitorioTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblDormitorioTitle.Location = new System.Drawing.Point(40, 20);
            this.lblDormitorioTitle.Name = "lblDormitorioTitle";
            this.lblDormitorioTitle.Size = new System.Drawing.Size(72, 17);
            this.lblDormitorioTitle.TabIndex = 1;
            this.lblDormitorioTitle.Text = "Dormitorio";
            // 
            // iconDormitorio
            // 
            this.iconDormitorio.BackColor = System.Drawing.Color.White;
            this.iconDormitorio.ForeColor = System.Drawing.Color.Gray;
            this.iconDormitorio.IconChar = FontAwesome.Sharp.IconChar.Lightbulb;
            this.iconDormitorio.IconColor = System.Drawing.Color.Gray;
            this.iconDormitorio.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.iconDormitorio.IconSize = 20;
            this.iconDormitorio.Location = new System.Drawing.Point(15, 20);
            this.iconDormitorio.Name = "iconDormitorio";
            this.iconDormitorio.Size = new System.Drawing.Size(20, 20);
            this.iconDormitorio.TabIndex = 0;
            this.iconDormitorio.TabStop = false;
            // 
            // panelRedondeadoExterior
            // 
            this.panelRedondeadoExterior.BackColor = System.Drawing.Color.Transparent;
            this.panelRedondeadoExterior.ColorBorde = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(220)))));
            this.panelRedondeadoExterior.ColorFondo = System.Drawing.Color.White;
            this.panelRedondeadoExterior.Controls.Add(this.btnExteriorColor);
            this.panelRedondeadoExterior.Controls.Add(this.btnExteriorFrio);
            this.panelRedondeadoExterior.Controls.Add(this.btnExteriorCalido);
            this.panelRedondeadoExterior.Controls.Add(this.lblExteriorIntensidad);
            this.panelRedondeadoExterior.Controls.Add(this.sliderExteriorIntensidad);
            this.panelRedondeadoExterior.Controls.Add(this.lblExteriorBrilloText);
            this.panelRedondeadoExterior.Controls.Add(this.iconToggleExterior);
            this.panelRedondeadoExterior.Controls.Add(this.lblExteriorTitle);
            this.panelRedondeadoExterior.Controls.Add(this.iconExterior);
            this.panelRedondeadoExterior.GrosorBorde = 1;
            this.panelRedondeadoExterior.Location = new System.Drawing.Point(995, 15);
            this.panelRedondeadoExterior.Margin = new System.Windows.Forms.Padding(5, 5, 20, 20);
            this.panelRedondeadoExterior.Name = "panelRedondeadoExterior";
            this.panelRedondeadoExterior.RadioBordes = 5;
            this.panelRedondeadoExterior.Size = new System.Drawing.Size(305, 180);
            this.panelRedondeadoExterior.TabIndex = 3;
            // 
            // btnExteriorColor
            // 
            this.btnExteriorColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnExteriorColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.btnExteriorColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExteriorColor.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnExteriorColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnExteriorColor.Location = new System.Drawing.Point(205, 135);
            this.btnExteriorColor.Name = "btnExteriorColor";
            this.btnExteriorColor.Size = new System.Drawing.Size(85, 30);
            this.btnExteriorColor.TabIndex = 8;
            this.btnExteriorColor.Text = "Color";
            this.btnExteriorColor.UseVisualStyleBackColor = false;
            // 
            // btnExteriorFrio
            // 
            this.btnExteriorFrio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnExteriorFrio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.btnExteriorFrio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExteriorFrio.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnExteriorFrio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnExteriorFrio.Location = new System.Drawing.Point(110, 135);
            this.btnExteriorFrio.Name = "btnExteriorFrio";
            this.btnExteriorFrio.Size = new System.Drawing.Size(85, 30);
            this.btnExteriorFrio.TabIndex = 7;
            this.btnExteriorFrio.Text = "Frío";
            this.btnExteriorFrio.UseVisualStyleBackColor = false;
            // 
            // btnExteriorCalido
            // 
            this.btnExteriorCalido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnExteriorCalido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.btnExteriorCalido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExteriorCalido.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnExteriorCalido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnExteriorCalido.Location = new System.Drawing.Point(15, 135);
            this.btnExteriorCalido.Name = "btnExteriorCalido";
            this.btnExteriorCalido.Size = new System.Drawing.Size(85, 30);
            this.btnExteriorCalido.TabIndex = 6;
            this.btnExteriorCalido.Text = "Cálido";
            this.btnExteriorCalido.UseVisualStyleBackColor = false;
            // 
            // lblExteriorIntensidad
            // 
            this.lblExteriorIntensidad.AutoSize = true;
            this.lblExteriorIntensidad.BackColor = System.Drawing.Color.White;
            this.lblExteriorIntensidad.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblExteriorIntensidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblExteriorIntensidad.Location = new System.Drawing.Point(265, 75);
            this.lblExteriorIntensidad.Name = "lblExteriorIntensidad";
            this.lblExteriorIntensidad.Size = new System.Drawing.Size(28, 13);
            this.lblExteriorIntensidad.TabIndex = 4;
            this.lblExteriorIntensidad.Text = "80%";
            this.lblExteriorIntensidad.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // sliderExteriorIntensidad
            // 
            this.sliderExteriorIntensidad.BackColor = System.Drawing.Color.Transparent;
            this.sliderExteriorIntensidad.ColorBoton = System.Drawing.Color.White;
            this.sliderExteriorIntensidad.ColorPistaLlena = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.sliderExteriorIntensidad.ColorPistaVacia = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.sliderExteriorIntensidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sliderExteriorIntensidad.Location = new System.Drawing.Point(15, 95);
            this.sliderExteriorIntensidad.Maximo = 100;
            this.sliderExteriorIntensidad.Minimo = 0;
            this.sliderExteriorIntensidad.Name = "sliderExteriorIntensidad";
            this.sliderExteriorIntensidad.Size = new System.Drawing.Size(275, 25);
            this.sliderExteriorIntensidad.TabIndex = 5;
            this.sliderExteriorIntensidad.Valor = 80;
            // 
            // lblExteriorBrilloText
            // 
            this.lblExteriorBrilloText.AutoSize = true;
            this.lblExteriorBrilloText.BackColor = System.Drawing.Color.White;
            this.lblExteriorBrilloText.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblExteriorBrilloText.ForeColor = System.Drawing.Color.Gray;
            this.lblExteriorBrilloText.Location = new System.Drawing.Point(15, 75);
            this.lblExteriorBrilloText.Name = "lblExteriorBrilloText";
            this.lblExteriorBrilloText.Size = new System.Drawing.Size(34, 13);
            this.lblExteriorBrilloText.TabIndex = 3;
            this.lblExteriorBrilloText.Text = "Brillo";
            // 
            // iconToggleExterior
            // 
            this.iconToggleExterior.BackColor = System.Drawing.Color.White;
            this.iconToggleExterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconToggleExterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.iconToggleExterior.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
            this.iconToggleExterior.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.iconToggleExterior.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconToggleExterior.IconSize = 25;
            this.iconToggleExterior.Location = new System.Drawing.Point(260, 16);
            this.iconToggleExterior.Name = "iconToggleExterior";
            this.iconToggleExterior.Size = new System.Drawing.Size(35, 25);
            this.iconToggleExterior.TabIndex = 2;
            this.iconToggleExterior.TabStop = false;
            // 
            // lblExteriorTitle
            // 
            this.lblExteriorTitle.AutoSize = true;
            this.lblExteriorTitle.BackColor = System.Drawing.Color.White;
            this.lblExteriorTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblExteriorTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblExteriorTitle.Location = new System.Drawing.Point(40, 20);
            this.lblExteriorTitle.Name = "lblExteriorTitle";
            this.lblExteriorTitle.Size = new System.Drawing.Size(53, 17);
            this.lblExteriorTitle.TabIndex = 1;
            this.lblExteriorTitle.Text = "Exterior";
            // 
            // iconExterior
            // 
            this.iconExterior.BackColor = System.Drawing.Color.White;
            this.iconExterior.ForeColor = System.Drawing.Color.Orange;
            this.iconExterior.IconChar = FontAwesome.Sharp.IconChar.Lightbulb;
            this.iconExterior.IconColor = System.Drawing.Color.Orange;
            this.iconExterior.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconExterior.IconSize = 20;
            this.iconExterior.Location = new System.Drawing.Point(15, 20);
            this.iconExterior.Name = "iconExterior";
            this.iconExterior.Size = new System.Drawing.Size(20, 20);
            this.iconExterior.TabIndex = 0;
            this.iconExterior.TabStop = false;
            // 
            // FormIluminacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1562, 665);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIluminacion";
            this.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.Text = "Iluminación";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelRedondeadoSala.ResumeLayout(false);
            this.panelRedondeadoSala.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconToggleSala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSala)).EndInit();
            this.panelRedondeadoCocina.ResumeLayout(false);
            this.panelRedondeadoCocina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconToggleCocina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCocina)).EndInit();
            this.panelRedondeadoDormitorio.ResumeLayout(false);
            this.panelRedondeadoDormitorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconToggleDormitorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconDormitorio)).EndInit();
            this.panelRedondeadoExterior.ResumeLayout(false);
            this.panelRedondeadoExterior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconToggleExterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExterior)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblConnectedLights;
        private System.Windows.Forms.Button btnAgregarLuz;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        
        private PanelRedondeado panelRedondeadoSala;
        private FontAwesome.Sharp.IconPictureBox iconSala;
        private System.Windows.Forms.Label lblSalaTitle;
        private FontAwesome.Sharp.IconPictureBox iconToggleSala;
        private System.Windows.Forms.Label lblSalaBrilloText;
        private System.Windows.Forms.Label lblSalaIntensidad;
        private SliderModerno sliderSalaIntensidad;
        private System.Windows.Forms.Button btnSalaCalido;
        private System.Windows.Forms.Button btnSalaFrio;
        private System.Windows.Forms.Button btnSalaColor;

        private PanelRedondeado panelRedondeadoCocina;
        private FontAwesome.Sharp.IconPictureBox iconCocina;
        private System.Windows.Forms.Label lblCocinaTitle;
        private FontAwesome.Sharp.IconPictureBox iconToggleCocina;
        private System.Windows.Forms.Label lblCocinaBrilloText;
        private System.Windows.Forms.Label lblCocinaIntensidad;
        private SliderModerno sliderCocinaIntensidad;
        private System.Windows.Forms.Button btnCocinaCalido;
        private System.Windows.Forms.Button btnCocinaFrio;
        private System.Windows.Forms.Button btnCocinaColor;

        private PanelRedondeado panelRedondeadoDormitorio;
        private FontAwesome.Sharp.IconPictureBox iconDormitorio;
        private System.Windows.Forms.Label lblDormitorioTitle;
        private FontAwesome.Sharp.IconPictureBox iconToggleDormitorio;
        private System.Windows.Forms.Label lblDormitorioBrilloText;
        private System.Windows.Forms.Label lblDormitorioIntensidad;
        private SliderModerno sliderDormitorioIntensidad;
        private System.Windows.Forms.Button btnDormitorioCalido;
        private System.Windows.Forms.Button btnDormitorioFrio;
        private System.Windows.Forms.Button btnDormitorioColor;

        private PanelRedondeado panelRedondeadoExterior;
        private FontAwesome.Sharp.IconPictureBox iconExterior;
        private System.Windows.Forms.Label lblExteriorTitle;
        private FontAwesome.Sharp.IconPictureBox iconToggleExterior;
        private System.Windows.Forms.Label lblExteriorBrilloText;
        private System.Windows.Forms.Label lblExteriorIntensidad;
        private SliderModerno sliderExteriorIntensidad;
        private System.Windows.Forms.Button btnExteriorCalido;
        private System.Windows.Forms.Button btnExteriorFrio;
        private System.Windows.Forms.Button btnExteriorColor;
    }
}
