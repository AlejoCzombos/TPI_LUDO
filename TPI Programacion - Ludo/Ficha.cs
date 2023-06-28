using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_Programacion___Ludo
{
    public enum Colores
    {
        Verde,
        Amarillo,
        Azul,
        Rojo
    }
    public class Ficha
    {
        private PictureBox imagen;
        private Colores color;
        private Point posicionActual;
        private Point posicionCasa;
        private Point posicionFutura;
        private bool estaEnCasa = true;
        private bool enJuego = true;

        public Ficha(PictureBox imagen, Point posicionCasa)
        {
            this.imagen = imagen;
            this.posicionCasa = posicionCasa;
            this.posicionActual = posicionCasa;
        }

        public PictureBox Imagen { get => imagen; set => imagen = value; }
        public Point PosicionActual { get => posicionActual; set => posicionActual = value; }
        public bool EnJuego { get => enJuego; set => enJuego = value; }
        public bool EstaEnCasa { get => estaEnCasa; set => estaEnCasa = value; }
        public Point PosicionCasa { get => posicionCasa; set => posicionCasa = value; }
        public Colores Color { get => color; set => color = value; }
        public Point PosicionFutura { get => posicionFutura; set => posicionFutura = value; }
    }
}
