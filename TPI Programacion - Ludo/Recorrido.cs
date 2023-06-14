using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_Programacion___Ludo
{
    public class Recorrido
    {
        private LinkedList<Posicion> posiciones;
        public Recorrido()
        {
            posiciones = new LinkedList<Posicion>();

            //Instanciar todas las posiciones del recorrido
            //Sector Amarillo
            posiciones.AddLast(new Posicion(6,0));
            posiciones.AddLast(new Posicion(7,0));
            posiciones.AddLast(new Posicion(8,0));
            posiciones.AddLast(new Posicion(8,1));
            posiciones.AddLast(new Posicion(8,2));
            posiciones.AddLast(new Posicion(8,3));
            posiciones.AddLast(new Posicion(8,4));
            posiciones.AddLast(new Posicion(8,5));

            //Recorrido Azul
            posiciones.AddLast(new Posicion(9,6));
            posiciones.AddLast(new Posicion(10,6));
            posiciones.AddLast(new Posicion(11,6));
            posiciones.AddLast(new Posicion(12,6));
            posiciones.AddLast(new Posicion(13,6));
            posiciones.AddLast(new Posicion(14,6));
            posiciones.AddLast(new Posicion(14,7));
            posiciones.AddLast(new Posicion(14,8));
            posiciones.AddLast(new Posicion(13,8));
            posiciones.AddLast(new Posicion(12,8));
            posiciones.AddLast(new Posicion(11,8));
            posiciones.AddLast(new Posicion(10,8));
            posiciones.AddLast(new Posicion(9,8));

            //Recorrido Rojo
            posiciones.AddLast(new Posicion(8,9));
            posiciones.AddLast(new Posicion(8,10));
            posiciones.AddLast(new Posicion(8,11));
            posiciones.AddLast(new Posicion(8,12));
            posiciones.AddLast(new Posicion(8,13));
            posiciones.AddLast(new Posicion(8,14));
            posiciones.AddLast(new Posicion(7,14));
            posiciones.AddLast(new Posicion(6,14));
            posiciones.AddLast(new Posicion(6,13));
            posiciones.AddLast(new Posicion(6,12));
            posiciones.AddLast(new Posicion(6,11));
            posiciones.AddLast(new Posicion(6,10));
            posiciones.AddLast(new Posicion(6,9));

            //Recorrido Verde
            posiciones.AddLast(new Posicion(5,8));
            posiciones.AddLast(new Posicion(4,8));
            posiciones.AddLast(new Posicion(3,8));
            posiciones.AddLast(new Posicion(2,8));
            posiciones.AddLast(new Posicion(1,8));
            posiciones.AddLast(new Posicion(0,8));
            posiciones.AddLast(new Posicion(0,7));
            posiciones.AddLast(new Posicion(0,6));
            posiciones.AddLast(new Posicion(1,6));
            posiciones.AddLast(new Posicion(2,6));
            posiciones.AddLast(new Posicion(3,6));
            posiciones.AddLast(new Posicion(4,6));
            posiciones.AddLast(new Posicion(5,6));

            //Izquierda Amarillo
            posiciones.AddLast(new Posicion(6,5));
            posiciones.AddLast(new Posicion(6,4));
            posiciones.AddLast(new Posicion(6,3));
            posiciones.AddLast(new Posicion(6,2));
            posiciones.AddLast(new Posicion(6,1));
        }

        public LinkedList<Posicion> Posiciones { get => posiciones; set => posiciones = value;}

        public Posicion Posicion
        {
            get => default;
            set
            {
            }
        }

        public void ProximaPosicion(Posicion posicionFicha)
        {
            LinkedListNode<Posicion> nodoActual = posiciones.Find(posicionFicha);

            if(nodoActual.Next != null)
            {
                posicionFicha = nodoActual.Next.Value;
            }
            else
            {
                posicionFicha = posiciones.First();
            }

        }
    }
}
