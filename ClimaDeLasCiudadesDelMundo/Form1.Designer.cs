namespace ClimaDeLasCiudadesDelMundo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.TBCiudad = new System.Windows.Forms.TextBox();
            this.BTBuscar = new System.Windows.Forms.Button();
            this.labCondicion = new System.Windows.Forms.Label();
            this.labDetalles = new System.Windows.Forms.Label();
            this.labSunrise = new System.Windows.Forms.Label();
            this.labSunset = new System.Windows.Forms.Label();
            this.labSpeed = new System.Windows.Forms.Label();
            this.labPression = new System.Windows.Forms.Label();
            this.atardecer = new System.Windows.Forms.Label();
            this.amanecer = new System.Windows.Forms.Label();
            this.Presion = new System.Windows.Forms.Label();
            this.Viento = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.condicion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblHora = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(108, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ciudad:";
            // 
            // TBCiudad
            // 
            this.TBCiudad.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCiudad.ForeColor = System.Drawing.Color.Black;
            this.TBCiudad.Location = new System.Drawing.Point(182, 12);
            this.TBCiudad.Name = "TBCiudad";
            this.TBCiudad.Size = new System.Drawing.Size(299, 25);
            this.TBCiudad.TabIndex = 1;
            this.TBCiudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCiudad_KeyPress);
            // 
            // BTBuscar
            // 
            this.BTBuscar.BackColor = System.Drawing.Color.Transparent;
            this.BTBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTBuscar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTBuscar.Location = new System.Drawing.Point(487, 12);
            this.BTBuscar.Name = "BTBuscar";
            this.BTBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BTBuscar.Size = new System.Drawing.Size(91, 28);
            this.BTBuscar.TabIndex = 2;
            this.BTBuscar.Text = "Buscar";
            this.BTBuscar.UseVisualStyleBackColor = false;
            this.BTBuscar.Click += new System.EventHandler(this.BTBuscar_Click);
            // 
            // labCondicion
            // 
            this.labCondicion.AutoSize = true;
            this.labCondicion.BackColor = System.Drawing.Color.Transparent;
            this.labCondicion.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.labCondicion.ForeColor = System.Drawing.Color.White;
            this.labCondicion.Location = new System.Drawing.Point(23, 69);
            this.labCondicion.Name = "labCondicion";
            this.labCondicion.Size = new System.Drawing.Size(92, 21);
            this.labCondicion.TabIndex = 3;
            this.labCondicion.Text = "Condicion:";
            // 
            // labDetalles
            // 
            this.labDetalles.AutoSize = true;
            this.labDetalles.BackColor = System.Drawing.Color.Transparent;
            this.labDetalles.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.labDetalles.ForeColor = System.Drawing.Color.White;
            this.labDetalles.Location = new System.Drawing.Point(23, 107);
            this.labDetalles.Name = "labDetalles";
            this.labDetalles.Size = new System.Drawing.Size(72, 21);
            this.labDetalles.TabIndex = 4;
            this.labDetalles.Text = "Detalles:";
            // 
            // labSunrise
            // 
            this.labSunrise.AutoSize = true;
            this.labSunrise.BackColor = System.Drawing.Color.Transparent;
            this.labSunrise.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.labSunrise.ForeColor = System.Drawing.Color.White;
            this.labSunrise.Location = new System.Drawing.Point(23, 149);
            this.labSunrise.Name = "labSunrise";
            this.labSunrise.Size = new System.Drawing.Size(89, 21);
            this.labSunrise.TabIndex = 5;
            this.labSunrise.Text = "Amanecer:";
            // 
            // labSunset
            // 
            this.labSunset.AutoSize = true;
            this.labSunset.BackColor = System.Drawing.Color.Transparent;
            this.labSunset.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.labSunset.ForeColor = System.Drawing.Color.White;
            this.labSunset.Location = new System.Drawing.Point(23, 184);
            this.labSunset.Name = "labSunset";
            this.labSunset.Size = new System.Drawing.Size(87, 21);
            this.labSunset.TabIndex = 6;
            this.labSunset.Text = "Atardecer:";
            // 
            // labSpeed
            // 
            this.labSpeed.AutoSize = true;
            this.labSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labSpeed.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.labSpeed.ForeColor = System.Drawing.Color.White;
            this.labSpeed.Location = new System.Drawing.Point(23, 224);
            this.labSpeed.Name = "labSpeed";
            this.labSpeed.Size = new System.Drawing.Size(119, 21);
            this.labSpeed.TabIndex = 7;
            this.labSpeed.Text = "Vel. del viento:";
            // 
            // labPression
            // 
            this.labPression.AutoSize = true;
            this.labPression.BackColor = System.Drawing.Color.Transparent;
            this.labPression.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.labPression.ForeColor = System.Drawing.Color.White;
            this.labPression.Location = new System.Drawing.Point(23, 268);
            this.labPression.Name = "labPression";
            this.labPression.Size = new System.Drawing.Size(70, 21);
            this.labPression.TabIndex = 8;
            this.labPression.Text = "Presion:";
            // 
            // atardecer
            // 
            this.atardecer.AutoSize = true;
            this.atardecer.BackColor = System.Drawing.Color.Transparent;
            this.atardecer.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.atardecer.ForeColor = System.Drawing.Color.White;
            this.atardecer.Location = new System.Drawing.Point(148, 184);
            this.atardecer.Name = "atardecer";
            this.atardecer.Size = new System.Drawing.Size(0, 21);
            this.atardecer.TabIndex = 9;
            // 
            // amanecer
            // 
            this.amanecer.AutoSize = true;
            this.amanecer.BackColor = System.Drawing.Color.Transparent;
            this.amanecer.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.amanecer.ForeColor = System.Drawing.Color.White;
            this.amanecer.Location = new System.Drawing.Point(148, 149);
            this.amanecer.Name = "amanecer";
            this.amanecer.Size = new System.Drawing.Size(0, 21);
            this.amanecer.TabIndex = 10;
            // 
            // Presion
            // 
            this.Presion.AutoSize = true;
            this.Presion.BackColor = System.Drawing.Color.Transparent;
            this.Presion.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.Presion.ForeColor = System.Drawing.Color.White;
            this.Presion.Location = new System.Drawing.Point(148, 268);
            this.Presion.Name = "Presion";
            this.Presion.Size = new System.Drawing.Size(0, 21);
            this.Presion.TabIndex = 11;
            // 
            // Viento
            // 
            this.Viento.AutoSize = true;
            this.Viento.BackColor = System.Drawing.Color.Transparent;
            this.Viento.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.Viento.ForeColor = System.Drawing.Color.White;
            this.Viento.Location = new System.Drawing.Point(148, 224);
            this.Viento.Name = "Viento";
            this.Viento.Size = new System.Drawing.Size(0, 21);
            this.Viento.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(566, 218);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // condicion
            // 
            this.condicion.AutoSize = true;
            this.condicion.BackColor = System.Drawing.Color.Transparent;
            this.condicion.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.condicion.ForeColor = System.Drawing.Color.White;
            this.condicion.Location = new System.Drawing.Point(148, 69);
            this.condicion.Name = "condicion";
            this.condicion.Size = new System.Drawing.Size(0, 21);
            this.condicion.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(148, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 15;
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.BackColor = System.Drawing.Color.Transparent;
            this.LblHora.Font = new System.Drawing.Font("Times New Roman", 60F);
            this.LblHora.ForeColor = System.Drawing.Color.White;
            this.LblHora.Location = new System.Drawing.Point(225, 107);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(220, 114);
            this.LblHora.TabIndex = 16;
            this.LblHora.Text = "N/A";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.BackColor = System.Drawing.Color.Transparent;
            this.LblFecha.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.LblFecha.ForeColor = System.Drawing.Color.White;
            this.LblFecha.Location = new System.Drawing.Point(211, 56);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(75, 39);
            this.LblFecha.TabIndex = 17;
            this.LblFecha.Text = "N/A";
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 401);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.LblHora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.condicion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Viento);
            this.Controls.Add(this.Presion);
            this.Controls.Add(this.amanecer);
            this.Controls.Add(this.atardecer);
            this.Controls.Add(this.labPression);
            this.Controls.Add(this.labSpeed);
            this.Controls.Add(this.labSunset);
            this.Controls.Add(this.labSunrise);
            this.Controls.Add(this.labDetalles);
            this.Controls.Add(this.labCondicion);
            this.Controls.Add(this.BTBuscar);
            this.Controls.Add(this.TBCiudad);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBCiudad;
        private System.Windows.Forms.Button BTBuscar;
        private System.Windows.Forms.Label labCondicion;
        private System.Windows.Forms.Label labDetalles;
        private System.Windows.Forms.Label labSunrise;
        private System.Windows.Forms.Label labSunset;
        private System.Windows.Forms.Label labSpeed;
        private System.Windows.Forms.Label labPression;
        private System.Windows.Forms.Label atardecer;
        private System.Windows.Forms.Label amanecer;
        private System.Windows.Forms.Label Presion;
        private System.Windows.Forms.Label Viento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label condicion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Timer HoraFecha;
    }
}

