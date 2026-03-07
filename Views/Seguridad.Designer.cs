namespace Domotica.Views
{
    partial class Seguridad
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
            this.button1 = new System.Windows.Forms.Button();
            this.panelRedondeado1 = new PanelRedondeado();
            this.panelRedondeado2 = new PanelRedondeado();
            this.panelRedondeado3 = new PanelRedondeado();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(581, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Seguridad";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panelRedondeado1
            // 
            this.panelRedondeado1.BackColor = System.Drawing.Color.Transparent;
            this.panelRedondeado1.ColorTarjeta = System.Drawing.Color.White;
            this.panelRedondeado1.Location = new System.Drawing.Point(32, 43);
            this.panelRedondeado1.Name = "panelRedondeado1";
            this.panelRedondeado1.Padding = new System.Windows.Forms.Padding(8);
            this.panelRedondeado1.RadioBordes = 15;
            this.panelRedondeado1.Size = new System.Drawing.Size(476, 223);
            this.panelRedondeado1.TabIndex = 4;
            this.panelRedondeado1.TamañoSombra = 6;
            // 
            // panelRedondeado2
            // 
            this.panelRedondeado2.BackColor = System.Drawing.Color.Transparent;
            this.panelRedondeado2.ColorTarjeta = System.Drawing.Color.White;
            this.panelRedondeado2.Location = new System.Drawing.Point(889, 126);
            this.panelRedondeado2.Name = "panelRedondeado2";
            this.panelRedondeado2.Padding = new System.Windows.Forms.Padding(8);
            this.panelRedondeado2.RadioBordes = 15;
            this.panelRedondeado2.Size = new System.Drawing.Size(200, 100);
            this.panelRedondeado2.TabIndex = 5;
            this.panelRedondeado2.TamañoSombra = 6;
            // 
            // panelRedondeado3
            // 
            this.panelRedondeado3.BackColor = System.Drawing.Color.Transparent;
            this.panelRedondeado3.ColorTarjeta = System.Drawing.Color.White;
            this.panelRedondeado3.Location = new System.Drawing.Point(42, 387);
            this.panelRedondeado3.Name = "panelRedondeado3";
            this.panelRedondeado3.Padding = new System.Windows.Forms.Padding(8);
            this.panelRedondeado3.RadioBordes = 15;
            this.panelRedondeado3.Size = new System.Drawing.Size(526, 136);
            this.panelRedondeado3.TabIndex = 6;
            this.panelRedondeado3.TamañoSombra = 6;
            // 
            // Seguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panelRedondeado3);
            this.Controls.Add(this.panelRedondeado2);
            this.Controls.Add(this.panelRedondeado1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Seguridad";
            this.Text = "Seguridad";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private PanelRedondeado panelRedondeado1;
        private PanelRedondeado panelRedondeado2;
        private PanelRedondeado panelRedondeado3;
    }
}