
namespace SistemaGestorEventos.GUI.Permisos
{
    partial class FrmAdminPermisos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tvPermisos = new System.Windows.Forms.TreeView();
            this.gbxFamilias = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.lbxFamilias = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtFamilia = new System.Windows.Forms.TextBox();
            this.gbxPatentes = new System.Windows.Forms.GroupBox();
            this.cbxTipoPermiso = new System.Windows.Forms.ComboBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.btnAgregarPatente = new System.Windows.Forms.Button();
            this.btnQuitarPatete = new System.Windows.Forms.Button();
            this.btnCrearPatente = new System.Windows.Forms.Button();
            this.lbxPatente = new System.Windows.Forms.ListBox();
            this.gbxTreeEditar = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbxFamilias.SuspendLayout();
            this.gbxPatentes.SuspendLayout();
            this.gbxTreeEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvPermisos
            // 
            this.tvPermisos.Location = new System.Drawing.Point(7, 29);
            this.tvPermisos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tvPermisos.Name = "tvPermisos";
            this.tvPermisos.Size = new System.Drawing.Size(316, 464);
            this.tvPermisos.TabIndex = 0;
            // 
            // gbxFamilias
            // 
            this.gbxFamilias.Controls.Add(this.btnEditar);
            this.gbxFamilias.Controls.Add(this.btnQuitar);
            this.gbxFamilias.Controls.Add(this.lbxFamilias);
            this.gbxFamilias.Controls.Add(this.btnAdd);
            this.gbxFamilias.Controls.Add(this.btnAgregar);
            this.gbxFamilias.Controls.Add(this.txtFamilia);
            this.gbxFamilias.Location = new System.Drawing.Point(14, 16);
            this.gbxFamilias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxFamilias.Name = "gbxFamilias";
            this.gbxFamilias.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxFamilias.Size = new System.Drawing.Size(391, 253);
            this.gbxFamilias.TabIndex = 1;
            this.gbxFamilias.TabStop = false;
            this.gbxFamilias.Tag = "families";
            this.gbxFamilias.Text = "Familias";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(117, 204);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(175, 31);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Tag = "btn.config.selected";
            this.btnEditar.Text = "Configurar seleccionado";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(311, 137);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(64, 59);
            this.btnQuitar.TabIndex = 4;
            this.btnQuitar.Text = "<<";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lbxFamilias
            // 
            this.lbxFamilias.FormattingEnabled = true;
            this.lbxFamilias.ItemHeight = 20;
            this.lbxFamilias.Location = new System.Drawing.Point(7, 71);
            this.lbxFamilias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxFamilias.Name = "lbxFamilias";
            this.lbxFamilias.Size = new System.Drawing.Size(297, 124);
            this.lbxFamilias.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(8, 204);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 31);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Tag = "btn.add";
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(311, 71);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(64, 59);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = ">>";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtFamilia
            // 
            this.txtFamilia.Location = new System.Drawing.Point(8, 31);
            this.txtFamilia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFamilia.Name = "txtFamilia";
            this.txtFamilia.Size = new System.Drawing.Size(295, 27);
            this.txtFamilia.TabIndex = 0;
            this.txtFamilia.TextChanged += new System.EventHandler(this.txtFamilia_TextChanged);
            // 
            // gbxPatentes
            // 
            this.gbxPatentes.Controls.Add(this.cbxTipoPermiso);
            this.gbxPatentes.Controls.Add(this.txtPatente);
            this.gbxPatentes.Controls.Add(this.btnAgregarPatente);
            this.gbxPatentes.Controls.Add(this.btnQuitarPatete);
            this.gbxPatentes.Controls.Add(this.btnCrearPatente);
            this.gbxPatentes.Controls.Add(this.lbxPatente);
            this.gbxPatentes.Location = new System.Drawing.Point(14, 277);
            this.gbxPatentes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxPatentes.Name = "gbxPatentes";
            this.gbxPatentes.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxPatentes.Size = new System.Drawing.Size(391, 307);
            this.gbxPatentes.TabIndex = 2;
            this.gbxPatentes.TabStop = false;
            this.gbxPatentes.Tag = "grants";
            this.gbxPatentes.Text = "Patentes";
            // 
            // cbxTipoPermiso
            // 
            this.cbxTipoPermiso.FormattingEnabled = true;
            this.cbxTipoPermiso.Location = new System.Drawing.Point(14, 204);
            this.cbxTipoPermiso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxTipoPermiso.Name = "cbxTipoPermiso";
            this.cbxTipoPermiso.Size = new System.Drawing.Size(297, 28);
            this.cbxTipoPermiso.TabIndex = 11;
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(14, 31);
            this.txtPatente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(297, 27);
            this.txtPatente.TabIndex = 0;
            this.txtPatente.TextChanged += new System.EventHandler(this.txtPatente_TextChanged);
            // 
            // btnAgregarPatente
            // 
            this.btnAgregarPatente.Location = new System.Drawing.Point(318, 69);
            this.btnAgregarPatente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarPatente.Name = "btnAgregarPatente";
            this.btnAgregarPatente.Size = new System.Drawing.Size(64, 59);
            this.btnAgregarPatente.TabIndex = 9;
            this.btnAgregarPatente.Text = ">>";
            this.btnAgregarPatente.UseVisualStyleBackColor = true;
            this.btnAgregarPatente.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnQuitarPatete
            // 
            this.btnQuitarPatete.Location = new System.Drawing.Point(318, 136);
            this.btnQuitarPatete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuitarPatete.Name = "btnQuitarPatete";
            this.btnQuitarPatete.Size = new System.Drawing.Size(64, 59);
            this.btnQuitarPatete.TabIndex = 10;
            this.btnQuitarPatete.Text = "<<";
            this.btnQuitarPatete.UseVisualStyleBackColor = true;
            this.btnQuitarPatete.Click += new System.EventHandler(this.btnQuitarPatete_Click);
            // 
            // btnCrearPatente
            // 
            this.btnCrearPatente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCrearPatente.Location = new System.Drawing.Point(14, 243);
            this.btnCrearPatente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCrearPatente.Name = "btnCrearPatente";
            this.btnCrearPatente.Size = new System.Drawing.Size(91, 31);
            this.btnCrearPatente.TabIndex = 7;
            this.btnCrearPatente.Tag = "btn.create";
            this.btnCrearPatente.Text = "Crear";
            this.btnCrearPatente.UseVisualStyleBackColor = true;
            this.btnCrearPatente.Click += new System.EventHandler(this.btnCrearPatente_Click);
            // 
            // lbxPatente
            // 
            this.lbxPatente.FormattingEnabled = true;
            this.lbxPatente.ItemHeight = 20;
            this.lbxPatente.Location = new System.Drawing.Point(14, 69);
            this.lbxPatente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxPatente.Name = "lbxPatente";
            this.lbxPatente.Size = new System.Drawing.Size(297, 124);
            this.lbxPatente.TabIndex = 8;
            // 
            // gbxTreeEditar
            // 
            this.gbxTreeEditar.Controls.Add(this.tvPermisos);
            this.gbxTreeEditar.Location = new System.Drawing.Point(413, 16);
            this.gbxTreeEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxTreeEditar.Name = "gbxTreeEditar";
            this.gbxTreeEditar.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxTreeEditar.Size = new System.Drawing.Size(334, 504);
            this.gbxTreeEditar.TabIndex = 3;
            this.gbxTreeEditar.TabStop = false;
            this.gbxTreeEditar.Tag = "edit.family";
            this.gbxTreeEditar.Text = "Editar familia";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(661, 543);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 31);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Tag = "btn.exit";
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmAdminPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 600);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbxTreeEditar);
            this.Controls.Add(this.gbxPatentes);
            this.Controls.Add(this.gbxFamilias);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAdminPermisos";
            this.Tag = "title.admin.grants";
            this.Text = "Administrar permisos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAdminPermisos_Load);
            this.gbxFamilias.ResumeLayout(false);
            this.gbxFamilias.PerformLayout();
            this.gbxPatentes.ResumeLayout(false);
            this.gbxPatentes.PerformLayout();
            this.gbxTreeEditar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvPermisos;
        private System.Windows.Forms.GroupBox gbxFamilias;
        private System.Windows.Forms.GroupBox gbxPatentes;
        private System.Windows.Forms.ListBox lbxFamilias;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtFamilia;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox gbxTreeEditar;
        private System.Windows.Forms.ComboBox cbxTipoPermiso;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Button btnAgregarPatente;
        private System.Windows.Forms.Button btnQuitarPatete;
        private System.Windows.Forms.Button btnCrearPatente;
        private System.Windows.Forms.ListBox lbxPatente;
        private System.Windows.Forms.Button btnGuardarFamilia;
        private System.Windows.Forms.Button btnCancelarFamilia;
        private System.Windows.Forms.Button btnSalir;
    }
}