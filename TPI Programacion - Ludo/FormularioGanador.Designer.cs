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
            buttonVolverMenu = new Button();
            buttonReiniciar = new Button();
            pictureBoxGanador = new PictureBox();
            panelImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGanador).BeginInit();
            SuspendLayout();
            // 
            // panelImagen
            // 
            panelImagen.BackColor = SystemColors.ControlDark;
            panelImagen.Controls.Add(buttonVolverMenu);
            panelImagen.Controls.Add(buttonReiniciar);
            panelImagen.Controls.Add(pictureBoxGanador);
            panelImagen.Dock = DockStyle.Fill;
            panelImagen.Location = new Point(0, 0);
            panelImagen.Margin = new Padding(2);
            panelImagen.Name = "panelImagen";
            panelImagen.Size = new Size(441, 402);
            panelImagen.TabIndex = 0;
            // 
            // buttonVolverMenu
            // 
            buttonVolverMenu.Anchor = AnchorStyles.None;
            buttonVolverMenu.Font = new Font("Pokemon Classic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonVolverMenu.Location = new Point(158, 365);
            buttonVolverMenu.Margin = new Padding(2);
            buttonVolverMenu.Name = "buttonVolverMenu";
            buttonVolverMenu.Size = new Size(281, 26);
            buttonVolverMenu.TabIndex = 2;
            buttonVolverMenu.Text = "Volver a menú principal";
            buttonVolverMenu.UseVisualStyleBackColor = true;
            buttonVolverMenu.Click += buttonVolverMenu_Click;
            // 
            // buttonReiniciar
            // 
            buttonReiniciar.Anchor = AnchorStyles.None;
            buttonReiniciar.Font = new Font("Pokemon Classic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReiniciar.Location = new Point(11, 365);
            buttonReiniciar.Margin = new Padding(2);
            buttonReiniciar.Name = "buttonReiniciar";
            buttonReiniciar.Size = new Size(132, 26);
            buttonReiniciar.TabIndex = 1;
            buttonReiniciar.Text = "Reiniciar";
            buttonReiniciar.UseVisualStyleBackColor = true;
            buttonReiniciar.Click += buttonReiniciar_Click;
            // 
            // pictureBoxGanador
            // 
            pictureBoxGanador.Anchor = AnchorStyles.None;
            pictureBoxGanador.Location = new Point(7, 0);
            pictureBoxGanador.Margin = new Padding(2);
            pictureBoxGanador.Name = "pictureBoxGanador";
            pictureBoxGanador.Size = new Size(434, 349);
            pictureBoxGanador.TabIndex = 0;
            pictureBoxGanador.TabStop = false;
            // 
            // FormularioGanador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 402);
            ControlBox = false;
            Controls.Add(panelImagen);
            Margin = new Padding(2);
            Name = "FormularioGanador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "¡Felicidades, finalizaste el recorrido!";
            panelImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxGanador).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelImagen;
        private Button buttonReiniciar;
        private PictureBox pictureBoxGanador;
        private Button buttonVolverMenu;
    }
}