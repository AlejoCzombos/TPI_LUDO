using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_Programacion___Ludo
{
    public class Tablero
    {
        private Formulario form;
        private Dado dado;
        private Jugador jugadorVerde;
        private Jugador jugadorAmarillo;
        private Jugador jugadorAzul;
        private Jugador jugadorRojo;
        public Formulario Formularioo
        {
            get { return form; }
            set { form = value; }
        }
        public Tablero()
        {
        }
        public void IncializarValores()
        {
            jugadorVerde = new Jugador(
                Colores.Verde,
                new Posicion(1, 6),
                new Ficha[] {
                    new Ficha(Formularioo.fichaVerde0, new Posicion(2,2), new Posicion(1,6)),
                    new Ficha(Formularioo.fichaVerde1, new Posicion(3,2), new Posicion(1,6)),
                    new Ficha(Formularioo.fichaVerde2, new Posicion(2,3), new Posicion(1,6)),
                    new Ficha(Formularioo.fichaVerde3, new Posicion(3,3), new Posicion(1,6))
                });
            jugadorAmarillo = new Jugador(
                Colores.Verde,
                new Posicion(8, 1),
                new Ficha[] {
                    new Ficha(Formularioo.fichaAmarilla0, new Posicion(11,2), new Posicion(8,1)),
                    new Ficha(Formularioo.fichaAmarilla1, new Posicion(12,2), new Posicion(8,1)),
                    new Ficha(Formularioo.fichaAmarilla2, new Posicion(11,3), new Posicion(8,1)),
                    new Ficha(Formularioo.fichaAmarilla3, new Posicion(12,3), new Posicion(8,1))
                });
            jugadorAzul = new Jugador(
                Colores.Verde,
                new Posicion(13, 8),
                new Ficha[] {
                    new Ficha(Formularioo.fichaAzul0, new Posicion(11,11), new Posicion(13,8)),
                    new Ficha(Formularioo.fichaAzul1, new Posicion(12,11), new Posicion(13,8)),
                    new Ficha(Formularioo.fichaAzul2, new Posicion(12,12), new Posicion(13,8)),
                    new Ficha(Formularioo.fichaAzul3, new Posicion(11,12), new Posicion(13,8))
                });
            jugadorRojo = new Jugador(
                Colores.Rojo,
                new Posicion(6, 13),
                new Ficha[] {
                    new Ficha(Formularioo.fichaRoja0, new Posicion(2,11), new Posicion(6,13)),
                    new Ficha(Formularioo.fichaRoja1, new Posicion(3,11), new Posicion(6,13)),
                    new Ficha(Formularioo.fichaRoja2, new Posicion(2,12), new Posicion(6,13)),
                    new Ficha(Formularioo.fichaRoja3, new Posicion(3,12), new Posicion(6,13))
                });


            dado = new Dado(Formularioo.imagenDado);

        }
        public void moverFicha(int i)
        {
            jugadorRojo.moverFicha(i, 5);
            Formularioo.panelTablero.SetCellPosition(jugadorRojo.Fichas[i].Imagen, new TableLayoutPanelCellPosition(jugadorRojo.Fichas[i].PosicionActual.Columna, jugadorRojo.Fichas[i].PosicionActual.Fila));
        }

        public void TirarDado()
        {
            dado.tirarDado();
        }
    }
}
