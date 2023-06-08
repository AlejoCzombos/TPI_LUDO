namespace TPI_Programacion___Ludo
{
    public class Posicion
    {
        private readonly int columna;
        private readonly int fila;
        public Posicion(int columna, int fila) 
        {
            this.fila = fila;
            this.columna = columna;
        }

        public int Fila { get => fila;}
        public int Columna { get => columna;}
    }
}