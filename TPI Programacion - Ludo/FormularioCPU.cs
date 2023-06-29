using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPI_Programacion___Ludo
{
    public partial class FormularioCPU : Form
    {
        private Tablero2 tablero;

        public FormularioCPU()
        {
            InitializeComponent();
            TransparentarFichas();
        }

        private void FormularioCPU_Load(object sender, EventArgs e)
        {
            tablero = new Tablero2();
        }

        private void fichaRoja3_Click(object sender, EventArgs e)
        {
            tablero.SeleccionarFicha(3);
        }

        private void fichaRoja2_Click(object sender, EventArgs e)
        {
            tablero.SeleccionarFicha(2);
        }

        private void fichaRoja0_Click(object sender, EventArgs e)
        {
            tablero.SeleccionarFicha(0);
        }

        private void fichaRoja1_Click(object sender, EventArgs e)
        {
            tablero.SeleccionarFicha(1);
        }

        private void fichaAmarilla3_Click(object sender, EventArgs e)
        {
            tablero.SeleccionarFicha(3);
        }

        private void fichaAmarilla2_Click(object sender, EventArgs e)
        {
            tablero.SeleccionarFicha(2);
        }

        private void fichaAmarilla0_Click(object sender, EventArgs e)
        {
            tablero.SeleccionarFicha(0);
        }

        private void fichaAmarilla1_Click(object sender, EventArgs e)
        {
            tablero.SeleccionarFicha(1);
        }

        private void dadoJRojo_Click(object sender, EventArgs e)
        {
            tablero.TirarDado(tablero.DadoRojo);
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
            imagenTablero.Controls.Add(fichaAmarilla0);
            imagenTablero.Controls.Add(fichaAmarilla1);
            imagenTablero.Controls.Add(fichaAmarilla2);
            imagenTablero.Controls.Add(fichaAmarilla3);

            imagenTablero.Controls.Add(dadoJAmarillo);
            imagenTablero.Controls.Add(dadoJRojo);
        }
    }
}
