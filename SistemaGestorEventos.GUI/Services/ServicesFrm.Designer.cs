namespace SistemaGestorEventos.GUI.Services
{
    partial class ServicesFrm
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
            this.btnSearchService = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvServicesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvServicesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvServicesPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvServicesFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvServicesCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvServicesActualizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnSearchService
            // 
            this.btnSearchService.Location = new System.Drawing.Point(428, 24);
            this.btnSearchService.Name = "btnSearchService";
            this.btnSearchService.Size = new System.Drawing.Size(94, 29);
            this.btnSearchService.TabIndex = 1;
            this.btnSearchService.Tag = "search.title";
            this.btnSearchService.Text = "Buscar";
            this.btnSearchService.UseVisualStyleBackColor = true;
            this.btnSearchService.Click += new System.EventHandler(this.btnSearchService_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(428, 59);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 2;
            this.btnSave.Tag = "save.title";
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvServicesId,
            this.dgvServicesName,
            this.dgvServicesPrice,
            this.dgvServicesFee,
            this.dgvServicesCreated,
            this.dgvServicesActualizado});
            this.dataGridView1.Location = new System.Drawing.Point(13, 215);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(775, 188);
            this.dataGridView1.TabIndex = 3;
            // 
            // dgvServicesId
            // 
            this.dgvServicesId.DataPropertyName = "Id";
            this.dgvServicesId.Frozen = true;
            this.dgvServicesId.HeaderText = "Id";
            this.dgvServicesId.MinimumWidth = 6;
            this.dgvServicesId.Name = "dgvServicesId";
            this.dgvServicesId.ReadOnly = true;
            this.dgvServicesId.Width = 80;
            // 
            // dgvServicesName
            // 
            this.dgvServicesName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvServicesName.DataPropertyName = "Name";
            this.dgvServicesName.HeaderText = "Nombre";
            this.dgvServicesName.MinimumWidth = 6;
            this.dgvServicesName.Name = "dgvServicesName";
            this.dgvServicesName.ReadOnly = true;
            // 
            // dgvServicesPrice
            // 
            this.dgvServicesPrice.DataPropertyName = "ProviderPrice";
            this.dgvServicesPrice.HeaderText = "Precio";
            this.dgvServicesPrice.MinimumWidth = 6;
            this.dgvServicesPrice.Name = "dgvServicesPrice";
            this.dgvServicesPrice.ReadOnly = true;
            this.dgvServicesPrice.Width = 80;
            // 
            // dgvServicesFee
            // 
            this.dgvServicesFee.DataPropertyName = "Fee";
            this.dgvServicesFee.HeaderText = "Comisión";
            this.dgvServicesFee.MinimumWidth = 6;
            this.dgvServicesFee.Name = "dgvServicesFee";
            this.dgvServicesFee.ReadOnly = true;
            this.dgvServicesFee.Width = 80;
            // 
            // dgvServicesCreated
            // 
            this.dgvServicesCreated.DataPropertyName = "CreatedAt";
            this.dgvServicesCreated.HeaderText = "Creado";
            this.dgvServicesCreated.MinimumWidth = 6;
            this.dgvServicesCreated.Name = "dgvServicesCreated";
            this.dgvServicesCreated.ReadOnly = true;
            this.dgvServicesCreated.Width = 80;
            // 
            // dgvServicesActualizado
            // 
            this.dgvServicesActualizado.DataPropertyName = "UpdatedAt";
            this.dgvServicesActualizado.HeaderText = "Actualizado";
            this.dgvServicesActualizado.MinimumWidth = 6;
            this.dgvServicesActualizado.Name = "dgvServicesActualizado";
            this.dgvServicesActualizado.ReadOnly = true;
            this.dgvServicesActualizado.Width = 80;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Tag = "edit.title";
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(428, 94);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 29);
            this.btnNew.TabIndex = 5;
            this.btnNew.Tag = "nuevo.title";
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // ServicesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSearchService);
            this.Controls.Add(this.groupBox1);
            this.Name = "ServicesFrm";
            this.Text = "ServicesFrm";
            this.Load += new System.EventHandler(this.ServicesFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchService;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvServicesId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvServicesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvServicesPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvServicesFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvServicesCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvServicesActualizado;
    }
}