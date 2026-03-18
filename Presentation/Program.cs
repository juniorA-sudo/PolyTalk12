using Presentation.Seccion_de_Maestros;

namespace Presentation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // ?? Cambia esto por el formulario que quieras probar
            //Application.Run(new FrmPracticaVocabulario(1, "Práctica de Vocabulario"));

            //Application.Run(new FrmPerfilMaestro(2));
            Application.Run(new FrmLogin());
        }
    }
}