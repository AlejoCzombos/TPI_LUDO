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

    internal class Jugador
    {
        private Recorrido recorrido;
        //private RecorridoFinal recorridoFinal = new RecorridoFinal();
        private Ficha[] fichas;
        private Colores color;
        private Posicion primeraPosicion;
        public Ficha[] Fichas { get => fichas; }

        public Jugador( Colores color, Posicion primeraPosicion, Ficha[] fichas)
        {
            this.color = color;
            this.primeraPosicion= primeraPosicion;
            recorrido = new Recorrido();
            this.fichas = fichas;
        }

        public void moverFicha(int indiceFicha, int pasos)
        {
            for(int i = 0; i < pasos; i++)
            {
                recorrido.ProximaPosicion( fichas[indiceFicha].PosicionActual );
            }
        }
    }
}
