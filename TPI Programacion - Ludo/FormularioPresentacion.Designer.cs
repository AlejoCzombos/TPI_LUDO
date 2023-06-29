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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPresentacion));
            panelBotones = new Panel();
            labelSeleccion = new Label();
            buttonEmpezar = new Button();
            groupBoxCantidadJ = new GroupBox();
            radioButton4J = new RadioButton();
            radioButton1vsPC = new RadioButton();
            panelImagen = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            panelBotones.SuspendLayout();
            groupBoxCantidadJ.SuspendLayout();
            panelImagen.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelBotones
            // 
            panelBotones.Anchor = AnchorStyles.None;
            panelBotones.Controls.Add(labelSeleccion);
            panelBotones.Controls.Add(buttonEmpezar);
            panelBotones.Controls.Add(groupBoxCantidadJ);
            panelBotones.Location = new Point(2, 651);
            panelBotones.Margin = new Padding(2);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(635, 184);
            panelBotones.TabIndex = 0;
            // 
            // labelSeleccion
            // 
            labelSeleccion.Anchor = AnchorStyles.None;
            labelSeleccion.AutoSize = true;
            labelSeleccion.Font = new Font("Pokemon Classic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelSeleccion.Location = new Point(100, -13);
            labelSeleccion.Margin = new Padding(2, 0, 2, 0);
            labelSeleccion.Name = "labelSeleccion";
            labelSeleccion.Size = new Size(430, 52);
            labelSeleccion.TabIndex = 4;
            labelSeleccion.Text = "Elija una opción:";
            // 
            // buttonEmpezar
            // 
            buttonEmpezar.Anchor = AnchorStyles.None;
            buttonEmpezar.BackColor = SystemColors.ButtonFace;
            buttonEmpezar.Font = new Font("Pokemon Classic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEmpezar.Location = new Point(186, 114);
            buttonEmpezar.Margin = new Padding(2);
            buttonEmpezar.Name = "buttonEmpezar";
            buttonEmpezar.Size = new Size(247, 59);
            buttonEmpezar.TabIndex = 5;
            buttonEmpezar.Text = "Empezar partida";
            buttonEmpezar.UseVisualStyleBackColor = false;
            buttonEmpezar.Click += buttonEmpezar_Click;
            // 
            // groupBoxCantidadJ
            // 
            groupBoxCantidadJ.Anchor = AnchorStyles.None;
            groupBoxCantidadJ.Controls.Add(radioButton4J);
            groupBoxCantidadJ.Controls.Add(radioButton1vsPC);
            groupBoxCantidadJ.FlatStyle = FlatStyle.Flat;
            groupBoxCantidadJ.Location = new Point(3, 41);
            groupBoxCantidadJ.Margin = new Padding(2);
            groupBoxCantidadJ.Name = "groupBoxCantidadJ";
            groupBoxCantidadJ.Padding = new Padding(2);
            groupBoxCantidadJ.Size = new Size(630, 69);
            groupBoxCantidadJ.TabIndex = 3;
            groupBoxCantidadJ.TabStop = false;
            // 
            // radioButton4J
            // 
            radioButton4J.Anchor = AnchorStyles.None;
            radioButton4J.AutoSize = true;
            radioButton4J.Font = new Font("Pokemon Classic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton4J.ForeColor = SystemColors.ActiveCaptionText;
            radioButton4J.Location = new Point(326, 23);
            radioButton4J.Margin = new Padding(2);
            radioButton4J.Name = "radioButton4J";
            radioButton4J.Size = new Size(155, 24);
            radioButton4J.TabIndex = 2;
            radioButton4J.TabStop = true;
            radioButton4J.Text = "4 Jugadores";
            radioButton4J.UseVisualStyleBackColor = true;
            // 
            // radioButton1vsPC
            // 
            radioButton1vsPC.Anchor = AnchorStyles.None;
            radioButton1vsPC.AutoSize = true;
            radioButton1vsPC.Font = new Font("Pokemon Classic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1vsPC.Location = new Point(98, 23);
            radioButton1vsPC.Margin = new Padding(2);
            radioButton1vsPC.Name = "radioButton1vsPC";
            radioButton1vsPC.Size = new Size(178, 24);
            radioButton1vsPC.TabIndex = 0;
            radioButton1vsPC.TabStop = true;
            radioButton1vsPC.Text = "Jugador VS PC";
            radioButton1vsPC.UseVisualStyleBackColor = true;
            // 
            // panelImagen
            // 
            panelImagen.Anchor = AnchorStyles.None;
            panelImagen.Controls.Add(tableLayoutPanel1);
            panelImagen.Location = new Point(0, 1);
            panelImagen.Margin = new Padding(2);
            panelImagen.Name = "panelImagen";
            panelImagen.Size = new Size(639, 837);
            panelImagen.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(panelBotones, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 77.58831F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.4116936F));
            tableLayoutPanel1.Size = new Size(639, 837);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.TableroAnimado;
            pictureBox1.Location = new Point(2, 2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(635, 645);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormularioPresentacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(637, 839);
            Controls.Add(panelImagen);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "FormularioPresentacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ludo.NET";
            panelBotones.ResumeLayout(false);
            panelBotones.PerformLayout();
            groupBoxCantidadJ.ResumeLayout(false);
            groupBoxCantidadJ.PerformLayout();
            panelImagen.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
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
        private RadioButton radioButton1vsPC;
        private TableLayoutPanel tableLayoutPanel1;
    }
}