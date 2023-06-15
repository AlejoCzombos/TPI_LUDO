using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_Programacion___Ludo
{
    public class Ficha
    {
        private PictureBox imagen;
        private Posicion posicionActual;

        public Ficha(PictureBox imagen, Posicion posicionActual)
        {
            this.imagen = imagen;
            this.posicionActual = posicionActual;
        }

        public PictureBox Imagen { get => imagen; set => imagen = value; }
        public Posicion PosicionActual { get => posicionActual; set => posicionActual = value; }
    }
}
