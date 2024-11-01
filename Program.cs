using FutbolDesktop.Views;

namespace FutbolDesktop
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Abrir IniciarSesionView como formulario modal
            using (var iniciarSesionView = new InciarSesionView())
            {
                iniciarSesionView.ShowDialog();

                // Si el inicio de sesión fue exitoso, abrir MenuPrincipal
                if (iniciarSesionView.loginSuccessfull)
                {
                    Application.Run(new MenuPrincipalView());
                }
            }
        }
    }
}