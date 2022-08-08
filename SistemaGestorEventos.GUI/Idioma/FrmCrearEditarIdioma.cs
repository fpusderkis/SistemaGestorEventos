using SistemaGestorEventos.BLL;
using SistemaGestorEventos.SharedServices.i18n;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaGestorEventos.GUI.Idioma
{
    public partial class FrmCrearEditarIdioma : Form
    {

        private MultiLangBLL multiIdiomaBLL = MultiLangBLL.Instance;

        private List<BE.Idioma> idiomas;

        public FrmCrearEditarIdioma()
        {
            InitializeComponent();

        }

        private void FrmCrearEditarIdioma_Load(object sender, EventArgs e)
        {
            var lista = new List<string>();

            idiomas = multiIdiomaBLL.GetAllIdiomas();
            foreach(var idioma in idiomas)
            {
                lista.Add(idioma.Id);
            }


            cbxId.DisplayMember = "Descripcion";
            cbxId.DataSource = lista;
            cbxId.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxId.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxId.SelectedItem = null;
        }

        private void cbxId_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id_idioma = (string)cbxId.Text;
            if (string.IsNullOrWhiteSpace(id_idioma))
            {
                txtDescipcion.Text = null;
                txtTraducciones.Text = null;
                return;
            }

            var idioma = idiomas.Where(i => i.Id == id_idioma).FirstOrDefault<BE.Idioma>();

            if (idioma != null)
            {
                txtDescipcion.Text = idioma.Descripcion;
            }

            var traduccionesfull = multiIdiomaBLL.CargarIdiomaFull(id_idioma);

            StringBuilder sb = new StringBuilder();
            
            foreach(var key in traduccionesfull.Keys)
            {
                sb.Append(key).Append('=').Append(traduccionesfull[key]).Append(Environment.NewLine);
            }
            txtTraducciones.Text = sb.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarIdioma_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(this.cbxId.Text))
            {
                MessageBox.Show(MultiLang.TranslateOrDefault("FrmCrearEditarIdioma.Error.SeleccionaIdioma", "Escriba un identificador de idioma, se recomienda el formato de la RFC3066 (es-AR)"));
                return;
            } else if(string.IsNullOrWhiteSpace(txtDescipcion.Text))
            {
                MessageBox.Show(MultiLang.TranslateOrDefault("FrmCrearEditarIdioma.Error.IngresarDescipcion", "Escriba una descipcion para el idioma"));
                return;
            } else if(string.IsNullOrWhiteSpace(txtTraducciones.Text))
            {
                var lang = multiIdiomaBLL.CrearIdioma(cbxId.Text, txtDescipcion.Text);
                FrmCrearEditarIdioma_Load(null, null);
                cbxId.Text = lang.Id;
                txtDescipcion.Text = lang.Descripcion;
                cbxId_SelectedIndexChanged(null, null);
                return;
            }

            var idioma = new BE.Idioma
            {
                Id = (string)cbxId.Text,
                Descripcion = txtDescipcion.Text
            };

            var lineas = txtTraducciones.Text.Split(Environment.NewLine);
            var traducciones = new Dictionary<string, string>();
            foreach(var l in lineas)
            {
                if (!string.IsNullOrWhiteSpace(l))
                traducciones.Add(
                    l.Substring(0, l.IndexOf('=')),
                    l.Substring(1 + l.IndexOf('='))
                    );
            }

            multiIdiomaBLL.GuardarIdioma(idioma, traducciones);
        }

    }
}
