namespace BoxeoPuñetazos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            energiaCPU = new ProgressBar();
            energiaJugador = new ProgressBar();
            padalustro = new PictureBox();
            mikeTyson = new PictureBox();
            ataqueBoxeador = new System.Windows.Forms.Timer(components);
            movimientoBoxeador = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)padalustro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mikeTyson).BeginInit();
            SuspendLayout();
            // 
            // energiaCPU
            // 
            energiaCPU.Location = new Point(10, 39);
            energiaCPU.Name = "energiaCPU";
            energiaCPU.Size = new Size(275, 34);
            energiaCPU.TabIndex = 0;
            energiaCPU.Value = 100;
            // 
            // energiaJugador
            // 
            energiaJugador.Location = new Point(447, 39);
            energiaJugador.Name = "energiaJugador";
            energiaJugador.Size = new Size(275, 34);
            energiaJugador.TabIndex = 1;
            energiaJugador.Value = 100;
            // 
            // padalustro
            // 
            padalustro.BackColor = Color.Transparent;
            padalustro.Image = Properties.Resources.boxer_stand;
            padalustro.Location = new Point(335, 385);
            padalustro.Name = "padalustro";
            padalustro.Size = new Size(61, 153);
            padalustro.SizeMode = PictureBoxSizeMode.AutoSize;
            padalustro.TabIndex = 2;
            padalustro.TabStop = false;
            // 
            // mikeTyson
            // 
            mikeTyson.BackColor = Color.Transparent;
            mikeTyson.Image = Properties.Resources.enemy_stand;
            mikeTyson.Location = new Point(335, 180);
            mikeTyson.Name = "mikeTyson";
            mikeTyson.Size = new Size(77, 185);
            mikeTyson.SizeMode = PictureBoxSizeMode.AutoSize;
            mikeTyson.TabIndex = 3;
            mikeTyson.TabStop = false;
            // 
            // ataqueBoxeador
            // 
            ataqueBoxeador.Enabled = true;
            ataqueBoxeador.Interval = 500;
            ataqueBoxeador.Tick += EventoTemporizadorAtaqueBoxeador;
            // 
            // movimientoBoxeador
            // 
            movimientoBoxeador.Enabled = true;
            movimientoBoxeador.Interval = 20;
            movimientoBoxeador.Tick += EventoTemporizadorMovimientoBoxeador;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(734, 544);
            Controls.Add(padalustro);
            Controls.Add(energiaJugador);
            Controls.Add(energiaCPU);
            Controls.Add(mikeTyson);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Lucha Libre Pixelado";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)padalustro).EndInit();
            ((System.ComponentModel.ISupportInitialize)mikeTyson).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar energiaCPU;
        private ProgressBar energiaJugador;
        private PictureBox padalustro;
        private PictureBox mikeTyson;
        private System.Windows.Forms.Timer ataqueBoxeador;
        private System.Windows.Forms.Timer movimientoBoxeador;
    }
}