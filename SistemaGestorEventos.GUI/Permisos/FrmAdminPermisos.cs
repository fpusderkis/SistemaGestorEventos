﻿using SistemaGestorEventos.BE.Grants;
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
    public partial class FrmAdminPermisos : Form
    {
        private IEnumerable<Family> familias = null;
        private IEnumerable<Grant> patentes = null;


        private GrantsBLL permisosBLL = GrantsBLL.Instance;

        private AbstractComponent edicion;

        public FrmAdminPermisos()
        {
            InitializeComponent();
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
            TraducirTextos();
        }

        private void txtFamilia_TextChanged(object sender, EventArgs e)
        {
            FiltrarComponentes(lbxFamilias, this.familias, txtFamilia.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var familia = new Family
            {
                Id = Guid.NewGuid(),
                Name = txtFamilia.Text
            };

            permisosBLL.GuardarComponente(familia,true);
            CargarFamilias();
            txtFamilia.Text = null;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            tvPermisos.BeginUpdate();
            tvPermisos.Nodes.Clear();
            this.edicion = (Family)lbxFamilias.SelectedItem;
            this.permisosBLL.FillFamilyComponents((Family)this.edicion);
            
            tvPermisos.Nodes.Add(GenerateTreeNode(this.edicion));
            tvPermisos.ExpandAll();


            tvPermisos.EndUpdate();
        }

        private TreeNode GenerateTreeNode(AbstractComponent componente)
        {
            var nodo = new TreeNode();
            nodo.Text = componente.Name;

            if (componente is Family)
            {
                foreach (var hijo in componente.Childs)
                {
                    nodo.Nodes.Add(GenerateTreeNode(hijo));
                }
            }
            nodo.Expand();
            return nodo;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            var familia = (AbstractComponent) lbxFamilias.SelectedItem;
            BorrarComponente(familia);

        }

        private void BorrarComponente(AbstractComponent componente)
        {
            if (this.edicion != null && componente != null && componente.Name != this.edicion.Name)
            {
                this.edicion.RemoveChild(componente);
                foreach (TreeNode nodo in ((TreeNode)tvPermisos.Nodes[0]).Nodes)
                {
                    if (nodo.Text == componente.Name)
                    {
                        ((TreeNode)tvPermisos.Nodes[0]).Nodes.Remove(nodo);
                        break;
                    }
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarComponente((AbstractComponent)lbxFamilias.SelectedItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AgregarComponente((AbstractComponent)lbxPatente.SelectedItem);
        }

        private void AgregarComponente(AbstractComponent componente)
        {
            
            if (this.edicion != null && componente != null && permisosBLL.Existe(this.edicion, componente.Id) == false)
            {
                this.edicion.AddChild(componente);
                ((TreeNode)tvPermisos.Nodes[0]).Nodes.Add(GenerateTreeNode(componente));
                ((TreeNode)tvPermisos.Nodes[0]).Expand();
            }
        }

        private void FiltrarComponentes(ListBox lbx, IEnumerable<AbstractComponent> componentes, string text)
        {

            lbx.BeginUpdate();
            lbx.DataSource = null;
            lbx.Items.Clear();

            if (!string.IsNullOrEmpty(text))
            {
                foreach (var componente in componentes)
                {
                    if (componente.Name.Contains(text))
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
                MessageBox.Show(MultiIdioma.TranslateOrDefault("errors.missing.grantname", "Debe indicar el nombre del permiso para crearlo"));
            }

            var p = new Grant()
            {
                Id = Guid.NewGuid(),
                Name = nombre,
                GrantType = (GrantType)cbxTipoPermiso.SelectedItem
            };

            permisosBLL.GuardarComponente(p, false);
            CargarPatentes();
            txtPatente.Text = null;
        }

        private void btnQuitarPatete_Click(object sender, EventArgs e)
        {
            BorrarComponente((AbstractComponent)lbxPatente.SelectedItem);
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
            this.permisosBLL.GuardarFamilia((Family)this.edicion);
            MessageBox.Show(MultiIdioma.TranslateOrDefault("configurations.saved", "Se guardo correctamente la configuracion."));
        }
    }
}
