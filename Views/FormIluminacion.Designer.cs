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
            this.panelSala = new System.Windows.Forms.Panel();
            this.lblSalaIntensidad = new System.Windows.Forms.Label();
            this.trackBarSalaIntensidad = new System.Windows.Forms.TrackBar();
            this.panelSalaColor = new System.Windows.Forms.Panel();
            this.lblSalaTitle = new System.Windows.Forms.Label();
            this.panelCocina = new System.Windows.Forms.Panel();
            this.lblCocinaIntensidad = new System.Windows.Forms.Label();
            this.trackBarCocinaIntensidad = new System.Windows.Forms.TrackBar();
            this.panelCocinaColor = new System.Windows.Forms.Panel();
            this.lblCocinaTitle = new System.Windows.Forms.Label();
            this.panelDormitorio = new System.Windows.Forms.Panel();
            this.lblDormitorioIntensidad = new System.Windows.Forms.Label();
            this.trackBarDormitorioIntensidad = new System.Windows.Forms.TrackBar();
            this.panelDormitorioColor = new System.Windows.Forms.Panel();
            this.lblDormitorioTitle = new System.Windows.Forms.Label();
            this.panelBaño = new System.Windows.Forms.Panel();
            this.lblBañoIntensidad = new System.Windows.Forms.Label();
            this.trackBarBañoIntensidad = new System.Windows.Forms.TrackBar();
            this.panelBañoColor = new System.Windows.Forms.Panel();
            this.lblBañoTitle = new System.Windows.Forms.Label();
            this.panelControles = new System.Windows.Forms.Panel();
            this.lblTemperaturaTitle = new System.Windows.Forms.Label();
            this.btnTemperaturaCalida = new System.Windows.Forms.Button();
            this.btnTemperaturaFria = new System.Windows.Forms.Button();
            this.btnTodoEncendido = new System.Windows.Forms.Button();
            this.btnTodoApagado = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelSala.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSalaIntensidad)).BeginInit();
            this.panelCocina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCocinaIntensidad)).BeginInit();
            this.panelDormitorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDormitorioIntensidad)).BeginInit();
            this.panelBaño.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBañoIntensidad)).BeginInit();
            this.panelControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Red;
            this.panelHeader.Controls.Add(this.lblHeaderTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(27, 25);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(986, 74);
            this.panelHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(20, 18);
            this.lblHeaderTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(213, 37);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "💡 Iluminación";
            // 
            // panelSala
            // 
            this.panelSala.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelSala.Controls.Add(this.lblSalaIntensidad);
            this.panelSala.Controls.Add(this.trackBarSalaIntensidad);
            this.panelSala.Controls.Add(this.panelSalaColor);
            this.panelSala.Controls.Add(this.lblSalaTitle);
            this.panelSala.Location = new System.Drawing.Point(27, 123);
            this.panelSala.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSala.Name = "panelSala";
            this.panelSala.Size = new System.Drawing.Size(467, 185);
            this.panelSala.TabIndex = 1;
            // 
            // lblSalaIntensidad
            // 
            this.lblSalaIntensidad.AutoSize = true;
            this.lblSalaIntensidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSalaIntensidad.ForeColor = System.Drawing.Color.Black;
            this.lblSalaIntensidad.Location = new System.Drawing.Point(393, 74);
            this.lblSalaIntensidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalaIntensidad.Name = "lblSalaIntensidad";
            this.lblSalaIntensidad.Size = new System.Drawing.Size(53, 28);
            this.lblSalaIntensidad.TabIndex = 3;
            this.lblSalaIntensidad.Text = "70%";
            // 
            // trackBarSalaIntensidad
            // 
            this.trackBarSalaIntensidad.BackColor = System.Drawing.Color.LemonChiffon;
            this.trackBarSalaIntensidad.Location = new System.Drawing.Point(113, 62);
            this.trackBarSalaIntensidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBarSalaIntensidad.Maximum = 100;
            this.trackBarSalaIntensidad.Name = "trackBarSalaIntensidad";
            this.trackBarSalaIntensidad.Size = new System.Drawing.Size(267, 56);
            this.trackBarSalaIntensidad.TabIndex = 2;
            this.trackBarSalaIntensidad.Scroll += new System.EventHandler(this.trackBarSalaIntensidad_Scroll);
            // 
            // panelSalaColor
            // 
            this.panelSalaColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.panelSalaColor.Location = new System.Drawing.Point(20, 62);
            this.panelSalaColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSalaColor.Name = "panelSalaColor";
            this.panelSalaColor.Size = new System.Drawing.Size(80, 74);
            this.panelSalaColor.TabIndex = 1;
            // 
            // lblSalaTitle
            // 
            this.lblSalaTitle.AutoSize = true;
            this.lblSalaTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSalaTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.lblSalaTitle.Location = new System.Drawing.Point(20, 18);
            this.lblSalaTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalaTitle.Name = "lblSalaTitle";
            this.lblSalaTitle.Size = new System.Drawing.Size(48, 25);
            this.lblSalaTitle.TabIndex = 0;
            this.lblSalaTitle.Text = "Sala";
            // 
            // panelCocina
            // 
            this.panelCocina.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelCocina.Controls.Add(this.lblCocinaIntensidad);
            this.panelCocina.Controls.Add(this.trackBarCocinaIntensidad);
            this.panelCocina.Controls.Add(this.panelCocinaColor);
            this.panelCocina.Controls.Add(this.lblCocinaTitle);
            this.panelCocina.Location = new System.Drawing.Point(547, 123);
            this.panelCocina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCocina.Name = "panelCocina";
            this.panelCocina.Size = new System.Drawing.Size(467, 185);
            this.panelCocina.TabIndex = 2;
            // 
            // lblCocinaIntensidad
            // 
            this.lblCocinaIntensidad.AutoSize = true;
            this.lblCocinaIntensidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCocinaIntensidad.ForeColor = System.Drawing.Color.Black;
            this.lblCocinaIntensidad.Location = new System.Drawing.Point(393, 74);
            this.lblCocinaIntensidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCocinaIntensidad.Name = "lblCocinaIntensidad";
            this.lblCocinaIntensidad.Size = new System.Drawing.Size(53, 28);
            this.lblCocinaIntensidad.TabIndex = 3;
            this.lblCocinaIntensidad.Text = "80%";
            // 
            // trackBarCocinaIntensidad
            // 
            this.trackBarCocinaIntensidad.BackColor = System.Drawing.Color.LemonChiffon;
            this.trackBarCocinaIntensidad.Location = new System.Drawing.Point(113, 62);
            this.trackBarCocinaIntensidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBarCocinaIntensidad.Maximum = 100;
            this.trackBarCocinaIntensidad.Name = "trackBarCocinaIntensidad";
            this.trackBarCocinaIntensidad.Size = new System.Drawing.Size(267, 56);
            this.trackBarCocinaIntensidad.TabIndex = 2;
            this.trackBarCocinaIntensidad.Scroll += new System.EventHandler(this.trackBarCocinaIntensidad_Scroll);
            // 
            // panelCocinaColor
            // 
            this.panelCocinaColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.panelCocinaColor.Location = new System.Drawing.Point(20, 62);
            this.panelCocinaColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCocinaColor.Name = "panelCocinaColor";
            this.panelCocinaColor.Size = new System.Drawing.Size(80, 74);
            this.panelCocinaColor.TabIndex = 1;
            // 
            // lblCocinaTitle
            // 
            this.lblCocinaTitle.AutoSize = true;
            this.lblCocinaTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCocinaTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.lblCocinaTitle.Location = new System.Drawing.Point(20, 18);
            this.lblCocinaTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCocinaTitle.Name = "lblCocinaTitle";
            this.lblCocinaTitle.Size = new System.Drawing.Size(72, 25);
            this.lblCocinaTitle.TabIndex = 0;
            this.lblCocinaTitle.Text = "Cocina";
            // 
            // panelDormitorio
            // 
            this.panelDormitorio.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelDormitorio.Controls.Add(this.lblDormitorioIntensidad);
            this.panelDormitorio.Controls.Add(this.trackBarDormitorioIntensidad);
            this.panelDormitorio.Controls.Add(this.panelDormitorioColor);
            this.panelDormitorio.Controls.Add(this.lblDormitorioTitle);
            this.panelDormitorio.Location = new System.Drawing.Point(27, 345);
            this.panelDormitorio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDormitorio.Name = "panelDormitorio";
            this.panelDormitorio.Size = new System.Drawing.Size(467, 185);
            this.panelDormitorio.TabIndex = 3;
            // 
            // lblDormitorioIntensidad
            // 
            this.lblDormitorioIntensidad.AutoSize = true;
            this.lblDormitorioIntensidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDormitorioIntensidad.ForeColor = System.Drawing.Color.Black;
            this.lblDormitorioIntensidad.Location = new System.Drawing.Point(393, 74);
            this.lblDormitorioIntensidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDormitorioIntensidad.Name = "lblDormitorioIntensidad";
            this.lblDormitorioIntensidad.Size = new System.Drawing.Size(53, 28);
            this.lblDormitorioIntensidad.TabIndex = 3;
            this.lblDormitorioIntensidad.Text = "50%";
            // 
            // trackBarDormitorioIntensidad
            // 
            this.trackBarDormitorioIntensidad.BackColor = System.Drawing.Color.LemonChiffon;
            this.trackBarDormitorioIntensidad.Location = new System.Drawing.Point(113, 62);
            this.trackBarDormitorioIntensidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBarDormitorioIntensidad.Maximum = 100;
            this.trackBarDormitorioIntensidad.Name = "trackBarDormitorioIntensidad";
            this.trackBarDormitorioIntensidad.Size = new System.Drawing.Size(267, 56);
            this.trackBarDormitorioIntensidad.TabIndex = 2;
            this.trackBarDormitorioIntensidad.Scroll += new System.EventHandler(this.trackBarDormitorioIntensidad_Scroll);
            // 
            // panelDormitorioColor
            // 
            this.panelDormitorioColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelDormitorioColor.Location = new System.Drawing.Point(20, 62);
            this.panelDormitorioColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDormitorioColor.Name = "panelDormitorioColor";
            this.panelDormitorioColor.Size = new System.Drawing.Size(80, 74);
            this.panelDormitorioColor.TabIndex = 1;
            // 
            // lblDormitorioTitle
            // 
            this.lblDormitorioTitle.AutoSize = true;
            this.lblDormitorioTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDormitorioTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.lblDormitorioTitle.Location = new System.Drawing.Point(20, 18);
            this.lblDormitorioTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDormitorioTitle.Name = "lblDormitorioTitle";
            this.lblDormitorioTitle.Size = new System.Drawing.Size(112, 25);
            this.lblDormitorioTitle.TabIndex = 0;
            this.lblDormitorioTitle.Text = "Dormitorio";
            // 
            // panelBaño
            // 
            this.panelBaño.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelBaño.Controls.Add(this.lblBañoIntensidad);
            this.panelBaño.Controls.Add(this.trackBarBañoIntensidad);
            this.panelBaño.Controls.Add(this.panelBañoColor);
            this.panelBaño.Controls.Add(this.lblBañoTitle);
            this.panelBaño.Location = new System.Drawing.Point(547, 345);
            this.panelBaño.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelBaño.Name = "panelBaño";
            this.panelBaño.Size = new System.Drawing.Size(467, 185);
            this.panelBaño.TabIndex = 4;
            // 
            // lblBañoIntensidad
            // 
            this.lblBañoIntensidad.AutoSize = true;
            this.lblBañoIntensidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBañoIntensidad.ForeColor = System.Drawing.Color.Black;
            this.lblBañoIntensidad.Location = new System.Drawing.Point(393, 74);
            this.lblBañoIntensidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBañoIntensidad.Name = "lblBañoIntensidad";
            this.lblBañoIntensidad.Size = new System.Drawing.Size(53, 28);
            this.lblBañoIntensidad.TabIndex = 3;
            this.lblBañoIntensidad.Text = "60%";
            // 
            // trackBarBañoIntensidad
            // 
            this.trackBarBañoIntensidad.BackColor = System.Drawing.Color.LemonChiffon;
            this.trackBarBañoIntensidad.Location = new System.Drawing.Point(113, 62);
            this.trackBarBañoIntensidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBarBañoIntensidad.Maximum = 100;
            this.trackBarBañoIntensidad.Name = "trackBarBañoIntensidad";
            this.trackBarBañoIntensidad.Size = new System.Drawing.Size(267, 56);
            this.trackBarBañoIntensidad.TabIndex = 2;
            this.trackBarBañoIntensidad.Scroll += new System.EventHandler(this.trackBarBañoIntensidad_Scroll);
            // 
            // panelBañoColor
            // 
            this.panelBañoColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.panelBañoColor.Location = new System.Drawing.Point(20, 62);
            this.panelBañoColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelBañoColor.Name = "panelBañoColor";
            this.panelBañoColor.Size = new System.Drawing.Size(80, 74);
            this.panelBañoColor.TabIndex = 1;
            // 
            // lblBañoTitle
            // 
            this.lblBañoTitle.AutoSize = true;
            this.lblBañoTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblBañoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.lblBañoTitle.Location = new System.Drawing.Point(20, 18);
            this.lblBañoTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBañoTitle.Name = "lblBañoTitle";
            this.lblBañoTitle.Size = new System.Drawing.Size(58, 25);
            this.lblBañoTitle.TabIndex = 0;
            this.lblBañoTitle.Text = "Baño";
            // 
            // panelControles
            // 
            this.panelControles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelControles.Controls.Add(this.lblTemperaturaTitle);
            this.panelControles.Controls.Add(this.btnTemperaturaCalida);
            this.panelControles.Controls.Add(this.btnTemperaturaFria);
            this.panelControles.Controls.Add(this.btnTodoEncendido);
            this.panelControles.Controls.Add(this.btnTodoApagado);
            this.panelControles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControles.Location = new System.Drawing.Point(27, 554);
            this.panelControles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControles.Name = "panelControles";
            this.panelControles.Size = new System.Drawing.Size(986, 86);
            this.panelControles.TabIndex = 5;
            // 
            // lblTemperaturaTitle
            // 
            this.lblTemperaturaTitle.AutoSize = true;
            this.lblTemperaturaTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTemperaturaTitle.ForeColor = System.Drawing.Color.White;
            this.lblTemperaturaTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTemperaturaTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemperaturaTitle.Name = "lblTemperaturaTitle";
            this.lblTemperaturaTitle.Size = new System.Drawing.Size(185, 23);
            this.lblTemperaturaTitle.TabIndex = 0;
            this.lblTemperaturaTitle.Text = "Temperatura de Color";
            // 
            // btnTemperaturaCalida
            // 
            this.btnTemperaturaCalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.btnTemperaturaCalida.FlatAppearance.BorderSize = 0;
            this.btnTemperaturaCalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemperaturaCalida.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTemperaturaCalida.ForeColor = System.Drawing.Color.White;
            this.btnTemperaturaCalida.Location = new System.Drawing.Point(20, 43);
            this.btnTemperaturaCalida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTemperaturaCalida.Name = "btnTemperaturaCalida";
            this.btnTemperaturaCalida.Size = new System.Drawing.Size(133, 37);
            this.btnTemperaturaCalida.TabIndex = 1;
            this.btnTemperaturaCalida.Text = "Cálida";
            this.btnTemperaturaCalida.UseVisualStyleBackColor = false;
            this.btnTemperaturaCalida.Click += new System.EventHandler(this.btnTemperaturaCalida_Click);
            // 
            // btnTemperaturaFria
            // 
            this.btnTemperaturaFria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.btnTemperaturaFria.FlatAppearance.BorderSize = 0;
            this.btnTemperaturaFria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemperaturaFria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTemperaturaFria.ForeColor = System.Drawing.Color.White;
            this.btnTemperaturaFria.Location = new System.Drawing.Point(167, 43);
            this.btnTemperaturaFria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTemperaturaFria.Name = "btnTemperaturaFria";
            this.btnTemperaturaFria.Size = new System.Drawing.Size(133, 37);
            this.btnTemperaturaFria.TabIndex = 2;
            this.btnTemperaturaFria.Text = "Fría";
            this.btnTemperaturaFria.UseVisualStyleBackColor = false;
            this.btnTemperaturaFria.Click += new System.EventHandler(this.btnTemperaturaFria_Click);
            // 
            // btnTodoEncendido
            // 
            this.btnTodoEncendido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnTodoEncendido.FlatAppearance.BorderSize = 0;
            this.btnTodoEncendido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodoEncendido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTodoEncendido.ForeColor = System.Drawing.Color.White;
            this.btnTodoEncendido.Location = new System.Drawing.Point(773, 43);
            this.btnTodoEncendido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTodoEncendido.Name = "btnTodoEncendido";
            this.btnTodoEncendido.Size = new System.Drawing.Size(93, 37);
            this.btnTodoEncendido.TabIndex = 3;
            this.btnTodoEncendido.Text = "Todos ON";
            this.btnTodoEncendido.UseVisualStyleBackColor = false;
            this.btnTodoEncendido.Click += new System.EventHandler(this.btnTodoEncendido_Click);
            // 
            // btnTodoApagado
            // 
            this.btnTodoApagado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnTodoApagado.FlatAppearance.BorderSize = 0;
            this.btnTodoApagado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodoApagado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTodoApagado.ForeColor = System.Drawing.Color.White;
            this.btnTodoApagado.Location = new System.Drawing.Point(880, 43);
            this.btnTodoApagado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTodoApagado.Name = "btnTodoApagado";
            this.btnTodoApagado.Size = new System.Drawing.Size(93, 37);
            this.btnTodoApagado.TabIndex = 4;
            this.btnTodoApagado.Text = "Todos OFF";
            this.btnTodoApagado.UseVisualStyleBackColor = false;
            this.btnTodoApagado.Click += new System.EventHandler(this.btnTodoApagado_Click);
            // 
            // FormIluminacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1040, 665);
            this.Controls.Add(this.panelControles);
            this.Controls.Add(this.panelBaño);
            this.Controls.Add(this.panelDormitorio);
            this.Controls.Add(this.panelCocina);
            this.Controls.Add(this.panelSala);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormIluminacion";
            this.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.Text = "Iluminación";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSala.ResumeLayout(false);
            this.panelSala.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSalaIntensidad)).EndInit();
            this.panelCocina.ResumeLayout(false);
            this.panelCocina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCocinaIntensidad)).EndInit();
            this.panelDormitorio.ResumeLayout(false);
            this.panelDormitorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDormitorioIntensidad)).EndInit();
            this.panelBaño.ResumeLayout(false);
            this.panelBaño.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBañoIntensidad)).EndInit();
            this.panelControles.ResumeLayout(false);
            this.panelControles.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Panel panelSala;
        private System.Windows.Forms.Label lblSalaTitle;
        private System.Windows.Forms.Panel panelSalaColor;
        private System.Windows.Forms.TrackBar trackBarSalaIntensidad;
        private System.Windows.Forms.Label lblSalaIntensidad;
        private System.Windows.Forms.Panel panelCocina;
        private System.Windows.Forms.Label lblCocinaTitle;
        private System.Windows.Forms.Panel panelCocinaColor;
        private System.Windows.Forms.TrackBar trackBarCocinaIntensidad;
        private System.Windows.Forms.Label lblCocinaIntensidad;
        private System.Windows.Forms.Panel panelDormitorio;
        private System.Windows.Forms.Label lblDormitorioTitle;
        private System.Windows.Forms.Panel panelDormitorioColor;
        private System.Windows.Forms.TrackBar trackBarDormitorioIntensidad;
        private System.Windows.Forms.Label lblDormitorioIntensidad;
        private System.Windows.Forms.Panel panelBaño;
        private System.Windows.Forms.Label lblBañoTitle;
        private System.Windows.Forms.Panel panelBañoColor;
        private System.Windows.Forms.TrackBar trackBarBañoIntensidad;
        private System.Windows.Forms.Label lblBañoIntensidad;
        private System.Windows.Forms.Panel panelControles;
        private System.Windows.Forms.Label lblTemperaturaTitle;
        private System.Windows.Forms.Button btnTemperaturaCalida;
        private System.Windows.Forms.Button btnTemperaturaFria;
        private System.Windows.Forms.Button btnTodoEncendido;
        private System.Windows.Forms.Button btnTodoApagado;
    }
}
