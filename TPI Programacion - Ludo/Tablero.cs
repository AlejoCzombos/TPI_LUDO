using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_Programacion___Ludo
{
    public class Tablero
    {
        private Ficha fichaR;
        private Formulario form;

        public Formulario Formm
        {
            get { return form; }
            set { form = value; }
        }
        Recorrido recorrido = new Recorrido();
        public Tablero()
        {

        }
        public void moverFicha()
        {
            //Formm.panelTablero.SetCellPosition( Formm.fichaRoja, new TableLayoutPanelCellPosition(recorrido.posicionActual.Columna, recorrido.posicionActual.Fila));
            //recorrido.ProximaPosicion();
        }

        public Recorrido Recorrido
        {
            get => default;
            set
            {
            }
        }
    }
}
