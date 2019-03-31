namespace prototypeUno
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuVertical = new System.Windows.Forms.Panel();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.BtnInicio = new System.Windows.Forms.PictureBox();
            this.BtnPractica1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnPractica2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnPractica3 = new System.Windows.Forms.Button();
            this.menuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuVertical.Controls.Add(this.panel3);
            this.menuVertical.Controls.Add(this.BtnPractica3);
            this.menuVertical.Controls.Add(this.panel2);
            this.menuVertical.Controls.Add(this.panel1);
            this.menuVertical.Controls.Add(this.BtnPractica2);
            this.menuVertical.Controls.Add(this.BtnPractica1);
            this.menuVertical.Controls.Add(this.BtnInicio);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(170, 450);
            this.menuVertical.TabIndex = 0;
            // 
            // panelContenido
            // 
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(170, 0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(630, 450);
            this.panelContenido.TabIndex = 1;
            // 
            // BtnInicio
            // 
            this.BtnInicio.Image = ((System.Drawing.Image)(resources.GetObject("BtnInicio.Image")));
            this.BtnInicio.Location = new System.Drawing.Point(0, 12);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(170, 102);
            this.BtnInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnInicio.TabIndex = 0;
            this.BtnInicio.TabStop = false;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // BtnPractica1
            // 
            this.BtnPractica1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BtnPractica1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPractica1.FlatAppearance.BorderSize = 0;
            this.BtnPractica1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnPractica1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPractica1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPractica1.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnPractica1.Location = new System.Drawing.Point(0, 128);
            this.BtnPractica1.Name = "BtnPractica1";
            this.BtnPractica1.Size = new System.Drawing.Size(170, 40);
            this.BtnPractica1.TabIndex = 1;
            this.BtnPractica1.Text = "Practica 1 ";
            this.BtnPractica1.UseVisualStyleBackColor = false;
            this.BtnPractica1.Click += new System.EventHandler(this.BtnPractica1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(0, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 40);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(0, 174);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 40);
            this.panel2.TabIndex = 4;
            // 
            // BtnPractica2
            // 
            this.BtnPractica2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BtnPractica2.FlatAppearance.BorderSize = 0;
            this.BtnPractica2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnPractica2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPractica2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPractica2.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnPractica2.Location = new System.Drawing.Point(0, 174);
            this.BtnPractica2.Name = "BtnPractica2";
            this.BtnPractica2.Size = new System.Drawing.Size(170, 40);
            this.BtnPractica2.TabIndex = 3;
            this.BtnPractica2.Text = "Practica 2 ";
            this.BtnPractica2.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(0, 220);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 40);
            this.panel3.TabIndex = 6;
            // 
            // BtnPractica3
            // 
            this.BtnPractica3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BtnPractica3.FlatAppearance.BorderSize = 0;
            this.BtnPractica3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnPractica3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPractica3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPractica3.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnPractica3.Location = new System.Drawing.Point(0, 220);
            this.BtnPractica3.Name = "BtnPractica3";
            this.BtnPractica3.Size = new System.Drawing.Size(170, 40);
            this.BtnPractica3.TabIndex = 5;
            this.BtnPractica3.Text = "Practica 3";
            this.BtnPractica3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.menuVertical);
            this.Name = "Form1";
            this.Text = "ComunicacionXbee";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Button BtnPractica1;
        private System.Windows.Forms.PictureBox BtnInicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnPractica3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnPractica2;
    }
}

