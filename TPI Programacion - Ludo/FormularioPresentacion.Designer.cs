namespace TPI_Programacion___Ludo
{
    partial class FormularioPresentacion
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
            panelBotones = new Panel();
            labelSeleccion = new Label();
            buttonEmpezar = new Button();
            groupBoxCantidadJ = new GroupBox();
            radioButton4J = new RadioButton();
            radioButtonJvsJ = new RadioButton();
            radioButton1vsPC = new RadioButton();
            panelImagen = new Panel();
            pictureBox1 = new PictureBox();
            panelBotones.SuspendLayout();
            groupBoxCantidadJ.SuspendLayout();
            panelImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelBotones
            // 
            panelBotones.Controls.Add(labelSeleccion);
            panelBotones.Controls.Add(buttonEmpezar);
            panelBotones.Controls.Add(groupBoxCantidadJ);
            panelBotones.Location = new Point(0, 657);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(656, 287);
            panelBotones.TabIndex = 0;
            // 
            // labelSeleccion
            // 
            labelSeleccion.AutoSize = true;
            labelSeleccion.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelSeleccion.Location = new Point(142, 16);
            labelSeleccion.Name = "labelSeleccion";
            labelSeleccion.Size = new Size(371, 65);
            labelSeleccion.TabIndex = 4;
            labelSeleccion.Text = "Elija una opción:";
            // 
            // buttonEmpezar
            // 
            buttonEmpezar.Location = new Point(246, 188);
            buttonEmpezar.Name = "buttonEmpezar";
            buttonEmpezar.Size = new Size(204, 52);
            buttonEmpezar.TabIndex = 5;
            buttonEmpezar.Text = "Empezar partida";
            buttonEmpezar.UseVisualStyleBackColor = true;
            buttonEmpezar.Click += buttonEmpezar_Click;
            // 
            // groupBoxCantidadJ
            // 
            groupBoxCantidadJ.Controls.Add(radioButton4J);
            groupBoxCantidadJ.Controls.Add(radioButtonJvsJ);
            groupBoxCantidadJ.Controls.Add(radioButton1vsPC);
            groupBoxCantidadJ.FlatStyle = FlatStyle.Flat;
            groupBoxCantidadJ.Location = new Point(30, 84);
            groupBoxCantidadJ.Name = "groupBoxCantidadJ";
            groupBoxCantidadJ.Size = new Size(623, 78);
            groupBoxCantidadJ.TabIndex = 3;
            groupBoxCantidadJ.TabStop = false;
            // 
            // radioButton4J
            // 
            radioButton4J.AutoSize = true;
            radioButton4J.ForeColor = SystemColors.ActiveCaptionText;
            radioButton4J.Location = new Point(463, 30);
            radioButton4J.Name = "radioButton4J";
            radioButton4J.Size = new Size(133, 29);
            radioButton4J.TabIndex = 2;
            radioButton4J.TabStop = true;
            radioButton4J.Text = "4 Jugadores";
            radioButton4J.UseVisualStyleBackColor = true;
            // 
            // radioButtonJvsJ
            // 
            radioButtonJvsJ.AutoSize = true;
            radioButtonJvsJ.Location = new Point(230, 30);
            radioButtonJvsJ.Name = "radioButtonJvsJ";
            radioButtonJvsJ.Size = new Size(196, 29);
            radioButtonJvsJ.TabIndex = 1;
            radioButtonJvsJ.TabStop = true;
            radioButtonJvsJ.Text = "Jugador VS Jugador";
            radioButtonJvsJ.UseVisualStyleBackColor = true;
            // 
            // radioButton1vsPC
            // 
            radioButton1vsPC.AutoSize = true;
            radioButton1vsPC.Location = new Point(38, 30);
            radioButton1vsPC.Name = "radioButton1vsPC";
            radioButton1vsPC.Size = new Size(153, 29);
            radioButton1vsPC.TabIndex = 0;
            radioButton1vsPC.TabStop = true;
            radioButton1vsPC.Text = "Jugador VS PC";
            radioButton1vsPC.UseVisualStyleBackColor = true;
            // 
            // panelImagen
            // 
            panelImagen.Controls.Add(pictureBox1);
            panelImagen.Location = new Point(0, 1);
            panelImagen.Name = "panelImagen";
            panelImagen.Size = new Size(656, 650);
            panelImagen.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.TableroAnimado;
            pictureBox1.Location = new Point(12, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(633, 636);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormularioPresentacion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 944);
            Controls.Add(panelImagen);
            Controls.Add(panelBotones);
            Name = "FormularioPresentacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ludo.NET";
            panelBotones.ResumeLayout(false);
            panelBotones.PerformLayout();
            groupBoxCantidadJ.ResumeLayout(false);
            groupBoxCantidadJ.PerformLayout();
            panelImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBotones;
        private Panel panelImagen;
        private PictureBox pictureBox1;
        private Label labelSeleccion;
        private Button buttonEmpezar;
        private GroupBox groupBoxCantidadJ;
        private RadioButton radioButton4J;
        private RadioButton radioButtonJvsJ;
        private RadioButton radioButton1vsPC;
    }
}