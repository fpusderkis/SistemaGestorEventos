
namespace SistemaGestorEventos.GUI.Permisos
{
    partial class FrmAdmUsuarios
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
            this.cbxUsuario = new System.Windows.Forms.ComboBox();
            this.gbxConfigurarUsuario = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.gbxFamilia = new System.Windows.Forms.GroupBox();
            this.btnQuitarFamilia = new System.Windows.Forms.Button();
            this.btnAgregarFamilia = new System.Windows.Forms.Button();
            this.cbxFamilias = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuitarPatente = new System.Windows.Forms.Button();
            this.btnAgregarPatente = new System.Windows.Forms.Button();
            this.cbxPatentes = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbxConfigurarUsuario.SuspendLayout();
            this.gbxFamilia.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxUsuario
            // 
            this.cbxUsuario.FormattingEnabled = true;
            this.cbxUsuario.Location = new System.Drawing.Point(6, 22);
            this.cbxUsuario.Name = "cbxUsuario";
            this.cbxUsuario.Size = new System.Drawing.Size(157, 23);
            this.cbxUsuario.TabIndex = 0;
            // 
            // gbxConfigurarUsuario
            // 
            this.gbxConfigurarUsuario.Controls.Add(this.treeView1);
            this.gbxConfigurarUsuario.Controls.Add(this.btnConfigurar);
            this.gbxConfigurarUsuario.Controls.Add(this.cbxUsuario);
            this.gbxConfigurarUsuario.Location = new System.Drawing.Point(13, 13);
            this.gbxConfigurarUsuario.Name = "gbxConfigurarUsuario";
            this.gbxConfigurarUsuario.Size = new System.Drawing.Size(255, 425);
            this.gbxConfigurarUsuario.TabIndex = 1;
            this.gbxConfigurarUsuario.TabStop = false;
            this.gbxConfigurarUsuario.Text = "Configurar Usuario";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(6, 52);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(239, 362);
            this.treeView1.TabIndex = 2;
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Location = new System.Drawing.Point(174, 22);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(75, 23);
            this.btnConfigurar.TabIndex = 1;
            this.btnConfigurar.Text = "Configurar";
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // gbxFamilia
            // 
            this.gbxFamilia.Controls.Add(this.btnQuitarFamilia);
            this.gbxFamilia.Controls.Add(this.btnAgregarFamilia);
            this.gbxFamilia.Controls.Add(this.cbxFamilias);
            this.gbxFamilia.Location = new System.Drawing.Point(274, 65);
            this.gbxFamilia.Name = "gbxFamilia";
            this.gbxFamilia.Size = new System.Drawing.Size(514, 97);
            this.gbxFamilia.TabIndex = 2;
            this.gbxFamilia.TabStop = false;
            this.gbxFamilia.Text = "Familia";
            // 
            // btnQuitarFamilia
            // 
            this.btnQuitarFamilia.Location = new System.Drawing.Point(87, 53);
            this.btnQuitarFamilia.Name = "btnQuitarFamilia";
            this.btnQuitarFamilia.Size = new System.Drawing.Size(75, 23);
            this.btnQuitarFamilia.TabIndex = 4;
            this.btnQuitarFamilia.Text = "Quitar";
            this.btnQuitarFamilia.UseVisualStyleBackColor = true;
            this.btnQuitarFamilia.Click += new System.EventHandler(this.btnQuitarFamilia_Click);
            // 
            // btnAgregarFamilia
            // 
            this.btnAgregarFamilia.Location = new System.Drawing.Point(6, 53);
            this.btnAgregarFamilia.Name = "btnAgregarFamilia";
            this.btnAgregarFamilia.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarFamilia.TabIndex = 3;
            this.btnAgregarFamilia.Text = "Agregar";
            this.btnAgregarFamilia.UseVisualStyleBackColor = true;
            this.btnAgregarFamilia.Click += new System.EventHandler(this.btnAgregarFamilia_Click);
            // 
            // cbxFamilias
            // 
            this.cbxFamilias.FormattingEnabled = true;
            this.cbxFamilias.Location = new System.Drawing.Point(6, 24);
            this.cbxFamilias.Name = "cbxFamilias";
            this.cbxFamilias.Size = new System.Drawing.Size(502, 23);
            this.cbxFamilias.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuitarPatente);
            this.groupBox1.Controls.Add(this.btnAgregarPatente);
            this.groupBox1.Controls.Add(this.cbxPatentes);
            this.groupBox1.Location = new System.Drawing.Point(274, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 97);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patente";
            // 
            // btnQuitarPatente
            // 
            this.btnQuitarPatente.Location = new System.Drawing.Point(87, 53);
            this.btnQuitarPatente.Name = "btnQuitarPatente";
            this.btnQuitarPatente.Size = new System.Drawing.Size(75, 23);
            this.btnQuitarPatente.TabIndex = 4;
            this.btnQuitarPatente.Text = "Quitar";
            this.btnQuitarPatente.UseVisualStyleBackColor = true;
            this.btnQuitarPatente.Click += new System.EventHandler(this.btnQuitarPatente_Click);
            // 
            // btnAgregarPatente
            // 
            this.btnAgregarPatente.Location = new System.Drawing.Point(6, 53);
            this.btnAgregarPatente.Name = "btnAgregarPatente";
            this.btnAgregarPatente.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPatente.TabIndex = 3;
            this.btnAgregarPatente.Text = "Agregar";
            this.btnAgregarPatente.UseVisualStyleBackColor = true;
            this.btnAgregarPatente.Click += new System.EventHandler(this.btnAgregarPatente_Click);
            // 
            // cbxPatentes
            // 
            this.cbxPatentes.FormattingEnabled = true;
            this.cbxPatentes.Location = new System.Drawing.Point(6, 24);
            this.cbxPatentes.Name = "cbxPatentes";
            this.cbxPatentes.Size = new System.Drawing.Size(502, 23);
            this.cbxPatentes.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(291, 404);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(145, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar configuracion";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(492, 404);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(145, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(643, 404);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(145, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmAdmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxFamilia);
            this.Controls.Add(this.gbxConfigurarUsuario);
            this.Name = "FrmAdmUsuarios";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administrar Permisos de Usuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAdmUsuarios_Load);
            this.gbxConfigurarUsuario.ResumeLayout(false);
            this.gbxFamilia.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxUsuario;
        private System.Windows.Forms.GroupBox gbxConfigurarUsuario;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnConfigurar;
        private System.Windows.Forms.GroupBox gbxFamilia;
        private System.Windows.Forms.Button btnQuitarFamilia;
        private System.Windows.Forms.Button btnAgregarFamilia;
        private System.Windows.Forms.ComboBox cbxFamilias;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQuitarPatente;
        private System.Windows.Forms.Button btnAgregarPatente;
        private System.Windows.Forms.ComboBox cbxPatentes;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
    }
}