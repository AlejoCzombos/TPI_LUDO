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
    public partial class FormularioGanador : Form
    {

        private bool reiniciar;
        private bool volverMenu;

        //Ubica las rutas de las imagenes a utilizar en el PictureBox en base al indice
        private String[] rutasImagenes = {
            Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Imagenes\\FichaRojaGanadora.png"),
            Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Imagenes\\FichaVerdeGanadora.png"),
            Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Imagenes\\FichaAmarillaGanadora.png"),
            Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Imagenes\\FichaCelesteGanadora.png"),
        };

        public bool Reiniciar { get => reiniciar; set => reiniciar = value; }
        public bool VolverMenu { get => volverMenu; set => volverMenu = value; }

        public FormularioGanador(int indice)
        {
            InitializeComponent();
            this.pictureBoxGanador.ImageLocation = rutasImagenes[indice];
            this.Reiniciar = false;
            this.VolverMenu = false;
        }

        private void buttonReiniciar_Click(object sender, EventArgs e)
        {
            Reiniciar = true;
            this.Close();
        }

        private void buttonVolverMenu_Click(object sender, EventArgs e)
        {
            VolverMenu = true;
            this.Close();
        }
    }
}
