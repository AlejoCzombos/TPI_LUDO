using Microsoft.VisualBasic.Logging;
using System.Windows.Forms;

namespace TPI_Programacion___Ludo
{
    public partial class FormularioPrincipal : Form
    {
        private Tablero tablero;

        public FormularioPrincipal()
        {
            InitializeComponent();

            imagenTablero.Controls.Add(fichaRoja0);
            imagenTablero.Controls.Add(fichaRoja1);
            imagenTablero.Controls.Add(fichaRoja2);
            imagenTablero.Controls.Add(fichaRoja3);
            fichaRoja0.BackColor = Color.Transparent;
            fichaRoja1.BackColor = Color.Transparent;
            fichaRoja2.BackColor = Color.Transparent;
            fichaRoja3.BackColor = Color.Transparent;
        }


        private void fichaRoja0_Click_1(object sender, EventArgs e)
        {
            tablero.MoverFicha(tablero.JugadorRojo, 0);
        }

        private void fichaRoja1_Click(object sender, EventArgs e)
        {
            tablero.MoverFicha(tablero.JugadorRojo, 1);
        }
        private void fichaRoja2_Click(object sender, EventArgs e)
        {
            tablero.MoverFicha(tablero.JugadorRojo, 2);
        }

        private void fichaRoja3_Click(object sender, EventArgs e)
        {
            tablero.MoverFicha(tablero.JugadorRojo, 3);
        }
        private void imagenTablero_Click(object sender, EventArgs e)
        {
        }



        private void LoadFormulario(object sender, EventArgs e)
        {
            tablero = new Tablero();

        }
    }
}