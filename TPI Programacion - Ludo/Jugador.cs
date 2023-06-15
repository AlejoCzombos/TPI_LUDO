using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_Programacion___Ludo
{
    internal class Jugador
    {
        public Jugador(Enum colores) 
        {

        }

        private Ficha[] fichas = new Ficha[4];

        //private enum color = 

        private Recorrido recorrido = new Recorrido();

        public Ficha[] Fichas { get => fichas; }

        //private RecorridoFinal recorridoFinal = new RecorridoFinal();

        public void moverFicha(int indiceFicha, int pasos)
        {
            //recorrido.ProximaPosicion();
        }
    }
}
