using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_Programacion___Ludo
{

    public class Jugador
    {
        private Ficha[] fichas;
        private Colores color;
        private Point primeraPosicion;

        public Jugador( Point primeraPosicion,Colores color, Ficha[] fichas)
        {
            this.Color = color;
            this.PrimeraPosicion= primeraPosicion;
            this.fichas = fichas;

            foreach (var ficha in fichas)
            {
                ficha.Color = Color;
            }

        }
        public Ficha[] Fichas { get => fichas; }
        public Point PrimeraPosicion { get => primeraPosicion; set => primeraPosicion = value; }
        public Colores Color { get => color; set => color = value; }
    }
}
