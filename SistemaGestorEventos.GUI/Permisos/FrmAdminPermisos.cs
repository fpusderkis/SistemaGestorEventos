using SistemaGestorEventos.BE.Permisos;
using SistemaGestorEventos.BLL;
using SistemaGestorEventos.GUI.Utils;
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
    public partial class FrmAdminPermisos : Form
    {
        private IEnumerable<Familia> familias = null;
        private IEnumerable<Patente> patentes = null;


        private PermisosBLL permisosBLL = PermisosBLL.Instance;

        private Familia edicion;

        public FrmAdminPermisos()
        {
            InitializeComponent();
            TraducirTextos();
            MultiIdioma.SuscribeCambioDeIdiomaEvent(this.TraducirTextos);
            CargarFamilias();
            CargarPatentes();
            FiltrarComponentes(lbxFamilias, this.familias, txtFamilia.Text);
            FiltrarComponentes(lbxPatente, this.patentes, txtPatente.Text);

            cbxTipoPermiso.DataSource = permisosBLL.GetAllPermission();


        }

        ~FrmAdminPermisos()
        {
            MultiIdioma.UnsuscribeCambioDeIdiomaEvent(this.TraducirTextos);
        }

        private void CargarFamilias()
        {
            this.familias = permisosBLL.GetAllFamilias();
            lbxFamilias.DataSource = familias;
        }
        private void CargarPatentes()
        {
            this.patentes = permisosBLL.GetAllPatentes();
            lbxPatente.DataSource = this.patentes;
        }
       
        private void TraducirTextos()
        {
            WinformUtils.TraducirControl(this);
        }

        private void FrmAdminPermisos_Load(object sender, EventArgs e)
        {

        }

        private void txtFamilia_TextChanged(object sender, EventArgs e)
        {
            FiltrarComponentes(lbxFamilias, this.familias, txtFamilia.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var familia = new Familia
            {
                Id = Guid.NewGuid(),
                Nombre = txtFamilia.Text
            };

            permisosBLL.GuardarComponente(familia,true);
            CargarFamilias();
            txtFamilia.Text = null;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            tvPermisos.BeginUpdate();
            tvPermisos.Nodes.Clear();
            this.edicion = (Familia)lbxFamilias.SelectedItem;
            this.permisosBLL.FillFamilyComponents(this.edicion);
            
            tvPermisos.Nodes.Add(GenerateTreeNode(this.edicion));
            tvPermisos.ExpandAll();


            tvPermisos.EndUpdate();
        }

        private TreeNode GenerateTreeNode(Componente componente)
        {
            var nodo = new TreeNode();
            nodo.Text = componente.Nombre;

            if (componente is Familia)
            {
                foreach (var hijo in componente.Hijos)
                {
                    nodo.Nodes.Add(GenerateTreeNode(hijo));
                }
            }
            nodo.Expand();
            return nodo;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            var familia = (Componente) lbxFamilias.SelectedItem;
            BorrarComponente(familia);

        }

        private void BorrarComponente(Componente componente)
        {
            if (this.edicion != null && componente != null && componente.Nombre != this.edicion.Nombre)
            {
                this.edicion.BorrarHijo(componente);
                foreach (TreeNode nodo in ((TreeNode)tvPermisos.Nodes[0]).Nodes)
                {
                    if (nodo.Text == componente.Nombre)
                    {
                        ((TreeNode)tvPermisos.Nodes[0]).Nodes.Remove(nodo);
                        break;
                    }
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarComponente((Componente)lbxFamilias.SelectedItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AgregarComponente((Componente)lbxPatente.SelectedItem);
        }

        private void AgregarComponente(Componente componente)
        {
            
            if (this.edicion != null && componente != null && permisosBLL.Existe(this.edicion, componente.Id) == false)
            {
                this.edicion.AgregarHijo(componente);
                ((TreeNode)tvPermisos.Nodes[0]).Nodes.Add(GenerateTreeNode(componente));
                ((TreeNode)tvPermisos.Nodes[0]).Expand();
            }
        }

        private void FiltrarComponentes(ListBox lbx, IEnumerable<Componente> componentes, string text)
        {

            lbx.BeginUpdate();
            lbx.DataSource = null;
            lbx.Items.Clear();

            if (!string.IsNullOrEmpty(text))
            {
                foreach (var componente in componentes)
                {
                    if (componente.Nombre.Contains(text))
                    {
                        lbx.Items.Add(componente);
                    }
                }
            }
            else
                lbx.DataSource = componentes;

            lbx.EndUpdate();
        }
        private void txtPatente_TextChanged(object sender, EventArgs e)
        {
            FiltrarComponentes(lbxPatente, this.patentes, txtPatente.Text);
        }

        private void btnCrearPatente_Click(object sender, EventArgs e)
        {
            var nombre = txtPatente.Text;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show(MultiIdioma.TraduccionODefault("FrmAdminPermisos.btnCrearPatente_Click.errorIndicarNombre", "Debe indicar el nombre del permiso para crearlo"));
            }

            var p = new Patente()
            {
                Id = Guid.NewGuid(),
                Nombre = nombre,
                Permiso = (TipoPermiso)cbxTipoPermiso.SelectedItem
            };

            permisosBLL.GuardarComponente(p, false);
            CargarPatentes();
            txtPatente.Text = null;
        }

        private void btnQuitarPatete_Click(object sender, EventArgs e)
        {
            BorrarComponente((Componente)lbxPatente.SelectedItem);
        }

        private void btnCancelarFamilia_Click(object sender, EventArgs e)
        {
            this.edicion = null;
            tvPermisos.Nodes.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            btnCancelarFamilia_Click(sender, e);
            this.Close();
        }

        private void btnGuardarFamilia_Click(object sender, EventArgs e)
        {
            this.permisosBLL.GuardarFamilia(this.edicion);
            MessageBox.Show(MultiIdioma.TraduccionODefault("FrmAdminPermisos.btnGuardarFamilia_Click.errorIndicarNombre", "Se guardo correctamente la configuracion."));
        }
    }
}
