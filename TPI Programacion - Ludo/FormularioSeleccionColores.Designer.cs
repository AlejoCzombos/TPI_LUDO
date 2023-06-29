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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioSeleccionColores));
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
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Pokemon Classic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 372);
            panel1.TabIndex = 0;
            // 
            // buttonVolverAtras
            // 
            buttonVolverAtras.Anchor = AnchorStyles.None;
            buttonVolverAtras.BackColor = SystemColors.ButtonFace;
            buttonVolverAtras.Location = new Point(24, 290);
            buttonVolverAtras.Margin = new Padding(2);
            buttonVolverAtras.Name = "buttonVolverAtras";
            buttonVolverAtras.Size = new Size(147, 54);
            buttonVolverAtras.TabIndex = 29;
            buttonVolverAtras.Text = "Volver atrás";
            buttonVolverAtras.UseVisualStyleBackColor = false;
            buttonVolverAtras.Click += buttonVolverAtras_Click;
            // 
            // buttonContinuar
            // 
            buttonContinuar.Anchor = AnchorStyles.None;
            buttonContinuar.BackColor = SystemColors.ButtonFace;
            buttonContinuar.Location = new Point(224, 290);
            buttonContinuar.Margin = new Padding(2);
            buttonContinuar.Name = "buttonContinuar";
            buttonContinuar.Size = new Size(147, 54);
            buttonContinuar.TabIndex = 28;
            buttonContinuar.Text = "Continuar";
            buttonContinuar.UseVisualStyleBackColor = false;
            buttonContinuar.Click += buttonContinuar_Click;
            // 
            // labelSeleccion
            // 
            labelSeleccion.Anchor = AnchorStyles.None;
            labelSeleccion.AutoSize = true;
            labelSeleccion.Font = new Font("Pokemon Classic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelSeleccion.Location = new Point(24, 9);
            labelSeleccion.Margin = new Padding(2, 0, 2, 0);
            labelSeleccion.Name = "labelSeleccion";
            labelSeleccion.Size = new Size(339, 34);
            labelSeleccion.TabIndex = 27;
            labelSeleccion.Text = "Selección de color:";
            labelSeleccion.Click += labelSeleccion_Click;
            // 
            // labelRojo
            // 
            labelRojo.Anchor = AnchorStyles.None;
            labelRojo.AutoSize = true;
            labelRojo.Location = new Point(74, 73);
            labelRojo.Margin = new Padding(2, 0, 2, 0);
            labelRojo.Name = "labelRojo";
            labelRojo.Size = new Size(136, 18);
            labelRojo.TabIndex = 26;
            labelRojo.Text = "Jugador Rojo:";
            labelRojo.Click += labelRojo_Click;
            // 
            // labelCeleste
            // 
            labelCeleste.Anchor = AnchorStyles.None;
            labelCeleste.AutoSize = true;
            labelCeleste.Location = new Point(74, 235);
            labelCeleste.Margin = new Padding(2, 0, 2, 0);
            labelCeleste.Name = "labelCeleste";
            labelCeleste.Size = new Size(165, 18);
            labelCeleste.TabIndex = 25;
            labelCeleste.Text = "Jugador Celeste:";
            // 
            // labelAmarillo
            // 
            labelAmarillo.Anchor = AnchorStyles.None;
            labelAmarillo.AutoSize = true;
            labelAmarillo.Location = new Point(74, 182);
            labelAmarillo.Margin = new Padding(2, 0, 2, 0);
            labelAmarillo.Name = "labelAmarillo";
            labelAmarillo.Size = new Size(164, 18);
            labelAmarillo.TabIndex = 24;
            labelAmarillo.Text = "Jugador Amarillo:";
            // 
            // labelVerde
            // 
            labelVerde.Anchor = AnchorStyles.None;
            labelVerde.AutoSize = true;
            labelVerde.Location = new Point(74, 127);
            labelVerde.Margin = new Padding(2, 0, 2, 0);
            labelVerde.Name = "labelVerde";
            labelVerde.Size = new Size(151, 18);
            labelVerde.TabIndex = 23;
            labelVerde.Text = "Jugador Verde:";
            // 
            // textBoxR
            // 
            textBoxR.Anchor = AnchorStyles.None;
            textBoxR.BackColor = SystemColors.ButtonFace;
            textBoxR.Location = new Point(252, 70);
            textBoxR.Margin = new Padding(2);
            textBoxR.Name = "textBoxR";
            textBoxR.Size = new Size(133, 25);
            textBoxR.TabIndex = 22;
            textBoxR.MouseClick += textBox_MouseClick;
            textBoxR.TextChanged += textBoxR_TextChanged;
            textBoxR.MouseLeave += textBox_MouseLeave;
            textBoxR.MouseMove += textBox_MouseMove;
            // 
            // textBoxC
            // 
            textBoxC.Anchor = AnchorStyles.None;
            textBoxC.BackColor = SystemColors.ButtonFace;
            textBoxC.Location = new Point(252, 232);
            textBoxC.Margin = new Padding(2);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(133, 25);
            textBoxC.TabIndex = 21;
            textBoxC.MouseClick += textBox_MouseClick;
            textBoxC.MouseLeave += textBox_MouseLeave;
            textBoxC.MouseMove += textBox_MouseMove;
            // 
            // textBoxA
            // 
            textBoxA.Anchor = AnchorStyles.None;
            textBoxA.BackColor = SystemColors.ButtonFace;
            textBoxA.Location = new Point(252, 179);
            textBoxA.Margin = new Padding(2);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(133, 25);
            textBoxA.TabIndex = 20;
            textBoxA.MouseClick += textBox_MouseClick;
            textBoxA.MouseLeave += textBox_MouseLeave;
            textBoxA.MouseMove += textBox_MouseMove;
            // 
            // textBoxV
            // 
            textBoxV.Anchor = AnchorStyles.None;
            textBoxV.BackColor = SystemColors.ButtonFace;
            textBoxV.Location = new Point(252, 124);
            textBoxV.Margin = new Padding(2);
            textBoxV.Name = "textBoxV";
            textBoxV.Size = new Size(133, 25);
            textBoxV.TabIndex = 19;
            textBoxV.MouseClick += textBox_MouseClick;
            textBoxV.TextChanged += textBoxV_TextChanged;
            textBoxV.MouseLeave += textBox_MouseLeave;
            textBoxV.MouseMove += textBox_MouseMove;
            // 
            // pictureBoxR
            // 
            pictureBoxR.Anchor = AnchorStyles.None;
            pictureBoxR.Image = Properties.Resources.FichaRojaM;
            pictureBoxR.Location = new Point(9, 50);
            pictureBoxR.Margin = new Padding(0);
            pictureBoxR.Name = "pictureBoxR";
            pictureBoxR.Size = new Size(51, 54);
            pictureBoxR.TabIndex = 18;
            pictureBoxR.TabStop = false;
            pictureBoxR.Click += pictureBoxR_Click;
            // 
            // pictureBoxC
            // 
            pictureBoxC.Anchor = AnchorStyles.None;
            pictureBoxC.Image = Properties.Resources.FichaAzulM;
            pictureBoxC.Location = new Point(9, 217);
            pictureBoxC.Margin = new Padding(2);
            pictureBoxC.Name = "pictureBoxC";
            pictureBoxC.Size = new Size(51, 52);
            pictureBoxC.TabIndex = 17;
            pictureBoxC.TabStop = false;
            // 
            // pictureBoxA
            // 
            pictureBoxA.Anchor = AnchorStyles.None;
            pictureBoxA.Image = Properties.Resources.FichaAmarillaM;
            pictureBoxA.Location = new Point(9, 161);
            pictureBoxA.Margin = new Padding(2);
            pictureBoxA.Name = "pictureBoxA";
            pictureBoxA.Size = new Size(51, 52);
            pictureBoxA.TabIndex = 16;
            pictureBoxA.TabStop = false;
            // 
            // pictureBoxV
            // 
            pictureBoxV.Anchor = AnchorStyles.None;
            pictureBoxV.Image = Properties.Resources.FichaVerdeM;
            pictureBoxV.Location = new Point(9, 106);
            pictureBoxV.Margin = new Padding(2);
            pictureBoxV.Name = "pictureBoxV";
            pictureBoxV.Size = new Size(51, 52);
            pictureBoxV.TabIndex = 15;
            pictureBoxV.TabStop = false;
            // 
            // FormularioSeleccionColores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(396, 372);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
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