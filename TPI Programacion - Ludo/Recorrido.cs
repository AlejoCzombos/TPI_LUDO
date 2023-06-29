using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_Programacion___Ludo
{
    public class Recorrido
    {
        protected LinkedList<Point> posiciones;
        public Recorrido()
        {
            posiciones = new LinkedList<Point>();

            //Instanciar todas las posiciones del recorrido
            
            //Recorrido Verde
            posiciones.AddLast(new Point(477, 224));
            posiciones.AddLast(new Point(477, 182));
            posiciones.AddLast(new Point(477, 140));
            posiciones.AddLast(new Point(477, 98));//Estrella
            posiciones.AddLast(new Point(477, 56));
            posiciones.AddLast(new Point(477, 14));
            posiciones.AddLast(new Point(519, 14));
            posiciones.AddLast(new Point(561, 14));
            posiciones.AddLast(new Point(561, 56));//Salida
            posiciones.AddLast(new Point(561, 98));
            posiciones.AddLast(new Point(561, 140));
            posiciones.AddLast(new Point(561, 182));
            posiciones.AddLast(new Point(561, 224));

            //Sector Amarillo
            posiciones.AddLast(new Point(603,266));
            posiciones.AddLast(new Point(645, 266));
            posiciones.AddLast(new Point(687, 266));
            posiciones.AddLast(new Point(729, 266));//Estrella
            posiciones.AddLast(new Point(771, 266));
            posiciones.AddLast(new Point(813, 266));
            posiciones.AddLast(new Point(813,308));
            posiciones.AddLast(new Point(813,350));
            posiciones.AddLast(new Point(771, 350));//Salida
            posiciones.AddLast(new Point(729, 350));
            posiciones.AddLast(new Point(687, 350));
            posiciones.AddLast(new Point(645, 350));
            posiciones.AddLast(new Point(603, 350));

            //Recorrido Azul
            posiciones.AddLast(new Point(561, 392));
            posiciones.AddLast(new Point(561, 434));
            posiciones.AddLast(new Point(561, 476));
            posiciones.AddLast(new Point(561, 518));//Estrella
            posiciones.AddLast(new Point(561, 560));
            posiciones.AddLast(new Point(561, 602));
            posiciones.AddLast(new Point(519,602));
            posiciones.AddLast(new Point(477,602));
            posiciones.AddLast(new Point(477, 560));//Salida
            posiciones.AddLast(new Point(477, 518));
            posiciones.AddLast(new Point(477, 476));
            posiciones.AddLast(new Point(477, 434));
            posiciones.AddLast(new Point(477, 392));

            //Recorrido Rojo


            posiciones.AddLast(new Point(435, 350));
            posiciones.AddLast(new Point(393, 350));
            posiciones.AddLast(new Point(351, 350));
            posiciones.AddLast(new Point(310, 350));//Estrella
            posiciones.AddLast(new Point(268, 350));
            posiciones.AddLast(new Point(226, 350));
            posiciones.AddLast(new Point(226, 308));
            posiciones.AddLast(new Point(226, 266));
            posiciones.AddLast(new Point(268, 266));//Salida
            posiciones.AddLast(new Point(309, 266));
            posiciones.AddLast(new Point(351, 266));
            posiciones.AddLast(new Point(393, 266));
            posiciones.AddLast(new Point(435, 266));
        }

        public Point ProximaPosicion(Point posicionFicha)
        {
            LinkedListNode<Point> nodoActual = posiciones.Find(posicionFicha);

            if (nodoActual.Next != null)
            {
                return nodoActual.Next.Value;
            }
            else
            {
                return posiciones.First();
            }

        }
    }
}
