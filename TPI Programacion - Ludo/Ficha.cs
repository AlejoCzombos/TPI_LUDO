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
        private Posicion posicionInicial;
        private bool estaEnCasa = true;
        private bool enJuego = true;

        public Ficha(PictureBox imagen, Posicion posicionInicial, Posicion posicionActual)
        {
            this.imagen = imagen;
            this.posicionInicial = posicionInicial;
            this.posicionActual = posicionActual;
        }

        public PictureBox Imagen { get => imagen; set => imagen = value; }
        public Posicion PosicionActual { get => posicionActual; set => posicionActual = value; }
        public bool EnJuego { get => enJuego; set => enJuego = value; }
        public bool EstaEnCasa { get => estaEnCasa; set => estaEnCasa = value; }
        public Posicion PosicionInicial { get => posicionInicial; set => posicionInicial = value; }
    }
}
