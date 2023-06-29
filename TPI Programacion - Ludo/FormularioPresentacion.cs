using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace TPI_Programacion___Ludo
{
    public partial class FormularioPresentacion : Form
    {
        FormularioSeleccionColores seleccionColores;

        public FormularioPresentacion()
        {
            InitializeComponent();
            seleccionColores = new FormularioSeleccionColores();
            //this.Size = new Size(681, 1000);
            //pictureBox1.Size = new Size(636, 636);
        }

        private void buttonEmpezar_Click(object sender, EventArgs e)
        {
            //Es el string que aparece en el MessageBox para el mensaje de confirmacion
            String descripcion;

            if (radioButton1vsPC.Checked)
            {
                seleccionColores.CantidadJugadores = 1;
                descripcion = "Jugador vs PC";
            }
            else
            {
                seleccionColores.CantidadJugadores = 4;
                descripcion = "4 jugadores";
            }

            DialogResult acepta = MessageBox.Show($"¿Está seguro de la opcion elegida: {descripcion}?", "Confirmación"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (acepta == DialogResult.Yes)
            {
                this.Hide();
                seleccionColores.ShowDialog();

                if (seleccionColores.Cerrado) this.Show();
            }
        }
    }
}
