using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace TPI_Programacion___Ludo
{
    public class Tablero
    {
        private FormularioPrincipal formulario;
        private Recorrido recorrido;

        private Timer timer;

        private Jugador jugadorVerde;
        private Jugador jugadorAmarillo;
        private Jugador jugadorAzul;
        private Jugador jugadorRojo;

        private Dado dadoRojo;
        private Dado dadoVerde;
        private Dado dadoAzul;
        private Dado dadoAmarillo;

        private List<Ficha> fichas;

        int numeroDado = 0;
        int indiceFichaJugador;
        bool avanza, puedeSeleccionarFicha = false;
        public Tablero()
        {
            formulario = Program.formulario;

            JugadorRojo = new Jugador(new Point(268, 266), Colores.Rojo,
                new Ficha[] {
                    new Ficha(formulario.fichaRoja0, Colores.Rojo, new Point(291, 164)),
                    new Ficha(formulario.fichaRoja1, Colores.Rojo, new Point(369, 159)),
                    new Ficha(formulario.fichaRoja2, Colores.Rojo, new Point(369, 81)),
                    new Ficha(formulario.fichaRoja3, Colores.Rojo, new Point(291, 81))
                });

            fichas = new List<Ficha>();
            fichas.Add(JugadorRojo.Fichas[0]);
            fichas.Add(JugadorRojo.Fichas[1]);
            fichas.Add(JugadorRojo.Fichas[2]);
            fichas.Add(JugadorRojo.Fichas[3]);

            recorrido = new Recorrido();
            timer = new Timer();
            timer.Interval = 500;
            timer.Tick += new EventHandler(Ontimer);

            DadoRojo = new Dado(formulario.dadoJRojo);
            DadoVerde = new Dado(formulario.dadoJVerde);
            DadoAzul = new Dado(formulario.dadoJAzul);
            DadoAmarillo = new Dado(formulario.dadoJAmarillo);
        }

        private void Ontimer(object sender, EventArgs e)
        {
            if (numeroDado > 0)
            {
                MoverFicha();
                return;
            }
            timer.Stop();
        }

        public void TirarDado(Dado dado)
        {

            dado.tirarDado();
            numeroDado = dado.Numero;
            puedeSeleccionarFicha = true;
        }

        public void SeleccionarFicha(int indiceFicha)
        {
            //TODO: QUE SE LLAME AL METODO DE MOVER FICHA DEPENDIENDO DEL TURNO DEL JUGADOR
            //provisoriamente se va a llamar al jugadorRojo
            if (puedeSeleccionarFicha)
            {
                indiceFichaJugador = indiceFicha;
                timer.Start();
                puedeSeleccionarFicha = false;
            }
        }

        public void MoverFicha()
        {
            //PROVISORIO CAMBIAR EL JUGADOR DEPENDIENDO DEL TURNO
            Jugador jugador = JugadorRojo;

            Ficha ficha = jugador.Fichas[indiceFichaJugador];

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

            //Recorremos la lista de fichas para hacer las comprobaciones de comer o pasar
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
                    //Comprueba si tiene mas de un movimiento para saber si puede pasar a la ficha del mismo color
                    if (numeroDado > 1) avanza = true;
                    else avanza = false;
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
            }

            //Si la posicion futura esta libre se avanza
            if (avanza)
            {
                ficha.PosicionActual = ficha.PosicionFutura;

                ficha.Imagen.Location = ficha.PosicionActual;
                numeroDado--;
            }
        }
        internal Jugador JugadorRojo { get => jugadorRojo; set => jugadorRojo = value; }
        internal Jugador JugadorAzul { get => jugadorAzul; set => jugadorAzul = value; }
        internal Jugador JugadorAmarillo { get => jugadorAmarillo; set => jugadorAmarillo = value; }
        internal Jugador JugadorVerde { get => jugadorVerde; set => jugadorVerde = value; }
        public Dado DadoRojo { get => dadoRojo; set => dadoRojo = value; }
        public Dado DadoVerde { get => dadoVerde; set => dadoVerde = value; }
        public Dado DadoAzul { get => dadoAzul; set => dadoAzul = value; }
        public Dado DadoAmarillo { get => dadoAmarillo; set => dadoAmarillo = value; }
    }
}
