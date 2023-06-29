using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace TPI_Programacion___Ludo
{
    public enum Turno2Jugadores
    {
        Jugador1, Jugador2
    }
    public class Tablero2
    {
        private FormularioCPU formulario;
        private Recorrido recorrido;

        private Timer timer;

        private Jugador jugadorAmarillo;
        private Jugador jugadorRojo;

        private Dado dadoRojo;
        private Dado dadoAmarillo;
        private Dado dadoActual;

        private List<Ficha> fichas;
        private Jugador[] jugadores;

        private Turno2Jugadores turnoActual = Turno2Jugadores.Jugador1;

        //lista de posiciones donde no se pueden comer
        private LinkedList<Point> posicionesSeguras = new LinkedList<Point>();
        

        int movimientos = 0;
        int indiceFichaJugador;

        bool avanza, puedeSeleccionarFicha = false, puedeSeleccionarDado = true, puedeCambiarTurno = false;
        bool esPrimerMovimiento;
        public Tablero2()
        {
            formulario = Program.formularioCPU;

            InstanciarJugadores();

            recorrido = new Recorrido();
            jugadores = new Jugador[]{
                jugadorRojo,  jugadorAmarillo
            };

            timer = new Timer();
            timer.Interval = 500;
            timer.Tick += new EventHandler(Ontimer);

            DadoRojo = new Dado(formulario.dadoJRojo);
            DadoAmarillo = new Dado(formulario.dadoJAmarillo);

            cargarposSeguras();
        }

        private void Ontimer(object sender, EventArgs e)
        {
            if (movimientos > 0)
            {
                MoverFicha();
                return;
            }

            timer.Stop();


            if (puedeCambiarTurno)
            {
                CambiarTurno();
            }
        }

        public void TirarDado(Dado dado)
        {
            Jugador jugador = jugadores[(int)turnoActual];

            if (puedeSeleccionarDado)
            {
                dado.tirarDado();
                dadoActual = dado;

                movimientos = dado.Numero;

                puedeSeleccionarFicha = true;
                puedeSeleccionarDado = false;

                //Si todas las fichas estan en la casa y no sale un 1 o 6 se pasa el turno
                if (jugador.Fichas.All(x => x.EstaEnCasa) && movimientos != 1 && movimientos != 6)
                {
                    puedeCambiarTurno = true;
                    timer.Start();
                    return;
                }
            }
        }

        public void SeleccionarFicha(int indiceFicha)
        {
            if (puedeSeleccionarFicha)
            {
                indiceFichaJugador = indiceFicha;

                dadoActual.TurnoCero();

                timer.Start();

                esPrimerMovimiento = true;
                puedeSeleccionarFicha = false;
            }
        }


        private void CambiarTurno()
        {
            turnoActual = turnoActual == Turno2Jugadores.Jugador1 ? Turno2Jugadores.Jugador2 : Turno2Jugadores.Jugador1;

            CambiarDado();
            puedeSeleccionarDado = true;
        }

        public void MoverFicha()
        {
            Jugador jugador = jugadores[(int)turnoActual];

            Ficha ficha = jugador.Fichas[indiceFichaJugador];

            avanza = true;

            if (ficha.EstaEnCasa && (movimientos == 6 || movimientos == 1))
            {
                SacarFichaDeCasa(jugador, ficha);
            }
            //Controlar si se selecciona una ficha de la casa sin sacar 1 o 6
            else if (ficha.EstaEnCasa && (movimientos > 1 && movimientos < 6))
            {
                puedeCambiarTurno = true;
                movimientos = 0;
                return;
            }
            else
            {
                if (!ficha.EnRF)
                {
                    ficha.PosicionFutura = recorrido.ProximaPosicion(ficha.PosicionActual);
                }
                else
                {
                    if (jugador.RecorridoFinal.ProximaPosicionRF(ficha.PosicionActual) != Point.Empty)
                    {
                        ficha.PosicionFutura = jugador.RecorridoFinal.ProximaPosicionRF(ficha.PosicionActual);
                    }
                    else if (jugador.RecorridoFinal.ProximaPosicionRF(ficha.PosicionActual) == Point.Empty)
                    {
                        movimientos = 0;
                        jugador.Finalizados++;
                        if (jugador.Finalizados == 4)
                        {
                            FormularioGanador fg = new FormularioGanador((int)jugador.Color);
                            fg.ShowDialog();
                        }
                    }
                }


                if (ficha.PosicionFutura == ficha.PosicionFinal && !ficha.EnRF)
                {
                    ficha.EnRF = true;
                    ficha.PosicionFutura = jugador.RecorridoFinal.ProximaPosicionRF(ficha.PosicionFutura);
                }
                else MoverFichaNormal(jugador, ficha);
            }

            //Recorremos la lista de fichas para hacer las comprobaciones de comer o pasar
            foreach (Ficha fi in fichas)
            {
                //Comprobacion de comer fichas
                if (ficha == fi)
                    continue;

                //Compueba si en la posicion futura hay una ficha del otro color
                if (ficha.PosicionFutura == fi.PosicionActual && ficha.Color != fi.Color)
                {
                    if (movimientos == 1)
                    {
                        if (posicionesSeguras.Contains(fi.PosicionActual))
                        {
                            avanza = false;
                            break;
                        }

                        avanza = true;
                        fi.Imagen.Location = fi.PosicionCasa;
                        fi.EstaEnCasa = true;
                    }
                }
            }

            //Si la posicion futura esta libre se avanza
            if (avanza)
            {
                esPrimerMovimiento = false;
                ficha.PosicionActual = ficha.PosicionFutura;
                ficha.Imagen.Location = ficha.PosicionActual;
                movimientos--;

                if (movimientos == 0 && ficha.PosicionActual == jugador.PrimeraPosicion)
                {
                    puedeSeleccionarDado = true;
                }

                if (!puedeSeleccionarDado)
                {
                    puedeCambiarTurno = true;
                }
            }
        }

        private void MoverFichaNormal(Jugador jugador, Ficha ficha)
        {
            //Si sale 6 o 1 tiene otro turno
            if (movimientos == 6 && esPrimerMovimiento)
            {
                puedeSeleccionarDado = true;
                puedeCambiarTurno = false;
            }
            jugador.PrimeraPosicionOcupada = false;
        }
        private void SacarFichaDeCasa(Jugador jugador, Ficha ficha)
        {
            //pregunta si la primera posicion no esta ocupada
            if (!jugador.PrimeraPosicionOcupada)
            {
                ficha.PosicionFutura = jugador.PrimeraPosicion;
                ficha.EstaEnCasa = false;
                movimientos = 1;

                puedeSeleccionarDado = true;
                puedeCambiarTurno = false;
                jugador.PrimeraPosicionOcupada = true;
            }
            else
            {
                if (ficha.EstaEnCasa)
                {
                    ficha.PosicionFutura = ficha.PosicionActual;
                    puedeSeleccionarDado = false;
                    puedeCambiarTurno = true;
                    return;
                }
                else if (!ficha.EstaEnCasa && jugador.PrimeraPosicionOcupada)
                {
                    jugador.PrimeraPosicionOcupada = false;
                    puedeSeleccionarDado = true;
                    puedeCambiarTurno = false;
                }
            }

        }

        private void CambiarDado()
        {
            switch (turnoActual)
            {
                case Turno2Jugadores.Jugador1:
                    dadoAmarillo.ImagenDado.Enabled = false;
                    dadoAmarillo.ImagenDado.Image = null;

                    dadoRojo.ImagenDado.Enabled = true;
                    dadoRojo.ImagenDado.Image = Properties.Resources.Dado1;
                    break;
                case Turno2Jugadores.Jugador2:
                    dadoRojo.ImagenDado.Enabled = false;
                    dadoRojo.ImagenDado.Image = null;

                    dadoAmarillo.ImagenDado.Enabled = true;
                    dadoAmarillo.ImagenDado.Image = Properties.Resources.Dado1;
                    break;
                default:
                    break;
            }
        }

        private void InstanciarJugadores()
        {
            JugadorRojo = new Jugador(new Point(268, 266),new Point(226,266), Colores.Rojo,
                new Ficha[] {
                    new Ficha(formulario.fichaRoja0, new Point(291, 159)),
                    new Ficha(formulario.fichaRoja1, new Point(369, 159)),
                    new Ficha(formulario.fichaRoja2, new Point(369, 81)),
                    new Ficha(formulario.fichaRoja3, new Point(291, 81))
                });
            JugadorAmarillo = new Jugador(new Point(771, 350),new Point(813, 350), Colores.Amarillo,
                new Ficha[] {
                    new Ficha(formulario.fichaAmarilla0, new Point(669, 537)),
                    new Ficha(formulario.fichaAmarilla1, new Point(746, 537)),
                    new Ficha(formulario.fichaAmarilla2, new Point(746, 459)),
                    new Ficha(formulario.fichaAmarilla3, new Point(669, 459))
                });

            fichas = new List<Ficha>();

            fichas.AddRange(jugadorRojo.Fichas);
            fichas.AddRange(jugadorAmarillo.Fichas);
        }

        internal Jugador JugadorRojo { get => jugadorRojo; set => jugadorRojo = value; }
        internal Jugador JugadorAmarillo { get => jugadorAmarillo; set => jugadorAmarillo = value; }
        public Dado DadoRojo { get => dadoRojo; set => dadoRojo = value; }
        public Dado DadoAmarillo { get => dadoAmarillo; set => dadoAmarillo = value; }

        public void cargarposSeguras()
        {
            posicionesSeguras.AddLast(new Point(477, 98));//Estrella
            posicionesSeguras.AddLast(new Point(729, 266));//Estrella
            posicionesSeguras.AddLast(new Point(561, 518));//Estrella
            posicionesSeguras.AddLast(new Point(310, 350));//Estrella
        }
    }
    
}
