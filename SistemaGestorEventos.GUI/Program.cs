using SistemaGestorEventos.BE.Permisos;
using SistemaGestorEventos.BLL;
using SistemaGestorEventos.SharedServices.bitacora;
using SistemaGestorEventos.SharedServices.bitacora.writers;
using SistemaGestorEventos.SharedServices.Multiidioma;
using SistemaGestorEventos.SharedServices.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorEventos.GUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BitacoraSingleton.GetInstance.AddWriter(new BitacoraConsoleWriter());
            BitacoraSingleton.GetInstance.AddWriter(BitacoraBLL.GetInstance);

            SessionHandler.GetInstance.SuscribeSessionStatusChangeEvent(() => {
                if (SessionHandler.GetInstance.IsLogged())
                {
                    BitacoraSingleton.GetInstance.UserReferenceId = SessionHandler.GetInstance.Usuario.Id;
                    BitacoraSingleton.GetInstance.Log("Inicio sesión");
                }
                else
                {
                    BitacoraSingleton.GetInstance.Log("Cerro sesión");
                    BitacoraSingleton.GetInstance.UserReferenceId = null;
                }
                
            });

            MultiIdioma.Initialize(MultiIdiomaBLL.Instance, "es-AR");

            // Add the event handler for handling UI thread exceptions to the event.
            Application.ThreadException += new
          System.Threading.ThreadExceptionEventHandler((object sender, ThreadExceptionEventArgs e) => {
              Console.WriteLine("ERROR NO CONTROLADO: " + e.Exception.Message);
              Console.WriteLine(e.Exception.StackTrace);
              BitacoraSingleton.GetInstance.Log($"ERROR NO CONTROLADO: {e.Exception.Message}");
              MessageBox.Show(MultiIdioma.TranslateOrDefault("UnhandledGenericErrorMessage", "Ups! Ocurrio un error."));
          });

            // Set the unhandled exception mode to force all Windows Forms errors
            // to go through our handler.
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            // Add the event handler for handling non-UI thread exceptions to the event. 
            AppDomain.CurrentDomain.UnhandledException += (object sender, UnhandledExceptionEventArgs e) => {
                Console.WriteLine("ERROR NO CONTROLADO: " + ((Exception)e.ExceptionObject).Message);
                Console.WriteLine(((Exception)e.ExceptionObject).StackTrace);
                BitacoraSingleton.GetInstance.Log($"ERROR NO CONTROLADO: {((Exception)e.ExceptionObject).Message}");
                MessageBox.Show(MultiIdioma.TranslateOrDefault("UnhandledGenericErrorMessage", "Ups! Ocurrio un error."));
            };

            Application.Run(new FrmPrincipal());
        }
    }
}
