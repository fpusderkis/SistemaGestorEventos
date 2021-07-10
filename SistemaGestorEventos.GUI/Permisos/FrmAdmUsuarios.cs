using SistemaGestorEventos.BE;
using SistemaGestorEventos.BE.Permisos;
using SistemaGestorEventos.BLL;
using SistemaGestorEventos.SharedServices.Multiidioma;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaGestorEventos.GUI.Permisos
{

    public partial class FrmAdmUsuarios : Form
    {
        private UsuarioBLL usuarioBLL = UsuarioBLL.Instance;
        private PermisosBLL permisosBLL = PermisosBLL.Instance;

        private Usuario editable;

        public FrmAdmUsuarios()
        {
            InitializeComponent();
            WinformUtils.TraducirControl(this);
            MultiIdioma.SuscribeCambioDeIdiomaEvent(() =>
            {
                WinformUtils.TraducirControl(this);
            });
        }

        private void FrmAdmUsuarios_Load(object sender, EventArgs e)
        {
            cbxUsuario.DisplayMember = "Username";
            cbxUsuario.DataSource = usuarioBLL.GetAll();
            cbxUsuario.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxUsuario.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbxFamilias.DisplayMember = "Nombre";
            cbxFamilias.DataSource = permisosBLL.GetAllFamilias();
            cbxFamilias.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxFamilias.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbxPatentes.DisplayMember = "Nombre";
            cbxPatentes.DataSource = permisosBLL.GetAllPatentes();
            cbxPatentes.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxPatentes.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            if (cbxUsuario.SelectedItem != null)
            {
                this.editable = (Usuario)cbxUsuario.SelectedItem;

                this.permisosBLL.FillUserComponents(this.editable);
                CargarConfiguracionUsuario();

            }
        }

        private void btnAgregarFamilia_Click(object sender, EventArgs e)
        {
            var componente = (Componente)cbxFamilias.SelectedItem;
            AgregarComponente(componente);
        }

        #region funciones

        void AgregarComponente(Componente componente)
        {
            if (this.editable != null)
            {
                if (componente != null)
                {
                    var esta = false;

                    foreach (var item in this.editable.Permisos)
                    {
                        if (permisosBLL.Existe(item, componente.Id))
                        {
                            esta = true;
                            break;
                        }
                    }
                    // Patente esta?
                    if (! esta) 
                    {
                        // no esta!
                        if (componente is Familia)
                            permisosBLL.FillFamilyComponents((Familia)componente);

                        this.editable.Permisos.Add(componente);
                        this.CargarConfiguracionUsuario();

                    }
                }
                
            }
        }

        void QuitarComponente(Componente componente)
        {
            if (this.editable != null && componente != null)
            {
                if (this.editable.Permisos.RemoveAll(c => c.Id == componente.Id) > 0)
                {
                    CargarConfiguracionUsuario();
                }
            }
            
        }
        void CargarConfiguracionUsuario()
        {
            this.treeView1.Nodes.Clear();
            TreeNode root = new TreeNode(this.editable.Username);

            foreach (var item in this.editable.Permisos)
            {
                LlenarTreeView(root, item);
            }

            this.treeView1.Nodes.Add(root);
            this.treeView1.ExpandAll();
        }

        void LlenarTreeView(TreeNode padre, Componente c)
        {
            TreeNode hijo = new TreeNode(c.Nombre);
            hijo.Tag = c;
            padre.Nodes.Add(hijo);

            foreach (var item in c.Hijos)
            {
                LlenarTreeView(hijo, item);
            }

        }
        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.editable = null;
            cbxUsuario.SelectedItem = null;
            this.treeView1.Nodes.Clear();
        }

        private void btnQuitarFamilia_Click(object sender, EventArgs e)
        {
            QuitarComponente((Familia)cbxFamilias.SelectedItem);
        }

        private void btnAgregarPatente_Click(object sender, EventArgs e)
        {
            var componente = (Componente)cbxPatentes.SelectedItem;
            AgregarComponente(componente);
        }

        private void btnQuitarPatente_Click(object sender, EventArgs e)
        {
            QuitarComponente((Componente)cbxPatentes.SelectedItem);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.editable != null)
                usuarioBLL.GuardarPermisos(this.editable);
        }
    }
        
}
