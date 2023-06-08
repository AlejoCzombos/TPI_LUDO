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
            tablero.moverFicha();
        }
    }
}