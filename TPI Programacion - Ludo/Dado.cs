using System;

namespace TPI_Programacion___Ludo
{
    public class Dado
	{
        private Random rnd;
        private PictureBox imagenDado;
        private String[] pathsImagenes;
        private int numero;

        public int Numero { get => numero; set => numero = value; }

        public Dado(PictureBox imagenDado) 
        {
            this.imagenDado = imagenDado;
            rnd = new Random();
            pathsImagenes = ObtenerPaths();
        }

        private String[] ObtenerPaths()
        {
            String[] paths = new String[6];
            for(int i = 0; i < 6; i++)
            {
                paths[i] = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, $"Imagenes\\Dado{(i+1)}.png");
            }
            return paths;
        }

        public void tirarDado()
        {
            int resultado = rnd.Next(1, 7);

            imagenDado.ImageLocation = pathsImagenes[(resultado - 1)];
            numero = resultado;
        }
	}
}
