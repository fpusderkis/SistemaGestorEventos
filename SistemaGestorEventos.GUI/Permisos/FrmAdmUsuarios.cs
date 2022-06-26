using SistemaGestorEventos.BE;
using SistemaGestorEventos.BE.Grants;
using SistemaGestorEventos.BLL;
using SistemaGestorEventos.GUI.usuario;
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
        private UserBLL usuarioBLL = UserBLL.Instance;
        private GrantsBLL grantsBLL = GrantsBLL.Instance;

        private User editable;

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
            cbxFamilias.DataSource = grantsBLL.GetAllFamilias();
            cbxFamilias.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxFamilias.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbxPatentes.DisplayMember = "Nombre";
            cbxPatentes.DataSource = grantsBLL.GetAllPatentes();
            cbxPatentes.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxPatentes.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            if (cbxUsuario.SelectedItem != null)
            {
                this.editable = (User)cbxUsuario.SelectedItem;

                this.editable.Permisos = this.grantsBLL.GetAllUserComponents(this.editable);
                ReloadTreeView();

            }
        }

        private void btnAgregarFamilia_Click(object sender, EventArgs e)
        {
            var componente = (BE.Grants.AbstractComponent)cbxFamilias.SelectedItem;
            AgregarComponente(componente);
        }

        #region funciones

        void AgregarComponente(BE.Grants.AbstractComponent componente)
        {
            if (this.editable != null)
            {
                if (componente != null)
                {
                    var esta = false;

                    foreach (var item in this.editable.Permisos)
                    {
                        if (grantsBLL.ExistsRelatedComponent(item, componente))
                        {
                            esta = true;
                            break;
                        }
                    }
                    // Patente esta?
                    if (! esta) 
                    {
                        // no esta!
                        if (componente is Family)
                            grantsBLL.FillFamilyComponents((Family)componente);

                        this.editable.Permisos.Add(componente);
                        this.ReloadTreeView();

                    }
                }
                
            }
        }

        void QuitarComponente(BE.Grants.AbstractComponent componente)
        {
            if (this.editable != null && componente != null)
            {
                if (this.editable.Permisos.RemoveAll(c => c.Id == componente.Id) > 0)
                {
                    ReloadTreeView();
                }
            }
            
        }
        void ReloadTreeView()
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

        void LlenarTreeView(TreeNode padre, BE.Grants.AbstractComponent c)
        {
            TreeNode hijo = new TreeNode(c.Name);
            hijo.Tag = c;
            padre.Nodes.Add(hijo);

            foreach (var item in c.Childs)
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
            QuitarComponente((Family)cbxFamilias.SelectedItem);
        }

        private void btnAgregarPatente_Click(object sender, EventArgs e)
        {
            var componente = (BE.Grants.AbstractComponent)cbxPatentes.SelectedItem;
            AgregarComponente(componente);
        }

        private void btnQuitarPatente_Click(object sender, EventArgs e)
        {
            QuitarComponente((BE.Grants.AbstractComponent)cbxPatentes.SelectedItem);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.editable != null)
            {
                usuarioBLL.SaveUserGrants(this.editable);
                MessageBox.Show(MultiIdioma.TranslateOrDefault("grants.correctsave",$"Los permisos se guardaron correctamente para el usuario {this.editable.Username}."));
            }
                
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {

            var user = (User)cbxUsuario.SelectedItem;

            if (user == null)
            {
                MessageBox.Show("Seleccione un usuario", "Bloquear usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            DialogResult result = MessageBox.Show("Desea bloquear el usuario?", "Bloquear usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (DialogResult.OK == result)
            {
                usuarioBLL.LockUser(user.Username);
                MessageBox.Show("Usuario bloqueado correctamente", "Bloquear usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNewEdit_Click(object sender, EventArgs e)
        {
            var form = new FrmRegistrar();
            var dialogResult = form.ShowDialog();

            cbxUsuario.DataSource = usuarioBLL.GetAll();
            btnCancelar_Click(null,null);
        }
    }
        
}
