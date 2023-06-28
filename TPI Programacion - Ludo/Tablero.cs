using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_Programacion___Ludo
{
    public class Tablero
    {
        private FormularioPrincipal formulario;
        private Dado dado;
        private Recorrido recorrido;
        private Jugador jugadorVerde;
        private Jugador jugadorAmarillo;
        private Jugador jugadorAzul;
        private Jugador jugadorRojo;
        private List<Ficha> fichas;
        bool avanza = true;
        public Tablero()
        {
            formulario = Program.formulario;

            JugadorRojo = new Jugador(new Point(268, 266), Colores.Rojo,
                new Ficha[] {
                    new Ficha(formulario.fichaRoja0, Colores.Rojo, new Point(285, 164)),
                    new Ficha(formulario.fichaRoja1, Colores.Rojo, new Point(374, 164)),
                    new Ficha(formulario.fichaRoja2, Colores.Rojo, new Point(374, 75)),
                    new Ficha(formulario.fichaRoja3, Colores.Rojo, new Point(285, 75))
                });
            //dado = new Dado();
            recorrido = new Recorrido();
            fichas = new List<Ficha>();

            fichas.Add(JugadorRojo.Fichas[0]);
            fichas.Add(JugadorRojo.Fichas[1]);
            fichas.Add(JugadorRojo.Fichas[2]);
            fichas.Add(JugadorRojo.Fichas[3]);
        }

        internal Jugador JugadorRojo { get => jugadorRojo; set => jugadorRojo = value; }
        internal Jugador JugadorAzul { get => jugadorAzul; set => jugadorAzul = value; }
        internal Jugador JugadorAmarillo { get => jugadorAmarillo; set => jugadorAmarillo = value; }
        internal Jugador JugadorVerde { get => jugadorVerde; set => jugadorVerde = value; }

        public void MoverFicha(Jugador jugador, int indiceFicha)
        {
            Ficha ficha = jugador.Fichas[indiceFicha];

            avanza = true;


            if (ficha.EstaEnCasa)
            {
                ficha.PosicionFutura = jugador.PrimeraPosicion;
                ficha.EstaEnCasa = false;
            }
            else
            {
                ficha.PosicionFutura = recorrido.ProximaPosicion(ficha.PosicionActual);
            }

            foreach (Ficha fi in fichas)
            {
                //Comprobacion de comer fichas
                if (ficha == fi)
                {
                    continue;
                }
                //Comprobar si en la posicion futura hay una ficha del mismo color
                else if (ficha.PosicionFutura == fi.PosicionActual && ficha.Color == fi.Color)
                {
                    avanza = false;
                    break;
                }
                //Compueba si en la posicion futura hay una ficha del otro color
                else if (ficha.PosicionFutura == fi.PosicionActual && ficha.Color != fi.Color)
                {
                    avanza = true;
                    ficha.Imagen.Location = ficha.PosicionCasa;
                    ficha.EstaEnCasa = true;
                    break;
                }

                //Si la posicion futura esta libre se avanza
                if (avanza)
                {
                    ficha.PosicionActual = ficha.PosicionFutura;

                    ficha.Imagen.Location = ficha.PosicionActual;
                }
            }
        }

    }
}
