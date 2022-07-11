namespace SistemaGestorEventos.GUI.Custommers
{
    partial class FrmRegisterCustomer
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
            this.tlpContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tlpCxHead = new System.Windows.Forms.TableLayoutPanel();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblTaxPayerId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTaxpayerid = new System.Windows.Forms.TextBox();
            this.tlpContactInfo = new System.Windows.Forms.TableLayoutPanel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblZipcode = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tlpContainer.SuspendLayout();
            this.tlpCxHead.SuspendLayout();
            this.tlpContactInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpContainer
            // 
            this.tlpContainer.ColumnCount = 1;
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainer.Controls.Add(this.tlpCxHead, 0, 1);
            this.tlpContainer.Controls.Add(this.tlpContactInfo, 0, 2);
            this.tlpContainer.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.tlpContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpContainer.Location = new System.Drawing.Point(0, 0);
            this.tlpContainer.Name = "tlpContainer";
            this.tlpContainer.RowCount = 5;
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpContainer.Size = new System.Drawing.Size(800, 272);
            this.tlpContainer.TabIndex = 0;
            // 
            // tlpCxHead
            // 
            this.tlpCxHead.ColumnCount = 3;
            this.tlpCxHead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tlpCxHead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCxHead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCxHead.Controls.Add(this.txtLastname, 2, 1);
            this.tlpCxHead.Controls.Add(this.txtName, 1, 1);
            this.tlpCxHead.Controls.Add(this.lblTaxPayerId, 0, 0);
            this.tlpCxHead.Controls.Add(this.lblName, 1, 0);
            this.tlpCxHead.Controls.Add(this.label1, 2, 0);
            this.tlpCxHead.Controls.Add(this.txtTaxpayerid, 0, 1);
            this.tlpCxHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCxHead.Location = new System.Drawing.Point(3, 13);
            this.tlpCxHead.Name = "tlpCxHead";
            this.tlpCxHead.RowCount = 2;
            this.tlpCxHead.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpCxHead.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpCxHead.Size = new System.Drawing.Size(794, 64);
            this.tlpCxHead.TabIndex = 0;
            // 
            // txtLastname
            // 
            this.txtLastname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLastname.Location = new System.Drawing.Point(485, 33);
            this.txtLastname.MaxLength = 100;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(306, 27);
            this.txtLastname.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(174, 33);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(305, 27);
            this.txtName.TabIndex = 4;
            // 
            // lblTaxPayerId
            // 
            this.lblTaxPayerId.AutoSize = true;
            this.lblTaxPayerId.Location = new System.Drawing.Point(3, 0);
            this.lblTaxPayerId.Name = "lblTaxPayerId";
            this.lblTaxPayerId.Size = new System.Drawing.Size(76, 20);
            this.lblTaxPayerId.TabIndex = 0;
            this.lblTaxPayerId.Tag = "taxPayerId.title";
            this.lblTaxPayerId.Text = "CUIT/CUIL";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(174, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Tag = "name";
            this.lblName.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Apellido";
            // 
            // txtTaxpayerid
            // 
            this.txtTaxpayerid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTaxpayerid.Location = new System.Drawing.Point(3, 33);
            this.txtTaxpayerid.MaxLength = 11;
            this.txtTaxpayerid.Name = "txtTaxpayerid";
            this.txtTaxpayerid.Size = new System.Drawing.Size(165, 27);
            this.txtTaxpayerid.TabIndex = 3;
            // 
            // tlpContactInfo
            // 
            this.tlpContactInfo.ColumnCount = 2;
            this.tlpContactInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContactInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContactInfo.Controls.Add(this.txtPhone, 1, 1);
            this.tlpContactInfo.Controls.Add(this.lblMail, 0, 0);
            this.tlpContactInfo.Controls.Add(this.label2, 1, 0);
            this.tlpContactInfo.Controls.Add(this.txtMail, 0, 1);
            this.tlpContactInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpContactInfo.Location = new System.Drawing.Point(3, 83);
            this.tlpContactInfo.Name = "tlpContactInfo";
            this.tlpContactInfo.RowCount = 3;
            this.tlpContactInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpContactInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpContactInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpContactInfo.Size = new System.Drawing.Size(794, 64);
            this.tlpContactInfo.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPhone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPhone.Location = new System.Drawing.Point(400, 33);
            this.txtPhone.MaxLength = 100;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(391, 27);
            this.txtPhone.TabIndex = 3;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(3, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(38, 20);
            this.lblMail.TabIndex = 0;
            this.lblMail.Tag = "mail.title";
            this.lblMail.Text = "Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefono";
            // 
            // txtMail
            // 
            this.txtMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtMail.Location = new System.Drawing.Point(3, 33);
            this.txtMail.MaxLength = 100;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(391, 27);
            this.txtMail.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.87154F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.12846F));
            this.tableLayoutPanel1.Controls.Add(this.txtZipcode, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAddress, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblZipcode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAddress, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 153);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.21428F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.78571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 112);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // txtZipcode
            // 
            this.txtZipcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZipcode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtZipcode.Location = new System.Drawing.Point(661, 28);
            this.txtZipcode.MaxLength = 10;
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Size = new System.Drawing.Size(130, 27);
            this.txtZipcode.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtAddress.Location = new System.Drawing.Point(3, 28);
            this.txtAddress.MaxLength = 100;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(652, 27);
            this.txtAddress.TabIndex = 3;
            // 
            // lblZipcode
            // 
            this.lblZipcode.AutoSize = true;
            this.lblZipcode.Location = new System.Drawing.Point(661, 0);
            this.lblZipcode.Name = "lblZipcode";
            this.lblZipcode.Size = new System.Drawing.Size(101, 20);
            this.lblZipcode.TabIndex = 1;
            this.lblZipcode.Tag = "zipcode.title";
            this.lblZipcode.Text = "Código Postal";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(3, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(72, 20);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Tag = "address.title";
            this.lblAddress.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 0;
            this.label3.Tag = "mail.title";
            this.label3.Text = "Mail";
            // 
            // tlpButtons
            // 
            this.tlpButtons.ColumnCount = 2;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.Controls.Add(this.btnCancel, 0, 0);
            this.tlpButtons.Controls.Add(this.btnSave, 1, 0);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpButtons.Location = new System.Drawing.Point(0, 366);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.Size = new System.Drawing.Size(800, 84);
            this.tlpButtons.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancel.Location = new System.Drawing.Point(25, 3);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(25, 3, 25, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 78);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Tag = "btn.cancel";
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Location = new System.Drawing.Point(635, 3);
            this.btnSave.Margin = new System.Windows.Forms.Padding(25, 3, 25, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 78);
            this.btnSave.TabIndex = 0;
            this.btnSave.Tag = "btn.save";
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmRegisterCustomer
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tlpButtons);
            this.Controls.Add(this.tlpContainer);
            this.Name = "FrmRegisterCustomer";
            this.Tag = "customer.register";
            this.Text = "Cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRegisterCustomer_FormClosed);
            this.Load += new System.EventHandler(this.FrmRegisterCustomer_Load);
            this.Shown += new System.EventHandler(this.FrmRegisterCustomer_Shown);
            this.tlpContainer.ResumeLayout(false);
            this.tlpCxHead.ResumeLayout(false);
            this.tlpCxHead.PerformLayout();
            this.tlpContactInfo.ResumeLayout(false);
            this.tlpContactInfo.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tlpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpContainer;
        private System.Windows.Forms.TableLayoutPanel tlpCxHead;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblTaxPayerId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTaxpayerid;
        private System.Windows.Forms.TableLayoutPanel tlpContactInfo;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtZipcode;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblZipcode;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}