namespace TPI_Programacion___Ludo
{
    public class Posicion : IComparable<Posicion>
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

        public int CompareTo(Posicion? other)
        {
            if (other == null) return 1;

            if (columna == other.Columna && fila == other.fila) return 0;
            else return -1;
        }
        public override bool Equals(object? obj)
        {
            return CompareTo((Posicion)obj) == 0;
        }
    }
}