namespace SistemaGestorEventos.GUI.FirstTime
{
    partial class FirstTimeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Iniciar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(779, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido al Sistema Gestor de Eventos";
            // 
            // Iniciar
            // 
            this.Iniciar.Location = new System.Drawing.Point(597, 275);
            this.Iniciar.Name = "Iniciar";
            this.Iniciar.Size = new System.Drawing.Size(162, 135);
            this.Iniciar.TabIndex = 1;
            this.Iniciar.Text = "Iniciar";
            this.Iniciar.UseVisualStyleBackColor = true;
            this.Iniciar.Click += new System.EventHandler(this.Iniciar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(582, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inserte los datos de conexión con la base de datos:";
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(21, 146);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(738, 27);
            this.txtConnectionString.TabIndex = 3;
            this.txtConnectionString.Text = "Data Source=.\\SQLEXPRESS;Initial Catalog=sgedb;Integrated Security=True";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 135);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ayuda";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(23, 184);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(163, 24);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Crear base de datos";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FirstTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 422);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtConnectionString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Iniciar);
            this.Controls.Add(this.label1);
            this.Name = "FirstTimeForm";
            this.Load += new System.EventHandler(this.FirstTimeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Iniciar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}