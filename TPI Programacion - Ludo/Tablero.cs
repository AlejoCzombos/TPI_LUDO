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
        private Jugador jugadorVerde;
        private Jugador jugadorAmarillo;
        private Jugador jugadorAzul;
        private Jugador jugadorRojo;
        public Formulario Formulario
        {
            get { return form; }
            set { form = value; }
        }
        public Tablero()
        {
        }
        public void IncializarValores()
        {
            Ficha[] fichasRojas = new Ficha[] {
                    new Ficha(Formulario.fichaRoja1, new Posicion(2,11), new Posicion(6,13)),
                    new Ficha(Formulario.fichaRoja2, new Posicion(3,11), new Posicion(6,13)),
                    new Ficha(Formulario.fichaRoja3, new Posicion(2,12), new Posicion(6,13)),
                    new Ficha(Formulario.fichaRoja4, new Posicion(3,12), new Posicion(6,13))
                };
            jugadorRojo = new Jugador(
                Colores.Rojo,
                new Posicion(6, 13),
                fichasRojas
                );
        }
        public void moverFicha(int i)
        {
            jugadorRojo.moverFicha(i, 1);
            Formulario.panelTablero.SetCellPosition(jugadorRojo.Fichas[i].Imagen, new TableLayoutPanelCellPosition(jugadorRojo.Fichas[i].PosicionActual.Columna, jugadorRojo.Fichas[i].PosicionActual.Fila));
        }
    }
}
