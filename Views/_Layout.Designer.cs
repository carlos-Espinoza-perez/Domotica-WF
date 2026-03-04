namespace Domotica.Views
{
    partial class _Layout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SideBar = new System.Windows.Forms.Panel();
            this.sidebar_opt_multimedia = new System.Windows.Forms.Panel();
            this.iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sidebar_opt_seguridad = new System.Windows.Forms.Panel();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this._1 = new System.Windows.Forms.Label();
            this.sidebar_opt_clima = new System.Windows.Forms.Panel();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sidebar_opt_iluminacion = new System.Windows.Forms.Panel();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sidebar_opt_inicio = new System.Windows.Forms.Panel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Header = new System.Windows.Forms.Panel();
            this.ButtonToggleSideBar = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timerSideBar = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.PanelContenido = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.SideBar.SuspendLayout();
            this.sidebar_opt_multimedia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).BeginInit();
            this.sidebar_opt_seguridad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            this.sidebar_opt_clima.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            this.sidebar_opt_iluminacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.sidebar_opt_inicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonToggleSideBar)).BeginInit();
            this.PanelContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.SideBar.Controls.Add(this.sidebar_opt_multimedia);
            this.SideBar.Controls.Add(this.sidebar_opt_seguridad);
            this.SideBar.Controls.Add(this.sidebar_opt_clima);
            this.SideBar.Controls.Add(this.sidebar_opt_iluminacion);
            this.SideBar.Controls.Add(this.button1);
            this.SideBar.Controls.Add(this.sidebar_opt_inicio);
            this.SideBar.Controls.Add(this.label2);
            this.SideBar.Controls.Add(this.panel3);
            this.SideBar.Controls.Add(this.panel1);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SideBar.MaximumSize = new System.Drawing.Size(345, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(334, 1050);
            this.SideBar.TabIndex = 0;
            // 
            // sidebar_opt_multimedia
            // 
            this.sidebar_opt_multimedia.Controls.Add(this.iconPictureBox6);
            this.sidebar_opt_multimedia.Controls.Add(this.label7);
            this.sidebar_opt_multimedia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sidebar_opt_multimedia.Location = new System.Drawing.Point(20, 391);
            this.sidebar_opt_multimedia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sidebar_opt_multimedia.Name = "sidebar_opt_multimedia";
            this.sidebar_opt_multimedia.Size = new System.Drawing.Size(300, 65);
            this.sidebar_opt_multimedia.TabIndex = 7;
            this.sidebar_opt_multimedia.Click += new System.EventHandler(this.sidebar_opt_multimedia_Click);
            this.sidebar_opt_multimedia.MouseEnter += new System.EventHandler(this.SetBackgroundToHover);
            this.sidebar_opt_multimedia.MouseLeave += new System.EventHandler(this.RemoveBackgroundToHover);
            // 
            // iconPictureBox6
            // 
            this.iconPictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.iconPictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.VolumeUp;
            this.iconPictureBox6.IconColor = System.Drawing.Color.White;
            this.iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox6.IconSize = 24;
            this.iconPictureBox6.Location = new System.Drawing.Point(6, 20);
            this.iconPictureBox6.Margin = new System.Windows.Forms.Padding(0);
            this.iconPictureBox6.Name = "iconPictureBox6";
            this.iconPictureBox6.Size = new System.Drawing.Size(24, 25);
            this.iconPictureBox6.TabIndex = 7;
            this.iconPictureBox6.TabStop = false;
            this.iconPictureBox6.Click += new System.EventHandler(this.sidebar_opt_multimedia_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SansSerif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(34, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Multimedia";
            this.label7.Click += new System.EventHandler(this.sidebar_opt_multimedia_Click);
            // 
            // sidebar_opt_seguridad
            // 
            this.sidebar_opt_seguridad.Controls.Add(this.iconPictureBox5);
            this.sidebar_opt_seguridad.Controls.Add(this._1);
            this.sidebar_opt_seguridad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sidebar_opt_seguridad.Location = new System.Drawing.Point(20, 326);
            this.sidebar_opt_seguridad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sidebar_opt_seguridad.Name = "sidebar_opt_seguridad";
            this.sidebar_opt_seguridad.Size = new System.Drawing.Size(300, 65);
            this.sidebar_opt_seguridad.TabIndex = 6;
            this.sidebar_opt_seguridad.Click += new System.EventHandler(this.sidebar_opt_seguridad_Click);
            this.sidebar_opt_seguridad.MouseEnter += new System.EventHandler(this.SetBackgroundToHover);
            this.sidebar_opt_seguridad.MouseLeave += new System.EventHandler(this.RemoveBackgroundToHover);
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.iconPictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.Shield;
            this.iconPictureBox5.IconColor = System.Drawing.Color.White;
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox5.IconSize = 24;
            this.iconPictureBox5.Location = new System.Drawing.Point(6, 20);
            this.iconPictureBox5.Margin = new System.Windows.Forms.Padding(0);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(24, 25);
            this.iconPictureBox5.TabIndex = 6;
            this.iconPictureBox5.TabStop = false;
            this.iconPictureBox5.Click += new System.EventHandler(this.sidebar_opt_seguridad_Click);
            // 
            // _1
            // 
            this._1.AutoSize = true;
            this._1.Font = new System.Drawing.Font("SansSerif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this._1.ForeColor = System.Drawing.Color.White;
            this._1.Location = new System.Drawing.Point(34, 20);
            this._1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._1.Name = "_1";
            this._1.Size = new System.Drawing.Size(65, 16);
            this._1.TabIndex = 1;
            this._1.Text = "Seguridad";
            this._1.Click += new System.EventHandler(this.sidebar_opt_seguridad_Click);
            // 
            // sidebar_opt_clima
            // 
            this.sidebar_opt_clima.Controls.Add(this.iconPictureBox4);
            this.sidebar_opt_clima.Controls.Add(this.label5);
            this.sidebar_opt_clima.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sidebar_opt_clima.Location = new System.Drawing.Point(20, 262);
            this.sidebar_opt_clima.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sidebar_opt_clima.Name = "sidebar_opt_clima";
            this.sidebar_opt_clima.Size = new System.Drawing.Size(300, 65);
            this.sidebar_opt_clima.TabIndex = 5;
            this.sidebar_opt_clima.Click += new System.EventHandler(this.sidebar_opt_clima_Click);
            this.sidebar_opt_clima.MouseEnter += new System.EventHandler(this.SetBackgroundToHover);
            this.sidebar_opt_clima.MouseLeave += new System.EventHandler(this.RemoveBackgroundToHover);
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.iconPictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Temperature4;
            this.iconPictureBox4.IconColor = System.Drawing.Color.White;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox4.IconSize = 24;
            this.iconPictureBox4.Location = new System.Drawing.Point(4, 20);
            this.iconPictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(24, 25);
            this.iconPictureBox4.TabIndex = 5;
            this.iconPictureBox4.TabStop = false;
            this.iconPictureBox4.Click += new System.EventHandler(this.sidebar_opt_clima_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SansSerif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Clima";
            this.label5.Click += new System.EventHandler(this.sidebar_opt_clima_Click);
            // 
            // sidebar_opt_iluminacion
            // 
            this.sidebar_opt_iluminacion.Controls.Add(this.iconPictureBox3);
            this.sidebar_opt_iluminacion.Controls.Add(this.label4);
            this.sidebar_opt_iluminacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sidebar_opt_iluminacion.Location = new System.Drawing.Point(20, 197);
            this.sidebar_opt_iluminacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sidebar_opt_iluminacion.Name = "sidebar_opt_iluminacion";
            this.sidebar_opt_iluminacion.Size = new System.Drawing.Size(300, 65);
            this.sidebar_opt_iluminacion.TabIndex = 4;
            this.sidebar_opt_iluminacion.Click += new System.EventHandler(this.sidebar_opt_iluminacion_Click);
            this.sidebar_opt_iluminacion.MouseEnter += new System.EventHandler(this.SetBackgroundToHover);
            this.sidebar_opt_iluminacion.MouseLeave += new System.EventHandler(this.RemoveBackgroundToHover);
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.iconPictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Lightbulb;
            this.iconPictureBox3.IconColor = System.Drawing.Color.White;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox3.IconSize = 24;
            this.iconPictureBox3.Location = new System.Drawing.Point(4, 18);
            this.iconPictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(24, 25);
            this.iconPictureBox3.TabIndex = 4;
            this.iconPictureBox3.TabStop = false;
            this.iconPictureBox3.Click += new System.EventHandler(this.sidebar_opt_iluminacion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SansSerif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Iluminación";
            this.label4.Click += new System.EventHandler(this.sidebar_opt_iluminacion_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 106);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(18, 85);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // sidebar_opt_inicio
            // 
            this.sidebar_opt_inicio.Controls.Add(this.iconPictureBox2);
            this.sidebar_opt_inicio.Controls.Add(this.label3);
            this.sidebar_opt_inicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sidebar_opt_inicio.Location = new System.Drawing.Point(20, 132);
            this.sidebar_opt_inicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sidebar_opt_inicio.Name = "sidebar_opt_inicio";
            this.sidebar_opt_inicio.Size = new System.Drawing.Size(300, 65);
            this.sidebar_opt_inicio.TabIndex = 3;
            this.sidebar_opt_inicio.Click += new System.EventHandler(this.sidebar_opt_inicio_Click);
            this.sidebar_opt_inicio.MouseEnter += new System.EventHandler(this.SetBackgroundToHover);
            this.sidebar_opt_inicio.MouseLeave += new System.EventHandler(this.RemoveBackgroundToHover);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.iconPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 24;
            this.iconPictureBox2.Location = new System.Drawing.Point(6, 23);
            this.iconPictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(24, 25);
            this.iconPictureBox2.TabIndex = 3;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.Click += new System.EventHandler(this.sidebar_opt_inicio_Click);
            this.iconPictureBox2.MouseEnter += new System.EventHandler(this.SetBackgroundToHover);
            this.iconPictureBox2.MouseLeave += new System.EventHandler(this.RemoveBackgroundToHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SansSerif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Inicio";
            this.label3.Click += new System.EventHandler(this.sidebar_opt_inicio_Click);
            this.label3.MouseEnter += new System.EventHandler(this.SetBackgroundToHover);
            this.label3.MouseLeave += new System.EventHandler(this.RemoveBackgroundToHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(14, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Navegación";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.iconPictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(24, 18);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 63);
            this.panel3.TabIndex = 2;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 30;
            this.iconPictureBox1.Location = new System.Drawing.Point(26, 14);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(30, 31);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SansSerif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(58, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Casa inteligente";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(332, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 1050);
            this.panel1.TabIndex = 0;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.ButtonToggleSideBar);
            this.Header.Controls.Add(this.panel2);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(334, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1590, 86);
            this.Header.TabIndex = 1;
            // 
            // ButtonToggleSideBar
            // 
            this.ButtonToggleSideBar.BackColor = System.Drawing.Color.Transparent;
            this.ButtonToggleSideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonToggleSideBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ButtonToggleSideBar.IconChar = FontAwesome.Sharp.IconChar.Columns;
            this.ButtonToggleSideBar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ButtonToggleSideBar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonToggleSideBar.IconSize = 33;
            this.ButtonToggleSideBar.Location = new System.Drawing.Point(18, 29);
            this.ButtonToggleSideBar.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonToggleSideBar.Name = "ButtonToggleSideBar";
            this.ButtonToggleSideBar.Size = new System.Drawing.Size(33, 34);
            this.ButtonToggleSideBar.TabIndex = 3;
            this.ButtonToggleSideBar.TabStop = false;
            this.ButtonToggleSideBar.Click += new System.EventHandler(this.ButtonToggleSideBar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1590, 2);
            this.panel2.TabIndex = 1;
            // 
            // timerSideBar
            // 
            this.timerSideBar.Interval = 10;
            this.timerSideBar.Tick += new System.EventHandler(this.timerSideBar_Tick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(334, 86);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1590, 2);
            this.panel4.TabIndex = 2;
            // 
            // PanelContenido
            // 
            this.PanelContenido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelContenido.Controls.Add(this.button2);
            this.PanelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenido.Location = new System.Drawing.Point(334, 88);
            this.PanelContenido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelContenido.Name = "PanelContenido";
            this.PanelContenido.Size = new System.Drawing.Size(1590, 962);
            this.PanelContenido.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Location = new System.Drawing.Point(166, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 52);
            this.button2.TabIndex = 0;
            this.button2.Text = "Detalles";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // _Layout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.PanelContenido);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.SideBar);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "_Layout";
            this.Text = "Casa inteligente";
            this.SideBar.ResumeLayout(false);
            this.SideBar.PerformLayout();
            this.sidebar_opt_multimedia.ResumeLayout(false);
            this.sidebar_opt_multimedia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).EndInit();
            this.sidebar_opt_seguridad.ResumeLayout(false);
            this.sidebar_opt_seguridad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            this.sidebar_opt_clima.ResumeLayout(false);
            this.sidebar_opt_clima.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            this.sidebar_opt_iluminacion.ResumeLayout(false);
            this.sidebar_opt_iluminacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.sidebar_opt_inicio.ResumeLayout(false);
            this.sidebar_opt_inicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonToggleSideBar)).EndInit();
            this.PanelContenido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Timer timerSideBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel sidebar_opt_inicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel sidebar_opt_multimedia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel sidebar_opt_seguridad;
        private System.Windows.Forms.Label _1;
        private System.Windows.Forms.Panel sidebar_opt_clima;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel sidebar_opt_iluminacion;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private FontAwesome.Sharp.IconPictureBox ButtonToggleSideBar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel PanelContenido;
        private System.Windows.Forms.Button button2;
    }
}