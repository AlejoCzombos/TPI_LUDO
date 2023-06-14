using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_Programacion___Ludo
{
    public class Tablero
    {
        private Formulario form;

        public Formulario Formm
        {
            get { return form; }
            set { form = value; }
        }
        public Tablero()
        {

        }
        public void moverFicha()
        {
            //Formm.panelTablero.SetCellPosition( Formm.fichaRoja, new TableLayoutPanelCellPosition(recorrido.posicionActual.Columna, recorrido.posicionActual.Fila));
        }
    }
}
