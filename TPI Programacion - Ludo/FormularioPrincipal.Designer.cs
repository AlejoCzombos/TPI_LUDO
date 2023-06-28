namespace TPI_Programacion___Ludo
{
    partial class FormularioPrincipal
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
            timerSeleccionFicha = new System.Windows.Forms.Timer(components);
            imagenTablero = new PictureBox();
            fichaRoja0 = new PictureBox();
            fichaRoja1 = new PictureBox();
            fichaRoja2 = new PictureBox();
            fichaRoja3 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imagenTablero).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fichaRoja0).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fichaRoja1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fichaRoja2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fichaRoja3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // timerSeleccionFicha
            // 
            timerSeleccionFicha.Enabled = true;
            timerSeleccionFicha.Interval = 500;
            // 
            // imagenTablero
            // 
            imagenTablero.Dock = DockStyle.Fill;
            imagenTablero.Image = Properties.Resources.TableroLudo;
            imagenTablero.Location = new Point(0, 0);
            imagenTablero.Name = "imagenTablero";
            imagenTablero.Size = new Size(1077, 662);
            imagenTablero.TabIndex = 0;
            imagenTablero.TabStop = false;
            imagenTablero.Click += imagenTablero_Click;
            // 
            // fichaRoja0
            // 
            fichaRoja0.BackColor = Color.Transparent;
            fichaRoja0.Cursor = Cursors.Hand;
            fichaRoja0.Image = Properties.Resources.FichaRoja;
            fichaRoja0.Location = new Point(285, 164);
            fichaRoja0.Name = "fichaRoja0";
            fichaRoja0.Size = new Size(40, 40);
            fichaRoja0.TabIndex = 1;
            fichaRoja0.TabStop = false;
            fichaRoja0.Click += fichaRoja0_Click_1;
            // 
            // fichaRoja1
            // 
            fichaRoja1.BackColor = Color.Transparent;
            fichaRoja1.Cursor = Cursors.Hand;
            fichaRoja1.Image = Properties.Resources.FichaRoja;
            fichaRoja1.Location = new Point(374, 164);
            fichaRoja1.Name = "fichaRoja1";
            fichaRoja1.Size = new Size(40, 40);
            fichaRoja1.TabIndex = 2;
            fichaRoja1.TabStop = false;
            fichaRoja1.Click += fichaRoja1_Click;
            // 
            // fichaRoja2
            // 
            fichaRoja2.BackColor = Color.Transparent;
            fichaRoja2.Cursor = Cursors.Hand;
            fichaRoja2.Image = Properties.Resources.FichaRoja;
            fichaRoja2.Location = new Point(374, 75);
            fichaRoja2.Name = "fichaRoja2";
            fichaRoja2.Size = new Size(40, 40);
            fichaRoja2.TabIndex = 3;
            fichaRoja2.TabStop = false;
            fichaRoja2.Click += fichaRoja2_Click;
            // 
            // fichaRoja3
            // 
            fichaRoja3.BackColor = Color.Transparent;
            fichaRoja3.Cursor = Cursors.Hand;
            fichaRoja3.Image = Properties.Resources.FichaRoja;
            fichaRoja3.Location = new Point(290, 81);
            fichaRoja3.Name = "fichaRoja3";
            fichaRoja3.Size = new Size(40, 40);
            fichaRoja3.TabIndex = 4;
            fichaRoja3.TabStop = false;
            fichaRoja3.Click += fichaRoja3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Dado1;
            pictureBox2.Location = new Point(132, 90);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 68);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // FormularioPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1077, 662);
            Controls.Add(pictureBox2);
            Controls.Add(fichaRoja3);
            Controls.Add(fichaRoja2);
            Controls.Add(fichaRoja1);
            Controls.Add(fichaRoja0);
            Controls.Add(imagenTablero);
            ForeColor = SystemColors.Control;
            MaximumSize = new Size(1093, 701);
            MinimumSize = new Size(1093, 701);
            Name = "FormularioPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LUDO.NET";
            Load += LoadFormulario;
            ((System.ComponentModel.ISupportInitialize)imagenTablero).EndInit();
            ((System.ComponentModel.ISupportInitialize)fichaRoja0).EndInit();
            ((System.ComponentModel.ISupportInitialize)fichaRoja1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fichaRoja2).EndInit();
            ((System.ComponentModel.ISupportInitialize)fichaRoja3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timerSeleccionFicha;
        private PictureBox imagenTablero;
        public PictureBox fichaRoja0;
        public PictureBox fichaRoja1;
        public PictureBox fichaRoja2;
        public PictureBox fichaRoja3;
        private PictureBox pictureBox2;
    }
}