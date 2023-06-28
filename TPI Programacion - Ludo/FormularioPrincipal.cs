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
            TransparentarFichas();
        }
        private void LoadFormulario(object sender, EventArgs e)
        {
            tablero = new Tablero();
        }

        //Eventos para Seleccionar Fichas

        private void fichaRoja0_Click_1(object sender, EventArgs e)
        {
            tablero.SeleccionarFicha(0);
        }

        private void fichaRoja1_Click(object sender, EventArgs e)
        {
            tablero.SeleccionarFicha(1);
        }
        private void fichaRoja2_Click(object sender, EventArgs e)
        {
            tablero.SeleccionarFicha(2);
        }

        private void fichaRoja3_Click(object sender, EventArgs e)
        {
            tablero.SeleccionarFicha(3);
        }
        private void fichaVerde0_Click(object sender, EventArgs e)
        {
            tablero.SeleccionarFicha(0);
        }

        private void fichaVerde1_Click(object sender, EventArgs e)
        {
            tablero.SeleccionarFicha(1);
        }
        private void fichaVerde2_Click(object sender, EventArgs e)
        {
            tablero.SeleccionarFicha(2);
        }

        private void fichaVerde3_Click(object sender, EventArgs e)
        {
            tablero.SeleccionarFicha(3);
        }
        private void fichaAzul0_Click(object sender, EventArgs e)
        {
            tablero.SeleccionarFicha(0);
        }

        private void fichaAzul1_Click(object sender, EventArgs e)
        {
            tablero.SeleccionarFicha(1);
        }
        private void fichaAzul2_Click(object sender, EventArgs e)
        {
            tablero.SeleccionarFicha(2);
        }

        private void fichaAzul3_Click(object sender, EventArgs e)
        {
            tablero.SeleccionarFicha(3);
        }

        private void fichaAmarilla0_Click(object sender, EventArgs e)
        {
            tablero.SeleccionarFicha(0);
        }

        private void fichaAmarilla1_Click(object sender, EventArgs e)
        {
            tablero.SeleccionarFicha(1);
        }
        private void fichaAmarilla2_Click(object sender, EventArgs e)
        {
            tablero.SeleccionarFicha(2);
        }

        private void fichaAmarilla3_Click(object sender, EventArgs e)
        {
            tablero.SeleccionarFicha(3);
        }


        //Eventos para cambiar el dado al hacer click

        private void dadoJRojo_Click(object sender, EventArgs e)
        {
            tablero.TirarDado(tablero.DadoRojo);
        }

        private void dadoJVerde_Click(object sender, EventArgs e)
        {
            tablero.TirarDado(tablero.DadoVerde);
        }

        private void dadoJAzul_Click(object sender, EventArgs e)
        {
            tablero.TirarDado(tablero.DadoAzul);
        }

        private void dadoJAmarillo_Click(object sender, EventArgs e)
        {
            tablero.TirarDado(tablero.DadoAmarillo);
        }
        private void TransparentarFichas()
        {
            imagenTablero.Controls.Add(fichaRoja0);
            imagenTablero.Controls.Add(fichaRoja1);
            imagenTablero.Controls.Add(fichaRoja2);
            imagenTablero.Controls.Add(fichaRoja3);
            imagenTablero.Controls.Add(fichaVerde0);
            imagenTablero.Controls.Add(fichaVerde1);
            imagenTablero.Controls.Add(fichaVerde2);
            imagenTablero.Controls.Add(fichaVerde3);
            imagenTablero.Controls.Add(fichaAzul0);
            imagenTablero.Controls.Add(fichaAzul1);
            imagenTablero.Controls.Add(fichaAzul2);
            imagenTablero.Controls.Add(fichaAzul3);
            imagenTablero.Controls.Add(fichaAmarilla0);
            imagenTablero.Controls.Add(fichaAmarilla1);
            imagenTablero.Controls.Add(fichaAmarilla2);
            imagenTablero.Controls.Add(fichaAmarilla3);

            imagenTablero.Controls.Add(dadoJAmarillo);
            imagenTablero.Controls.Add(dadoJAzul);
            imagenTablero.Controls.Add(dadoJRojo);
            imagenTablero.Controls.Add(dadoJVerde);
        }
    }
}