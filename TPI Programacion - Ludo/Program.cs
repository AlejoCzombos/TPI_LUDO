using System.Security.Cryptography.X509Certificates;

namespace TPI_Programacion___Ludo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static FormularioPrincipal formulario = new FormularioPrincipal();
        public static FormularioCPU formularioCPU = new FormularioCPU();
        public static FormularioPresentacion fp = new FormularioPresentacion();
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            Application.Run(fp);
        }
    }
}