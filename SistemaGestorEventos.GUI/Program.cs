using SistemaGestorEventos.BE.Grants;
using SistemaGestorEventos.BLL;
using SistemaGestorEventos.GUI.FirstTime;
using SistemaGestorEventos.SharedServices.bitacora;
using SistemaGestorEventos.SharedServices.bitacora.writers;
using SistemaGestorEventos.SharedServices.i18n;
using SistemaGestorEventos.SharedServices.Session;
using System;

using System.Threading;

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

            var logfile = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData) + @"\sgelogs.log";
            

            if (!System.IO.File.Exists(logfile))
            {
                System.IO.FileInfo fileInfo = new System.IO.FileInfo(logfile);
                fileInfo.Directory.Create();
            }

            BitacoraSingleton.GetInstance.AddWriter(new BitacoraFileWritter(logfile));


            ConfigurationBLL configurationBLL = new ConfigurationBLL();

            if (configurationBLL.IsConnectionConfigured())
            {
                BitacoraSingleton.GetInstance.AddWriter(BitacoraBLL.GetInstance);

                SessionHandler.GetInstance.SuscribeSessionStatusChangeEvent(() => {
                    if (SessionHandler.GetInstance.IsLogged())
                    {
                        BitacoraSingleton.GetInstance.UserReferenceId = SessionHandler.GetInstance.User.Id;
                        BitacoraSingleton.GetInstance.Log("Inicio sesión");
                    }
                    else
                    {
                        BitacoraSingleton.GetInstance.Log("Cerro sesión");
                        BitacoraSingleton.GetInstance.UserReferenceId = null;
                    }

                });

                MultiLang.Initialize(MultiLangBLL.Instance, "es-AR");

                // Add the event handler for handling UI thread exceptions to the event.
                Application.ThreadException += new
                System.Threading.ThreadExceptionEventHandler((object sender, ThreadExceptionEventArgs e) => {
                    Console.WriteLine("ERROR NO CONTROLADO: " + e.Exception.Message);
                    Console.WriteLine(e.Exception.StackTrace);
                    BitacoraSingleton.GetInstance.Error($"ERROR NO CONTROLADO: {e.Exception.Message}");
                    MessageBox.Show(MultiLang.TranslateOrDefault("UnhandledGenericErrorMessage", "Ups! Ocurrio un error."));

                });

                // Set the unhandled exception mode to force all Windows Forms errors
                // to go through our handler.
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

                // Add the event handler for handling non-UI thread exceptions to the event. 
                AppDomain.CurrentDomain.UnhandledException += (object sender, UnhandledExceptionEventArgs e) => {
                    Console.WriteLine("ERROR NO CONTROLADO: " + ((Exception)e.ExceptionObject).Message);
                    Console.WriteLine(((Exception)e.ExceptionObject).StackTrace);
                    BitacoraSingleton.GetInstance.Error($"ERROR NO CONTROLADO: {((Exception)e.ExceptionObject).Message}");
                    MessageBox.Show(MultiLang.TranslateOrDefault("UnhandledGenericErrorMessage", "Ups! Ocurrio un error."));
                };

                Application.Run(new FrmPrincipal());
            } 
            else
            {
                Application.Run(new FirstTimeForm());
            }

            BitacoraSingleton.Error("Ejemplo de log de error");
            BitacoraSingleton.Trace("Ejemplo de trace");
            BitacoraSingleton.Log("Ejemplo log comun");
        }
    }
}
