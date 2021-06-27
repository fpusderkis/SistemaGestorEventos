using SistemaGestorEventos.BLL;
using SistemaGestorEventos.SharedServices.bitacora;
using SistemaGestorEventos.SharedServices.bitacora.writers;
using SistemaGestorEventos.SharedServices.Multiidioma;
using SistemaGestorEventos.SharedServices.Session;
using System;
using System.Collections.Generic;
using System.Linq;
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

            Application.Run(new FrmPrincipal());
        }
    }
}
