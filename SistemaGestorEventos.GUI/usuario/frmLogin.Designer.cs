
namespace SistemaGestorEventos.GUI
{
    partial class FrmLogin
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.gbxLogin = new System.Windows.Forms.GroupBox();
            this.gbxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(27, 74);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(137, 20);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Tag = "username";
            this.lblLogin.Text = "Nombre de usuario";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(27, 128);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(45, 20);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Tag = "password";
            this.lblPassword.Text = "Clave";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(227, 70);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.MaxLength = 255;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(285, 27);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(227, 121);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.MaxLength = 255;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '☺';
            this.txtPassword.Size = new System.Drawing.Size(285, 27);
            this.txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(426, 203);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(86, 31);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Tag = "btn.login";
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblError.Location = new System.Drawing.Point(227, 152);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(171, 20);
            this.lblError.TabIndex = 7;
            this.lblError.Tag = "errors.invaliduserorpassword";
            this.lblError.Text = "Usuario/clave invalidos";
            this.lblError.Visible = false;
            // 
            // gbxLogin
            // 
            this.gbxLogin.Controls.Add(this.lblLogin);
            this.gbxLogin.Controls.Add(this.lblError);
            this.gbxLogin.Controls.Add(this.lblPassword);
            this.gbxLogin.Controls.Add(this.txtUsername);
            this.gbxLogin.Controls.Add(this.btnLogin);
            this.gbxLogin.Controls.Add(this.txtPassword);
            this.gbxLogin.Location = new System.Drawing.Point(12, 12);
            this.gbxLogin.Name = "gbxLogin";
            this.gbxLogin.Size = new System.Drawing.Size(540, 289);
            this.gbxLogin.TabIndex = 8;
            this.gbxLogin.TabStop = false;
            this.gbxLogin.Tag = "frmlogin.login.title";
            this.gbxLogin.Text = "Iniciar sesión";
            this.gbxLogin.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 591);
            this.Controls.Add(this.gbxLogin);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmLogin";
            this.ShowInTaskbar = false;
            this.Tag = "title.login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.Resize += new System.EventHandler(this.FrmLogin_Resize);
            this.gbxLogin.ResumeLayout(false);
            this.gbxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.GroupBox gbxLogin;
    }
}