using SistemaGestorEventos.BLL;
using SistemaGestorEventos.SharedServices.bitacora;
using SistemaGestorEventos.SharedServices.i18n;
using System;
using System.IO;
using System.Windows.Forms;

namespace SistemaGestorEventos.GUI.FirstTime
{
    public partial class FirstTimeForm : Form
    {
        private ConfigurationBLL configurationBLL = new ConfigurationBLL();
        public FirstTimeForm()
        {
            InitializeComponent();
            this.txtConnectionString.Text = configurationBLL.GetConnectionString();
            if (string.IsNullOrEmpty(this.txtConnectionString.Text))
            {
                this.txtConnectionString.Text = "Data Source=.\\SQLEXPRESS;Initial Catalog=sgedb;Integrated Security=True";
            }
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            var conString = txtConnectionString.Text;
            var errors = configurationBLL.SaveConnectionString(conString, checkBox1.Checked);
            if (errors.Count == 0)
            {
                MessageBox.Show("Se configuro correctamente la base de datos. Reinicie la aplicación para continuar.");
                BitacoraSingleton.Log("Configuración de la base de datos exitosa.");
                Environment.Exit(0);
            } 
            else
            {
                BitacoraSingleton.Error("No se pudo guardar la cadena de conexión " + conString);
                foreach (var er in errors)
                {
                    BitacoraSingleton.Error(er);
                }
                WinformUtils.ShowErrorList("No se pudo configurar la base de datos", errors);
                
            }            
        }

        private void FirstTimeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var helpFileName = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Ayuda") + @"\Manual de usuario.chm";


            if (!File.Exists(helpFileName))
            {
                FileInfo fileInfo = new FileInfo(helpFileName);
                fileInfo.Directory.Create();

                File.WriteAllBytes(helpFileName, Properties.Resources.Sistema_Gestor_de_Eventos);
            }

            Help.ShowHelp(this, helpFileName);
        }
    }
}
