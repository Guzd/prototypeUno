namespace prototypeUno
{
    partial class formPractica1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPractica1));
            this.BUSCA_PUERTO = new System.Windows.Forms.Button();
            this.PUERTO = new System.Windows.Forms.ComboBox();
            this.VELOCIDAD = new System.Windows.Forms.ComboBox();
            this.CONECTAR_DESCONECTAR = new System.Windows.Forms.Button();
            this.Temporizado = new System.Windows.Forms.Timer(this.components);
            this.ConexionSerial = new System.IO.Ports.SerialPort(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOut1 = new System.Windows.Forms.Button();
            this.btnOut2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOut3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOut4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOut5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOut6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOut7 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnOut8 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbNodos = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbconfirmacion = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnNodo0 = new System.Windows.Forms.Button();
            this.btnNodo1 = new System.Windows.Forms.Button();
            this.lbNodo0 = new System.Windows.Forms.Label();
            this.lbNodo1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BUSCA_PUERTO
            // 
            this.BUSCA_PUERTO.Location = new System.Drawing.Point(21, 22);
            this.BUSCA_PUERTO.Name = "BUSCA_PUERTO";
            this.BUSCA_PUERTO.Size = new System.Drawing.Size(122, 26);
            this.BUSCA_PUERTO.TabIndex = 0;
            this.BUSCA_PUERTO.Text = "Buscar Puertos ";
            this.BUSCA_PUERTO.UseVisualStyleBackColor = true;
            this.BUSCA_PUERTO.Click += new System.EventHandler(this.BUSCA_PUERTO_Click);
            // 
            // PUERTO
            // 
            this.PUERTO.FormattingEnabled = true;
            this.PUERTO.Location = new System.Drawing.Point(22, 61);
            this.PUERTO.Name = "PUERTO";
            this.PUERTO.Size = new System.Drawing.Size(121, 21);
            this.PUERTO.TabIndex = 1;
            this.PUERTO.Text = "Puertos COM";
            // 
            // VELOCIDAD
            // 
            this.VELOCIDAD.FormattingEnabled = true;
            this.VELOCIDAD.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "72800",
            "115200",
            "250000",
            "1000000"});
            this.VELOCIDAD.Location = new System.Drawing.Point(21, 95);
            this.VELOCIDAD.Name = "VELOCIDAD";
            this.VELOCIDAD.Size = new System.Drawing.Size(121, 21);
            this.VELOCIDAD.TabIndex = 2;
            this.VELOCIDAD.Text = "Vel. Transmision";
            // 
            // CONECTAR_DESCONECTAR
            // 
            this.CONECTAR_DESCONECTAR.Location = new System.Drawing.Point(22, 129);
            this.CONECTAR_DESCONECTAR.Name = "CONECTAR_DESCONECTAR";
            this.CONECTAR_DESCONECTAR.Size = new System.Drawing.Size(120, 23);
            this.CONECTAR_DESCONECTAR.TabIndex = 3;
            this.CONECTAR_DESCONECTAR.Text = "Conectar";
            this.CONECTAR_DESCONECTAR.UseVisualStyleBackColor = true;
            this.CONECTAR_DESCONECTAR.Click += new System.EventHandler(this.CONECTAR_DESCONECTAR_Click);
            // 
            // Temporizado
            // 
            this.Temporizado.Tick += new System.EventHandler(this.Temporizado_Tick);
            // 
            // ConexionSerial
            // 
            this.ConexionSerial.ReceivedBytesThreshold = 5;
            this.ConexionSerial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.ConexionSerial_DataReceived);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(170, 62);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(636, 88);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Practica 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Salida 1 ";
            // 
            // btnOut1
            // 
            this.btnOut1.Enabled = false;
            this.btnOut1.Location = new System.Drawing.Point(209, 213);
            this.btnOut1.Name = "btnOut1";
            this.btnOut1.Size = new System.Drawing.Size(75, 23);
            this.btnOut1.TabIndex = 7;
            this.btnOut1.Text = "HIGH";
            this.btnOut1.UseVisualStyleBackColor = true;
            this.btnOut1.Click += new System.EventHandler(this.btnOut1_Click);
            // 
            // btnOut2
            // 
            this.btnOut2.Enabled = false;
            this.btnOut2.Location = new System.Drawing.Point(209, 242);
            this.btnOut2.Name = "btnOut2";
            this.btnOut2.Size = new System.Drawing.Size(75, 23);
            this.btnOut2.TabIndex = 9;
            this.btnOut2.Text = "HIGH";
            this.btnOut2.UseVisualStyleBackColor = true;
            this.btnOut2.Click += new System.EventHandler(this.btnOut2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Salida 2";
            // 
            // btnOut3
            // 
            this.btnOut3.Enabled = false;
            this.btnOut3.Location = new System.Drawing.Point(209, 271);
            this.btnOut3.Name = "btnOut3";
            this.btnOut3.Size = new System.Drawing.Size(75, 23);
            this.btnOut3.TabIndex = 11;
            this.btnOut3.Text = "HIGH";
            this.btnOut3.UseVisualStyleBackColor = true;
            this.btnOut3.Click += new System.EventHandler(this.btnOut3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Salida 3";
            // 
            // btnOut4
            // 
            this.btnOut4.Enabled = false;
            this.btnOut4.Location = new System.Drawing.Point(209, 300);
            this.btnOut4.Name = "btnOut4";
            this.btnOut4.Size = new System.Drawing.Size(75, 23);
            this.btnOut4.TabIndex = 13;
            this.btnOut4.Text = "HIGH";
            this.btnOut4.UseVisualStyleBackColor = true;
            this.btnOut4.Click += new System.EventHandler(this.btnOut4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Salida 4";
            // 
            // btnOut5
            // 
            this.btnOut5.Enabled = false;
            this.btnOut5.Location = new System.Drawing.Point(209, 329);
            this.btnOut5.Name = "btnOut5";
            this.btnOut5.Size = new System.Drawing.Size(75, 23);
            this.btnOut5.TabIndex = 15;
            this.btnOut5.Text = "HIGH";
            this.btnOut5.UseVisualStyleBackColor = true;
            this.btnOut5.Click += new System.EventHandler(this.btnOut5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Salida 5";
            // 
            // btnOut6
            // 
            this.btnOut6.Enabled = false;
            this.btnOut6.Location = new System.Drawing.Point(209, 358);
            this.btnOut6.Name = "btnOut6";
            this.btnOut6.Size = new System.Drawing.Size(75, 23);
            this.btnOut6.TabIndex = 17;
            this.btnOut6.Text = "HIGH";
            this.btnOut6.UseVisualStyleBackColor = true;
            this.btnOut6.Click += new System.EventHandler(this.btnOut6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Salida 6";
            // 
            // btnOut7
            // 
            this.btnOut7.Enabled = false;
            this.btnOut7.Location = new System.Drawing.Point(209, 387);
            this.btnOut7.Name = "btnOut7";
            this.btnOut7.Size = new System.Drawing.Size(75, 23);
            this.btnOut7.TabIndex = 19;
            this.btnOut7.Text = "HIGH";
            this.btnOut7.UseVisualStyleBackColor = true;
            this.btnOut7.Click += new System.EventHandler(this.btnOut7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(152, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Salida 7";
            // 
            // btnOut8
            // 
            this.btnOut8.Enabled = false;
            this.btnOut8.Location = new System.Drawing.Point(209, 416);
            this.btnOut8.Name = "btnOut8";
            this.btnOut8.Size = new System.Drawing.Size(75, 23);
            this.btnOut8.TabIndex = 21;
            this.btnOut8.Text = "HIGH";
            this.btnOut8.UseVisualStyleBackColor = true;
            this.btnOut8.Click += new System.EventHandler(this.btnOut8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(152, 421);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Salida 8 ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(148, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Selección de nivel de salidas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(309, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Seleccion de Nodos";
            // 
            // cbNodos
            // 
            this.cbNodos.FormattingEnabled = true;
            this.cbNodos.Items.AddRange(new object[] {
            "Nodo 0",
            "Nodo 1",
            "Nodo 2",
            "Nodo 3",
            "Nodo 4",
            "Nodo 5",
            "Broadcast"});
            this.cbNodos.Location = new System.Drawing.Point(312, 218);
            this.cbNodos.Name = "cbNodos";
            this.cbNodos.Size = new System.Drawing.Size(121, 21);
            this.cbNodos.TabIndex = 24;
            this.cbNodos.Text = "Nodos";
            this.cbNodos.SelectedIndexChanged += new System.EventHandler(this.cbNodos_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(309, 271);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Datos:";
            // 
            // lbconfirmacion
            // 
            this.lbconfirmacion.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbconfirmacion.Location = new System.Drawing.Point(312, 300);
            this.lbconfirmacion.Name = "lbconfirmacion";
            this.lbconfirmacion.Size = new System.Drawing.Size(121, 32);
            this.lbconfirmacion.TabIndex = 26;
            this.lbconfirmacion.Text = "Confirmacion";
            this.lbconfirmacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label17, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label14, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label16, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNodo0, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNodo1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbNodo0, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbNodo1, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(387, 129);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(63, 2);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 23);
            this.label17.TabIndex = 3;
            this.label17.Text = "Intento";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(5, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 23);
            this.label13.TabIndex = 0;
            this.label13.Text = "Nodo";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(121, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(182, 23);
            this.label14.TabIndex = 1;
            this.label14.Text = "Lectura";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(311, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 23);
            this.label16.TabIndex = 2;
            this.label16.Text = "Resultado";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNodo0
            // 
            this.btnNodo0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNodo0.Location = new System.Drawing.Point(5, 31);
            this.btnNodo0.Name = "btnNodo0";
            this.btnNodo0.Size = new System.Drawing.Size(50, 42);
            this.btnNodo0.TabIndex = 4;
            this.btnNodo0.UseVisualStyleBackColor = true;
            // 
            // btnNodo1
            // 
            this.btnNodo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNodo1.Location = new System.Drawing.Point(5, 81);
            this.btnNodo1.Name = "btnNodo1";
            this.btnNodo1.Size = new System.Drawing.Size(50, 43);
            this.btnNodo1.TabIndex = 5;
            this.btnNodo1.UseVisualStyleBackColor = true;
            // 
            // lbNodo0
            // 
            this.lbNodo0.AutoSize = true;
            this.lbNodo0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNodo0.Location = new System.Drawing.Point(121, 28);
            this.lbNodo0.Name = "lbNodo0";
            this.lbNodo0.Size = new System.Drawing.Size(182, 48);
            this.lbNodo0.TabIndex = 6;
            this.lbNodo0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNodo1
            // 
            this.lbNodo1.AutoSize = true;
            this.lbNodo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNodo1.Location = new System.Drawing.Point(121, 78);
            this.lbNodo1.Name = "lbNodo1";
            this.lbNodo1.Size = new System.Drawing.Size(182, 49);
            this.lbNodo1.TabIndex = 7;
            this.lbNodo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Datos Recibidos:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(454, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 281);
            this.panel1.TabIndex = 29;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.AutoSize = true;
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCerrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(817, 491);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 19);
            this.btnCerrar.TabIndex = 30;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // formPractica1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 530);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbconfirmacion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbNodos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnOut8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnOut7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnOut6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnOut5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnOut4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOut3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOut2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOut1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.CONECTAR_DESCONECTAR);
            this.Controls.Add(this.VELOCIDAD);
            this.Controls.Add(this.PUERTO);
            this.Controls.Add(this.BUSCA_PUERTO);
            this.Name = "formPractica1";
            this.Text = "formPractica1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formPractica1_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BUSCA_PUERTO;
        private System.Windows.Forms.ComboBox PUERTO;
        private System.Windows.Forms.ComboBox VELOCIDAD;
        private System.Windows.Forms.Button CONECTAR_DESCONECTAR;
        private System.Windows.Forms.Timer Temporizado;
        private System.IO.Ports.SerialPort ConexionSerial;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOut1;
        private System.Windows.Forms.Button btnOut2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOut3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOut4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOut5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOut6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOut7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnOut8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbNodos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbconfirmacion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnNodo0;
        private System.Windows.Forms.Button btnNodo1;
        private System.Windows.Forms.Label lbNodo0;
        private System.Windows.Forms.Label lbNodo1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label btnCerrar;
    }
}