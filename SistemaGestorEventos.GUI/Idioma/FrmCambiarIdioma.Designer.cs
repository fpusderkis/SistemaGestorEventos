
namespace SistemaGestorEventos.GUI.Idioma
{
    partial class FrmCambiarIdioma
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
            this.gbxCambiarIdioma = new System.Windows.Forms.GroupBox();
            this.btnGestionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCambiarIdioma = new System.Windows.Forms.Button();
            this.cbxIdiomas = new System.Windows.Forms.ComboBox();
            this.gbxCambiarIdioma.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCambiarIdioma
            // 
            this.gbxCambiarIdioma.Controls.Add(this.btnGestionar);
            this.gbxCambiarIdioma.Controls.Add(this.btnCancelar);
            this.gbxCambiarIdioma.Controls.Add(this.btnCambiarIdioma);
            this.gbxCambiarIdioma.Controls.Add(this.cbxIdiomas);
            this.gbxCambiarIdioma.Location = new System.Drawing.Point(12, 12);
            this.gbxCambiarIdioma.Name = "gbxCambiarIdioma";
            this.gbxCambiarIdioma.Size = new System.Drawing.Size(356, 100);
            this.gbxCambiarIdioma.TabIndex = 0;
            this.gbxCambiarIdioma.TabStop = false;
            this.gbxCambiarIdioma.Text = "Idiomas";
            // 
            // btnGestionar
            // 
            this.btnGestionar.Location = new System.Drawing.Point(6, 71);
            this.btnGestionar.Name = "btnGestionar";
            this.btnGestionar.Size = new System.Drawing.Size(75, 23);
            this.btnGestionar.TabIndex = 4;
            this.btnGestionar.Text = "Gestionar";
            this.btnGestionar.UseVisualStyleBackColor = true;
            this.btnGestionar.Click += new System.EventHandler(this.btnGestionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(197, 71);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCambiarIdioma
            // 
            this.btnCambiarIdioma.Location = new System.Drawing.Point(278, 71);
            this.btnCambiarIdioma.Name = "btnCambiarIdioma";
            this.btnCambiarIdioma.Size = new System.Drawing.Size(75, 23);
            this.btnCambiarIdioma.TabIndex = 2;
            this.btnCambiarIdioma.Text = "Cambiar";
            this.btnCambiarIdioma.UseVisualStyleBackColor = true;
            this.btnCambiarIdioma.Click += new System.EventHandler(this.btnCambiarIdioma_Click);
            // 
            // cbxIdiomas
            // 
            this.cbxIdiomas.FormattingEnabled = true;
            this.cbxIdiomas.Location = new System.Drawing.Point(3, 19);
            this.cbxIdiomas.Name = "cbxIdiomas";
            this.cbxIdiomas.Size = new System.Drawing.Size(347, 23);
            this.cbxIdiomas.TabIndex = 0;
            // 
            // FrmCambiarIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 123);
            this.Controls.Add(this.gbxCambiarIdioma);
            this.Name = "FrmCambiarIdioma";
            this.Text = "Cambiar idioma";
            this.Load += new System.EventHandler(this.FrmCambiarIdioma_Load);
            this.gbxCambiarIdioma.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCambiarIdioma;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCambiarIdioma;
        private System.Windows.Forms.ComboBox cbxIdiomas;
        private System.Windows.Forms.Button btnGestionar;
    }
}