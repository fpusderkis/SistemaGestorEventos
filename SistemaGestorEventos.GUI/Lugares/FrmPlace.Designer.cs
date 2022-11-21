namespace SistemaGestorEventos.GUI.Lugares
{
    partial class FrmPlace
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblActive = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtBucketSize = new System.Windows.Forms.TextBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblBucketSize = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cbxActive = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.86792F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.13208F));
            this.tableLayoutPanel1.Controls.Add(this.lblActive, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtPrice, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtBucketSize, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCapacity, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtAddress, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAddress, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCapacity, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblBucketSize, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblPrice, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbxActive, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(637, 274);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblActive
            // 
            this.lblActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActive.AutoSize = true;
            this.lblActive.Location = new System.Drawing.Point(66, 190);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(51, 20);
            this.lblActive.TabIndex = 12;
            this.lblActive.Tag = "label.active";
            this.lblActive.Text = "Activo";
            // 
            // txtPrice
            // 
            this.txtPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrice.Location = new System.Drawing.Point(123, 153);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(511, 27);
            this.txtPrice.TabIndex = 11;
            // 
            // txtBucketSize
            // 
            this.txtBucketSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBucketSize.Location = new System.Drawing.Point(123, 123);
            this.txtBucketSize.Name = "txtBucketSize";
            this.txtBucketSize.Size = new System.Drawing.Size(511, 27);
            this.txtBucketSize.TabIndex = 10;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCapacity.Location = new System.Drawing.Point(123, 93);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(511, 27);
            this.txtCapacity.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddress.Location = new System.Drawing.Point(123, 63);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(511, 27);
            this.txtAddress.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(123, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(511, 27);
            this.txtName.TabIndex = 7;
            // 
            // lblId
            // 
            this.lblId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(95, 10);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(22, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Tag = "label.id";
            this.lblId.Text = "Id";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(53, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Tag = "label.name";
            this.lblName.Text = "Nombre";
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(45, 70);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(72, 20);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Tag = "label.address";
            this.lblAddress.Text = "Dirección";
            // 
            // lblCapacity
            // 
            this.lblCapacity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(37, 100);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(80, 20);
            this.lblCapacity.TabIndex = 3;
            this.lblCapacity.Tag = "label.capacity";
            this.lblCapacity.Text = "Capacidad";
            // 
            // lblBucketSize
            // 
            this.lblBucketSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBucketSize.AutoSize = true;
            this.lblBucketSize.Location = new System.Drawing.Point(16, 130);
            this.lblBucketSize.Name = "lblBucketSize";
            this.lblBucketSize.Size = new System.Drawing.Size(101, 20);
            this.lblBucketSize.TabIndex = 4;
            this.lblBucketSize.Tag = "label.bucketsize";
            this.lblBucketSize.Text = "Intervalos (hs)";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(67, 160);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(50, 20);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Tag = "label.price";
            this.lblPrice.Text = "Precio";
            // 
            // txtId
            // 
            this.txtId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtId.Location = new System.Drawing.Point(123, 3);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(511, 27);
            this.txtId.TabIndex = 6;
            // 
            // cbxActive
            // 
            this.cbxActive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxActive.AutoSize = true;
            this.cbxActive.Location = new System.Drawing.Point(123, 183);
            this.cbxActive.Name = "cbxActive";
            this.cbxActive.Size = new System.Drawing.Size(18, 24);
            this.cbxActive.TabIndex = 13;
            this.cbxActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(505, 303);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 53);
            this.btnSave.TabIndex = 1;
            this.btnSave.Tag = "button.save";
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(14, 303);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(146, 53);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Tag = "button.cancel";
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmPlace
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(663, 370);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmPlace";
            this.Text = "Lugar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPlace_FormClosed);
            this.Load += new System.EventHandler(this.FrmPlace_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblBucketSize;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtBucketSize;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.CheckBox cbxActive;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}