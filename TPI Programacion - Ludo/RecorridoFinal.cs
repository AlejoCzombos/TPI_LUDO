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
        static readonly Point[] rfVerde = { new Point(1,7),
                                              new Point(2,7),
                                              new Point(3,7),
                                              new Point(4,7),
                                              new Point(5,7),
                                              new Point(6,7)};
        static readonly LinkedList<Point> Verde = new LinkedList<Point>(rfVerde);
        static readonly Point[] rfAmarillo = { new Point(7,1),
                                              new Point(7,2),
                                              new Point(7,3),
                                              new Point(7,4),
                                              new Point(7,5),
                                              new Point(7,6)};
        static readonly LinkedList<Point> Amarillo = new LinkedList<Point>(rfAmarillo);
        static readonly Point[] rfAzul = { new Point(13,7),
                                              new Point(12,7),
                                              new Point(11,7),
                                              new Point(10,7),
                                              new Point(9,7),
                                              new Point(8,7)};
        static readonly LinkedList<Point> Azul = new LinkedList<Point>(rfAzul);
        static readonly Point[] rfRojo = { new Point(7,13),
                                              new Point(7,12),
                                              new Point(7,11),
                                              new Point(7,10),
                                              new Point(7,9),
                                              new Point(7,8)};
        static readonly LinkedList<Point> Rojo = new LinkedList<Point>(rfRojo);

        //En base al color del jugador, se instancia el recorrido final con las respectivas posiciones
        public RecorridoFinal(Colores color) 
        {
            //switch(color) 
            //{
            //    case Colores.Verde:
            //        Posiciones = Verde; 
            //        break;
            //    case Colores.Amarillo:
            //        Posiciones = Amarillo;
            //        break;
            //    case Colores.Azul:
            //        Posiciones = Azul;
            //        break;
            //    case Colores.Rojo:
            //        Posiciones = Rojo;
            //        break;
            //    default:
            //        break;
            //}
        }
    }
}
