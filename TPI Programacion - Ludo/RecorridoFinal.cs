using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_Programacion___Ludo
{
    internal class RecorridoFinal : Recorrido
    {
        //Representan los recorridos para ganar de cada color
        static readonly Point[] rfVerde = {   new Point(561, 14),
                                              new Point(519, 56),
                                              new Point(519, 98),
                                              new Point(519, 140),
                                              new Point(519, 182),
                                              new Point(519, 224),
                                              new Point(519, 266)
        };
        static readonly LinkedList<Point> Verde = new LinkedList<Point>(rfVerde);
        static readonly Point[] rfAmarillo = { new Point(813,350),
                                                 new Point(771, 308),
                                              new Point(729, 308),
                                              new Point(687, 308),
                                              new Point(645, 308),
                                              new Point(603, 308),
                                              new Point(561, 308)};
        static readonly LinkedList<Point> Amarillo = new LinkedList<Point>(rfAmarillo);
        static readonly Point[] rfAzul = { new Point(477,602),
                                             new Point(519, 561),
                                              new Point(519, 519),
                                              new Point(519, 477),
                                              new Point(519, 435),
                                              new Point(519, 393),
                                              new Point(519, 351)};
        static readonly LinkedList<Point> Azul = new LinkedList<Point>(rfAzul);
        static readonly Point[] rfRojo = { new Point(226, 266),
                                            new Point(268, 308),
                                              new Point(310, 308),
                                              new Point(352, 308),
                                              new Point(394, 308),
                                              new Point(436, 308),
                                              new Point(478, 308)};
        static LinkedList<Point> Rojo = new LinkedList<Point>(rfRojo);

        private LinkedList<Point> posicionesRf;

        //En base al color del jugador, se instancia el recorrido final con las respectivas posiciones
        public RecorridoFinal(Colores color)
        {
            switch (color)
            {
                case Colores.Verde:
                    posicionesRf = Verde;
                    break;
                case Colores.Amarillo:
                    posicionesRf = Amarillo;
                    break;
                case Colores.Azul:
                    posicionesRf = Azul;
                    break;
                case Colores.Rojo:
                    posicionesRf = Rojo;
                    break;
                default:
                    break;
            }
        }

        public Point ProximaPosicionRF(Point posicionFicha)
        {
            LinkedListNode<Point> nodoActual = posicionesRf.Find(posicionFicha);

            if (nodoActual.Next != null)
            {
                return nodoActual.Next.Value;
            }
            else
            {
                return Point.Empty;
            }
        }
    }
}
