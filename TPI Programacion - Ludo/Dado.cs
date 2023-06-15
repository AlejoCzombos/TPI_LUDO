using System;

namespace TPI_Programacion___Ludo
{
    public class Dado
	{
        public static int tirarDado()
        {
            Random rnd = new Random();

            int dado = rnd.Next(1, 6);

            switch (dado)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
                default:
                    Console.WriteLine("Error");
                    break

            }
        }
	}
}
