namespace TPI_Programacion___Ludo
{
    partial class FormularioSeleccionColores
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
            panel1 = new Panel();
            buttonVolverAtras = new Button();
            buttonContinuar = new Button();
            labelSeleccion = new Label();
            labelRojo = new Label();
            labelCeleste = new Label();
            labelAmarillo = new Label();
            labelVerde = new Label();
            textBoxR = new TextBox();
            textBoxC = new TextBox();
            textBoxA = new TextBox();
            textBoxV = new TextBox();
            pictureBoxR = new PictureBox();
            pictureBoxC = new PictureBox();
            pictureBoxA = new PictureBox();
            pictureBoxV = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonVolverAtras);
            panel1.Controls.Add(buttonContinuar);
            panel1.Controls.Add(labelSeleccion);
            panel1.Controls.Add(labelRojo);
            panel1.Controls.Add(labelCeleste);
            panel1.Controls.Add(labelAmarillo);
            panel1.Controls.Add(labelVerde);
            panel1.Controls.Add(textBoxR);
            panel1.Controls.Add(textBoxC);
            panel1.Controls.Add(textBoxA);
            panel1.Controls.Add(textBoxV);
            panel1.Controls.Add(pictureBoxR);
            panel1.Controls.Add(pictureBoxC);
            panel1.Controls.Add(pictureBoxA);
            panel1.Controls.Add(pictureBoxV);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 515);
            panel1.TabIndex = 0;
            // 
            // buttonVolverAtras
            // 
            buttonVolverAtras.Location = new Point(251, 459);
            buttonVolverAtras.Name = "buttonVolverAtras";
            buttonVolverAtras.Size = new Size(142, 39);
            buttonVolverAtras.TabIndex = 29;
            buttonVolverAtras.Text = "Volver atrás";
            buttonVolverAtras.UseVisualStyleBackColor = true;
            buttonVolverAtras.Click += buttonVolverAtras_Click;
            // 
            // buttonContinuar
            // 
            buttonContinuar.Location = new Point(97, 459);
            buttonContinuar.Name = "buttonContinuar";
            buttonContinuar.Size = new Size(130, 39);
            buttonContinuar.TabIndex = 28;
            buttonContinuar.Text = "Continuar";
            buttonContinuar.UseVisualStyleBackColor = true;
            buttonContinuar.Click += buttonContinuar_Click;
            // 
            // labelSeleccion
            // 
            labelSeleccion.AutoSize = true;
            labelSeleccion.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            labelSeleccion.Location = new Point(54, 10);
            labelSeleccion.Name = "labelSeleccion";
            labelSeleccion.Size = new Size(388, 60);
            labelSeleccion.TabIndex = 27;
            labelSeleccion.Text = "Selección de color:";
            // 
            // labelRojo
            // 
            labelRojo.AutoSize = true;
            labelRojo.Location = new Point(106, 121);
            labelRojo.Name = "labelRojo";
            labelRojo.Size = new Size(121, 25);
            labelRojo.TabIndex = 26;
            labelRojo.Text = "Jugador Rojo:";
            // 
            // labelCeleste
            // 
            labelCeleste.AutoSize = true;
            labelCeleste.Location = new Point(106, 391);
            labelCeleste.Name = "labelCeleste";
            labelCeleste.Size = new Size(141, 25);
            labelCeleste.TabIndex = 25;
            labelCeleste.Text = "Jugador Celeste:";
            // 
            // labelAmarillo
            // 
            labelAmarillo.AutoSize = true;
            labelAmarillo.Location = new Point(106, 303);
            labelAmarillo.Name = "labelAmarillo";
            labelAmarillo.Size = new Size(151, 25);
            labelAmarillo.TabIndex = 24;
            labelAmarillo.Text = "Jugador Amarillo:";
            // 
            // labelVerde
            // 
            labelVerde.AutoSize = true;
            labelVerde.Location = new Point(106, 212);
            labelVerde.Name = "labelVerde";
            labelVerde.Size = new Size(130, 25);
            labelVerde.TabIndex = 23;
            labelVerde.Text = "Jugador Verde:";
            // 
            // textBoxR
            // 
            textBoxR.Location = new Point(272, 115);
            textBoxR.Name = "textBoxR";
            textBoxR.Size = new Size(188, 31);
            textBoxR.TabIndex = 22;
            textBoxR.MouseClick += textBox_MouseClick;
            textBoxR.MouseLeave += textBox_MouseLeave;
            textBoxR.MouseMove += textBox_MouseMove;
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(272, 385);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(188, 31);
            textBoxC.TabIndex = 21;
            textBoxC.MouseClick += textBox_MouseClick;
            textBoxC.MouseLeave += textBox_MouseLeave;
            textBoxC.MouseMove += textBox_MouseMove;
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(272, 297);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(188, 31);
            textBoxA.TabIndex = 20;
            textBoxA.MouseClick += textBox_MouseClick;
            textBoxA.MouseLeave += textBox_MouseLeave;
            textBoxA.MouseMove += textBox_MouseMove;
            // 
            // textBoxV
            // 
            textBoxV.Location = new Point(272, 212);
            textBoxV.Name = "textBoxV";
            textBoxV.Size = new Size(188, 31);
            textBoxV.TabIndex = 19;
            textBoxV.MouseClick += textBox_MouseClick;
            textBoxV.MouseLeave += textBox_MouseLeave;
            textBoxV.MouseMove += textBox_MouseMove;
            // 
            // pictureBoxR
            // 
            pictureBoxR.Image = Properties.Resources.FichaRojaGrande;
            pictureBoxR.Location = new Point(13, 83);
            pictureBoxR.Name = "pictureBoxR";
            pictureBoxR.Size = new Size(87, 87);
            pictureBoxR.TabIndex = 18;
            pictureBoxR.TabStop = false;
            // 
            // pictureBoxC
            // 
            pictureBoxC.Image = Properties.Resources.FichaCelesteGrande;
            pictureBoxC.Location = new Point(13, 362);
            pictureBoxC.Name = "pictureBoxC";
            pictureBoxC.Size = new Size(87, 87);
            pictureBoxC.TabIndex = 17;
            pictureBoxC.TabStop = false;
            // 
            // pictureBoxA
            // 
            pictureBoxA.Image = Properties.Resources.FichaAmarillaGrande;
            pictureBoxA.Location = new Point(13, 269);
            pictureBoxA.Name = "pictureBoxA";
            pictureBoxA.Size = new Size(87, 87);
            pictureBoxA.TabIndex = 16;
            pictureBoxA.TabStop = false;
            // 
            // pictureBoxV
            // 
            pictureBoxV.Image = Properties.Resources.FichaVerdeGrande;
            pictureBoxV.Location = new Point(13, 176);
            pictureBoxV.Name = "pictureBoxV";
            pictureBoxV.Size = new Size(87, 87);
            pictureBoxV.TabIndex = 15;
            pictureBoxV.TabStop = false;
            // 
            // FormularioSeleccionColores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 539);
            Controls.Add(panel1);
            Name = "FormularioSeleccionColores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ludo.NET";
            FormClosing += FormularioSC_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxR).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxC).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxA).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonVolverAtras;
        private Button buttonContinuar;
        private Label labelSeleccion;
        private Label labelRojo;
        private Label labelCeleste;
        private Label labelAmarillo;
        private Label labelVerde;
        private TextBox textBoxR;
        private TextBox textBoxC;
        private TextBox textBoxA;
        private TextBox textBoxV;
        private PictureBox pictureBoxR;
        private PictureBox pictureBoxC;
        private PictureBox pictureBoxA;
        private PictureBox pictureBoxV;
    }
}