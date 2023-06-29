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

        //Ubica las rutas de las imagenes a utilizar en el PictureBox en base al indice
        private String[] rutasImagenes = { 
            Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Imagenes\\FichaRojaGanadora.png"),
            Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Imagenes\\FichaVerdeGanadora.png"),
            Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Imagenes\\FichaAmarillaGanadora.png"),
            Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Imagenes\\FichaCelesteGanadora.png"),
        };

        public FormularioGanador(int indice)
        {
            InitializeComponent();
            this.pictureBoxGanador.ImageLocation = rutasImagenes[indice];
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
