using System.Windows.Forms;

namespace TPI_Programacion___Ludo
{
    public partial class Formulario : Form
    {
        private Tablero tablero;

        public Formulario(Tablero tablero)
        {
            this.tablero = tablero; 
            InitializeComponent();
        }


        private void InCargaFormulario(object sender, EventArgs e)
        {
            tablero.IncializarValores();
        }

        private void fichaAzul0_Click(object sender, EventArgs e)
        {

        }

        private void fichaAzul1_Click(object sender, EventArgs e)
        {

        }

        private void fichaAzul2_Click(object sender, EventArgs e)
        {

        }

        private void fichaAzul3_Click(object sender, EventArgs e)
        {

        }

        private void fichaRoja0_Click(object sender, EventArgs e)
        {

        }

        private void fichaRoja1_Click(object sender, EventArgs e)
        {

        }

        private void fichaRoja2_Click(object sender, EventArgs e)
        {

        }

        private void fichaRoja3_Click(object sender, EventArgs e)
        {

        }

        private void fichaVerde0_Click(object sender, EventArgs e)
        {

        }

        private void fichaVerde1_Click(object sender, EventArgs e)
        {

        }

        private void fichaVerde2_Click(object sender, EventArgs e)
        {

        }

        private void fichaVerde3_Click(object sender, EventArgs e)
        {

        }

        private void fichaAmarilla0_Click(object sender, EventArgs e)
        {

        }

        private void fichaAmarilla1_Click(object sender, EventArgs e)
        {

        }

        private void fichaAmarilla2_Click(object sender, EventArgs e)
        {

        }

        private void fichaAmarilla3_Click(object sender, EventArgs e)
        {

        }
    }
}