namespace TPI_Programacion___Ludo
{
    partial class FormularioGanador
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
            panelImagen = new Panel();
            buttonAceptar = new Button();
            pictureBoxGanador = new PictureBox();
            panelImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGanador).BeginInit();
            SuspendLayout();
            // 
            // panelImagen
            // 
            panelImagen.Controls.Add(buttonAceptar);
            panelImagen.Controls.Add(pictureBoxGanador);
            panelImagen.Dock = DockStyle.Fill;
            panelImagen.Location = new Point(0, 0);
            panelImagen.Name = "panelImagen";
            panelImagen.Size = new Size(435, 385);
            panelImagen.TabIndex = 0;
            // 
            // buttonAceptar
            // 
            buttonAceptar.Anchor = AnchorStyles.None;
            buttonAceptar.Location = new Point(119, 321);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(189, 43);
            buttonAceptar.TabIndex = 1;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = true;
            buttonAceptar.Click += buttonAceptar_Click;
            // 
            // pictureBoxGanador
            // 
            pictureBoxGanador.Anchor = AnchorStyles.None;
            pictureBoxGanador.Location = new Point(0, -48);
            pictureBoxGanador.Name = "pictureBoxGanador";
            pictureBoxGanador.Size = new Size(434, 349);
            pictureBoxGanador.TabIndex = 0;
            pictureBoxGanador.TabStop = false;
            // 
            // FormularioGanador
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 385);
            ControlBox = false;
            Controls.Add(panelImagen);
            Name = "FormularioGanador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "¡Felicidades, finalizaste el recorrido!";
            panelImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxGanador).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelImagen;
        private Button buttonAceptar;
        private PictureBox pictureBoxGanador;
    }
}