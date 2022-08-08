
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
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.txtTraducciones);
            this.groupBox1.Controls.Add(this.txtDescipcion);
            this.groupBox1.Controls.Add(this.cbxId);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(15, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(918, 501);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "lang.manage";
            this.groupBox1.Text = "Gestionar idioma";
            // 
            // txtTraducciones
            // 
            this.txtTraducciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTraducciones.BackColor = System.Drawing.SystemColors.Window;
            this.txtTraducciones.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTraducciones.Location = new System.Drawing.Point(8, 95);
            this.txtTraducciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTraducciones.Multiline = true;
            this.txtTraducciones.Name = "txtTraducciones";
            this.txtTraducciones.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTraducciones.Size = new System.Drawing.Size(870, 389);
            this.txtTraducciones.TabIndex = 2;
            // 
            // txtDescipcion
            // 
            this.txtDescipcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescipcion.Location = new System.Drawing.Point(154, 29);
            this.txtDescipcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescipcion.Name = "txtDescipcion";
            this.txtDescipcion.Size = new System.Drawing.Size(724, 32);
            this.txtDescipcion.TabIndex = 1;
            // 
            // cbxId
            // 
            this.cbxId.FormattingEnabled = true;
            this.cbxId.Location = new System.Drawing.Point(8, 31);
            this.cbxId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxId.Name = "cbxId";
            this.cbxId.Size = new System.Drawing.Size(138, 33);
            this.cbxId.TabIndex = 0;
            this.cbxId.SelectedIndexChanged += new System.EventHandler(this.cbxId_SelectedIndexChanged);
            // 
            // btnGuardarIdioma
            // 
            this.btnGuardarIdioma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardarIdioma.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGuardarIdioma.FlatAppearance.BorderSize = 0;
            this.btnGuardarIdioma.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGuardarIdioma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarIdioma.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarIdioma.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuardarIdioma.Location = new System.Drawing.Point(15, 527);
            this.btnGuardarIdioma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardarIdioma.Name = "btnGuardarIdioma";
            this.btnGuardarIdioma.Size = new System.Drawing.Size(114, 60);
            this.btnGuardarIdioma.TabIndex = 1;
            this.btnGuardarIdioma.Tag = "btn.save";
            this.btnGuardarIdioma.Text = "Guardar";
            this.btnGuardarIdioma.UseVisualStyleBackColor = false;
            this.btnGuardarIdioma.Click += new System.EventHandler(this.btnGuardarIdioma_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(818, 524);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 60);
            this.button1.TabIndex = 2;
            this.button1.Tag = "btn.exit";
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCrearEditarIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(946, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuardarIdioma);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCrearEditarIdioma";
            this.Tag = "title.lang.manage";
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