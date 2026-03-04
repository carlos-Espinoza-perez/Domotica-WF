namespace Domotica.Views
{
    partial class Clima
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
            this.panelRedondeado1 = new PanelRedondeado();
            this.panelRedondeado2 = new PanelRedondeado();
            this.panelRedondeado3 = new PanelRedondeado();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // panelRedondeado1
            // 
            this.panelRedondeado1.BackColor = System.Drawing.Color.Transparent;
            this.panelRedondeado1.ColorTarjeta = System.Drawing.Color.White;
            this.panelRedondeado1.Location = new System.Drawing.Point(12, 69);
            this.panelRedondeado1.Name = "panelRedondeado1";
            this.panelRedondeado1.Padding = new System.Windows.Forms.Padding(8);
            this.panelRedondeado1.RadioBordes = 15;
            this.panelRedondeado1.Size = new System.Drawing.Size(494, 369);
            this.panelRedondeado1.TabIndex = 0;
            this.panelRedondeado1.TamañoSombra = 6;
            // 
            // panelRedondeado2
            // 
            this.panelRedondeado2.BackColor = System.Drawing.Color.Transparent;
            this.panelRedondeado2.ColorTarjeta = System.Drawing.Color.White;
            this.panelRedondeado2.Location = new System.Drawing.Point(528, 69);
            this.panelRedondeado2.Name = "panelRedondeado2";
            this.panelRedondeado2.Padding = new System.Windows.Forms.Padding(8);
            this.panelRedondeado2.RadioBordes = 15;
            this.panelRedondeado2.Size = new System.Drawing.Size(527, 172);
            this.panelRedondeado2.TabIndex = 1;
            this.panelRedondeado2.TamañoSombra = 6;
            // 
            // panelRedondeado3
            // 
            this.panelRedondeado3.BackColor = System.Drawing.Color.Transparent;
            this.panelRedondeado3.ColorTarjeta = System.Drawing.Color.White;
            this.panelRedondeado3.Location = new System.Drawing.Point(528, 266);
            this.panelRedondeado3.Name = "panelRedondeado3";
            this.panelRedondeado3.Padding = new System.Windows.Forms.Padding(8);
            this.panelRedondeado3.RadioBordes = 15;
            this.panelRedondeado3.Size = new System.Drawing.Size(527, 172);
            this.panelRedondeado3.TabIndex = 2;
            this.panelRedondeado3.TamañoSombra = 6;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(99, 19);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(147, 26);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Control Clima";
            // 
            // Clima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panelRedondeado3);
            this.Controls.Add(this.panelRedondeado2);
            this.Controls.Add(this.panelRedondeado1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Clima";
            this.Text = "Clima";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PanelRedondeado panelRedondeado1;
        private PanelRedondeado panelRedondeado2;
        private PanelRedondeado panelRedondeado3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}