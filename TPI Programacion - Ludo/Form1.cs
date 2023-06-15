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

        private void fichaRoja_Click_1(object sender, EventArgs e)
        {
            tablero.moverFicha(0);
        }

        private void InCargaFormulario(object sender, EventArgs e)
        {
            tablero.IncializarValores();
        }

        private void fichaRoja2_Click(object sender, EventArgs e)
        {
            tablero.moverFicha(1);
        }

        private void fichaRoja3_Click(object sender, EventArgs e)
        {
            tablero.moverFicha(2);
        }

        private void fichaRoja4_Click(object sender, EventArgs e)
        {
            tablero.moverFicha(3);
        }
    }
}