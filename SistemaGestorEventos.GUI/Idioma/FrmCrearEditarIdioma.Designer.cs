
namespace SistemaGestorEventos.GUI.Idioma
{
    partial class FrmCrearEditarIdioma
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTraducciones = new System.Windows.Forms.TextBox();
            this.txtDescipcion = new System.Windows.Forms.TextBox();
            this.cbxId = new System.Windows.Forms.ComboBox();
            this.btnGuardarIdioma = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTraducciones);
            this.groupBox1.Controls.Add(this.txtDescipcion);
            this.groupBox1.Controls.Add(this.cbxId);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 376);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestionar idioma";
            // 
            // txtTraducciones
            // 
            this.txtTraducciones.Location = new System.Drawing.Point(7, 71);
            this.txtTraducciones.Multiline = true;
            this.txtTraducciones.Name = "txtTraducciones";
            this.txtTraducciones.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTraducciones.Size = new System.Drawing.Size(762, 293);
            this.txtTraducciones.TabIndex = 2;
            // 
            // txtDescipcion
            // 
            this.txtDescipcion.Location = new System.Drawing.Point(135, 22);
            this.txtDescipcion.Name = "txtDescipcion";
            this.txtDescipcion.Size = new System.Drawing.Size(634, 23);
            this.txtDescipcion.TabIndex = 1;
            // 
            // cbxId
            // 
            this.cbxId.FormattingEnabled = true;
            this.cbxId.Location = new System.Drawing.Point(7, 23);
            this.cbxId.Name = "cbxId";
            this.cbxId.Size = new System.Drawing.Size(121, 23);
            this.cbxId.TabIndex = 0;
            this.cbxId.SelectedIndexChanged += new System.EventHandler(this.cbxId_SelectedIndexChanged);
            // 
            // btnGuardarIdioma
            // 
            this.btnGuardarIdioma.Location = new System.Drawing.Point(20, 409);
            this.btnGuardarIdioma.Name = "btnGuardarIdioma";
            this.btnGuardarIdioma.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarIdioma.TabIndex = 1;
            this.btnGuardarIdioma.Text = "Guardar";
            this.btnGuardarIdioma.UseVisualStyleBackColor = true;
            this.btnGuardarIdioma.Click += new System.EventHandler(this.btnGuardarIdioma_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(707, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCrearEditarIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuardarIdioma);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCrearEditarIdioma";
            this.Text = "Gestion de idiomas";
            this.Load += new System.EventHandler(this.FrmCrearEditarIdioma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescipcion;
        private System.Windows.Forms.ComboBox cbxId;
        private System.Windows.Forms.Button btnGuardarIdioma;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTraducciones;
    }
}