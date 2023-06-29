using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private RecorridoFinal recorridoFinal;
        private bool primeraPosicionOcupada;
        private int finalizados;

        public Jugador( Point primeraPosicion,Point posicionFinal,Colores color, Ficha[] fichas)
        {
            this.Color = color;
            this.PrimeraPosicion= primeraPosicion;
            this.fichas = fichas;

            foreach (var ficha in fichas)
            {
                ficha.Color = Color;
                ficha.PosicionFinal = posicionFinal;
            }
            this.RecorridoFinal = new RecorridoFinal(color);
            this.primeraPosicionOcupada = false;
            this.Finalizados = 0;
        }
        public Ficha[] Fichas { get => fichas; }
        public Point PrimeraPosicion { get => primeraPosicion; set => primeraPosicion = value; }
        public Colores Color { get => color; set => color = value; }
        public int Finalizados { get => finalizados; set => finalizados = value; }
        public bool PrimeraPosicionOcupada { get => primeraPosicionOcupada; set => primeraPosicionOcupada = value; }
        internal RecorridoFinal RecorridoFinal { get => recorridoFinal; set => recorridoFinal = value; }
    }
}
