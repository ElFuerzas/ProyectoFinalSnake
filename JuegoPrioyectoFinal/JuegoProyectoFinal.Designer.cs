namespace JuegoPrioyectoFinal
{
    partial class JuegoSerpiente
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
            this.botonStart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPuntaje = new System.Windows.Forms.Label();
            this.txtPuntajeMasAlto = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Tiempo = new System.Windows.Forms.Label();
            this.mensajePerdida1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // botonStart
            // 
            this.botonStart.BackColor = System.Drawing.Color.DarkGreen;
            this.botonStart.Font = new System.Drawing.Font("Bungee Inline", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonStart.ForeColor = System.Drawing.Color.White;
            this.botonStart.Location = new System.Drawing.Point(49, 15);
            this.botonStart.Name = "botonStart";
            this.botonStart.Size = new System.Drawing.Size(180, 61);
            this.botonStart.TabIndex = 0;
            this.botonStart.Text = "Start";
            this.botonStart.UseVisualStyleBackColor = false;
            this.botonStart.Click += new System.EventHandler(this.botonStart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(49, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(650, 600);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtPuntaje
            // 
            this.txtPuntaje.AutoSize = true;
            this.txtPuntaje.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuntaje.Location = new System.Drawing.Point(260, 9);
            this.txtPuntaje.Name = "txtPuntaje";
            this.txtPuntaje.Size = new System.Drawing.Size(154, 32);
            this.txtPuntaje.TabIndex = 2;
            this.txtPuntaje.Text = "Puntaje:  0";
            // 
            // txtPuntajeMasAlto
            // 
            this.txtPuntajeMasAlto.AutoSize = true;
            this.txtPuntajeMasAlto.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuntajeMasAlto.Location = new System.Drawing.Point(260, 54);
            this.txtPuntajeMasAlto.Name = "txtPuntajeMasAlto";
            this.txtPuntajeMasAlto.Size = new System.Drawing.Size(252, 32);
            this.txtPuntajeMasAlto.TabIndex = 2;
            this.txtPuntajeMasAlto.Text = "Puntaje mas alto: ";
            this.txtPuntajeMasAlto.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Tiempo
            // 
            this.Tiempo.AutoSize = true;
            this.Tiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tiempo.Location = new System.Drawing.Point(586, 15);
            this.Tiempo.Name = "Tiempo";
            this.Tiempo.Size = new System.Drawing.Size(0, 46);
            this.Tiempo.TabIndex = 3;
            // 
            // mensajePerdida1
            // 
            this.mensajePerdida1.AutoSize = true;
            this.mensajePerdida1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensajePerdida1.ForeColor = System.Drawing.Color.Red;
            this.mensajePerdida1.Location = new System.Drawing.Point(553, 68);
            this.mensajePerdida1.Name = "mensajePerdida1";
            this.mensajePerdida1.Size = new System.Drawing.Size(0, 18);
            this.mensajePerdida1.TabIndex = 4;
            // 
            // JuegoSerpiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 725);
            this.Controls.Add(this.mensajePerdida1);
            this.Controls.Add(this.Tiempo);
            this.Controls.Add(this.txtPuntajeMasAlto);
            this.Controls.Add(this.txtPuntaje);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botonStart);
            this.Name = "JuegoSerpiente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JuegoSerpiente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.JuegoSerpiente_FormClosed);
            this.Load += new System.EventHandler(this.JuegoSerpiente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtPuntaje;
        private System.Windows.Forms.Label txtPuntajeMasAlto;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Tiempo;
        private System.Windows.Forms.Label mensajePerdida1;
    }
}

