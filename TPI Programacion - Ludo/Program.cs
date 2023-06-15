using System.Security.Cryptography.X509Certificates;

namespace TPI_Programacion___Ludo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Tablero tab = new Tablero();
            Formulario formularioPrincipal = new Formulario(tab);
            tab.Formularioo = formularioPrincipal;
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            Application.Run(formularioPrincipal);
        }
    }
}