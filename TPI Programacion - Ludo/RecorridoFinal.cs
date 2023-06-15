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
        static readonly Posicion[] rfVerde = { new Posicion(1,7),
                                              new Posicion(2,7),
                                              new Posicion(3,7),
                                              new Posicion(4,7),
                                              new Posicion(5,7),
                                              new Posicion(6,7)};
        static readonly LinkedList<Posicion> Verde = new LinkedList<Posicion>(rfVerde);
        static readonly Posicion[] rfAmarillo = { new Posicion(7,1),
                                              new Posicion(7,2),
                                              new Posicion(7,3),
                                              new Posicion(7,4),
                                              new Posicion(7,5),
                                              new Posicion(7,6)};
        static readonly LinkedList<Posicion> Amarillo = new LinkedList<Posicion>(rfAmarillo);
        static readonly Posicion[] rfAzul = { new Posicion(13,7),
                                              new Posicion(12,7),
                                              new Posicion(11,7),
                                              new Posicion(10,7),
                                              new Posicion(9,7),
                                              new Posicion(8,7)};
        static readonly LinkedList<Posicion> Azul = new LinkedList<Posicion>(rfAzul);
        static readonly Posicion[] rfRojo = { new Posicion(7,13),
                                              new Posicion(7,12),
                                              new Posicion(7,11),
                                              new Posicion(7,10),
                                              new Posicion(7,9),
                                              new Posicion(7,8)};
        static readonly LinkedList<Posicion> Rojo = new LinkedList<Posicion>(rfRojo);

        //En base al color del jugador, se instancia el recorrido final con las respectivas posiciones
        public RecorridoFinal(Colores color) 
        {
            switch(color) 
            {
                case Colores.Verde:
                    Posiciones = Verde; 
                    break;
                case Colores.Amarillo:
                    Posiciones = Amarillo;
                    break;
                case Colores.Azul:
                    Posiciones = Azul;
                    break;
                case Colores.Rojo:
                    Posiciones = Rojo;
                    break;
                default:
                    break;
            }
        }
    }
}
