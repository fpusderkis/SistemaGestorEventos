namespace SistemaGestorEventos.GUI.usuario
{
    partial class FrmChangePassword
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
            this.gbxLogin = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewPassRepeat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxLogin
            // 
            this.gbxLogin.Controls.Add(this.btnCancel);
            this.gbxLogin.Controls.Add(this.label2);
            this.gbxLogin.Controls.Add(this.txtNewPassRepeat);
            this.gbxLogin.Controls.Add(this.label1);
            this.gbxLogin.Controls.Add(this.txtNewPass);
            this.gbxLogin.Controls.Add(this.lblLogin);
            this.gbxLogin.Controls.Add(this.lblPassword);
            this.gbxLogin.Controls.Add(this.txtUsername);
            this.gbxLogin.Controls.Add(this.btnChangePassword);
            this.gbxLogin.Controls.Add(this.txtPassword);
            this.gbxLogin.Location = new System.Drawing.Point(12, 12);
            this.gbxLogin.Name = "gbxLogin";
            this.gbxLogin.Size = new System.Drawing.Size(540, 289);
            this.gbxLogin.TabIndex = 9;
            this.gbxLogin.TabStop = false;
            this.gbxLogin.Tag = "frmlogin.login.title";
            this.gbxLogin.Text = "Cambio de clave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 7;
            this.label2.Tag = "password.newpassword.repeat";
            this.label2.Text = "Repetir clave nueva";
            // 
            // txtNewPassRepeat
            // 
            this.txtNewPassRepeat.Location = new System.Drawing.Point(227, 194);
            this.txtNewPassRepeat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewPassRepeat.MaxLength = 255;
            this.txtNewPassRepeat.Name = "txtNewPassRepeat";
            this.txtNewPassRepeat.PasswordChar = '☺';
            this.txtNewPassRepeat.Size = new System.Drawing.Size(285, 27);
            this.txtNewPassRepeat.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 5;
            this.label1.Tag = "password.newpassword";
            this.label1.Text = "Clave nueva";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(227, 157);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewPass.MaxLength = 255;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(285, 27);
            this.txtNewPass.TabIndex = 6;
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
            this.lblPassword.Size = new System.Drawing.Size(89, 20);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Tag = "password";
            this.lblPassword.Text = "Clave actual";
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
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(383, 251);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(129, 31);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.Tag = "btn.changepassword";
            this.btnChangePassword.Text = "Cambiar clave";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
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
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(27, 251);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 29);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Tag = "btn.cancel";
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FrmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 312);
            this.Controls.Add(this.gbxLogin);
            this.Name = "FrmChangePassword";
            this.Text = "FrmChangePassword";
            this.gbxLogin.ResumeLayout(false);
            this.gbxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewPassRepeat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCancel;
    }
}