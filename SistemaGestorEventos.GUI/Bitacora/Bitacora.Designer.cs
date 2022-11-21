namespace SistemaGestorEventos.GUI.Bitacora
{
    partial class Bitacora
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbxFilters = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblFilterDates = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnFind = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvLogsCreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLogsUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLogsMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxFilters.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxFilters
            // 
            this.gbxFilters.Controls.Add(this.tableLayoutPanel1);
            this.gbxFilters.Location = new System.Drawing.Point(25, 21);
            this.gbxFilters.Name = "gbxFilters";
            this.gbxFilters.Size = new System.Drawing.Size(780, 120);
            this.gbxFilters.TabIndex = 0;
            this.gbxFilters.TabStop = false;
            this.gbxFilters.Tag = "filters.title";
            this.gbxFilters.Text = "Filitros";
            this.gbxFilters.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.52459F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.47541F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 262F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel1.Controls.Add(this.lblUsername, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFilterDates, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtUsername, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpFrom, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpTo, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnFind, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(774, 94);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(3, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(59, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Tag = "username.title";
            this.lblUsername.Text = "Usuario";
            // 
            // lblFilterDates
            // 
            this.lblFilterDates.AutoSize = true;
            this.lblFilterDates.Location = new System.Drawing.Point(162, 0);
            this.lblFilterDates.Name = "lblFilterDates";
            this.lblFilterDates.Size = new System.Drawing.Size(155, 20);
            this.lblFilterDates.TabIndex = 1;
            this.lblFilterDates.Text = "Fecha (Desde - Hasta)";
            // 
            // txtUsername
            // 
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsername.Location = new System.Drawing.Point(3, 50);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(153, 27);
            this.txtUsername.TabIndex = 2;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(162, 50);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(249, 27);
            this.dtpFrom.TabIndex = 3;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(417, 50);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(250, 27);
            this.dtpTo.TabIndex = 4;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(679, 50);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(78, 29);
            this.btnFind.TabIndex = 5;
            this.btnFind.Tag = "btn.Find";
            this.btnFind.Text = "Buscar";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvLogsCreationDate,
            this.dgvLogsUsername,
            this.dgvLogsMessage});
            this.dataGridView1.Location = new System.Drawing.Point(30, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(772, 265);
            this.dataGridView1.TabIndex = 1;
            // 
            // dgvLogsCreationDate
            // 
            this.dgvLogsCreationDate.DataPropertyName = "CreationDate";
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            this.dgvLogsCreationDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLogsCreationDate.HeaderText = "Fecha";
            this.dgvLogsCreationDate.MinimumWidth = 6;
            this.dgvLogsCreationDate.Name = "dgvLogsCreationDate";
            this.dgvLogsCreationDate.ReadOnly = true;
            this.dgvLogsCreationDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLogsCreationDate.Width = 125;
            // 
            // dgvLogsUsername
            // 
            this.dgvLogsUsername.DataPropertyName = "Username";
            this.dgvLogsUsername.HeaderText = "Usuario";
            this.dgvLogsUsername.MinimumWidth = 6;
            this.dgvLogsUsername.Name = "dgvLogsUsername";
            this.dgvLogsUsername.ReadOnly = true;
            this.dgvLogsUsername.Width = 125;
            // 
            // dgvLogsMessage
            // 
            this.dgvLogsMessage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvLogsMessage.DataPropertyName = "Message";
            this.dgvLogsMessage.HeaderText = "Mensaje";
            this.dgvLogsMessage.MinimumWidth = 6;
            this.dgvLogsMessage.Name = "dgvLogsMessage";
            this.dgvLogsMessage.ReadOnly = true;
            // 
            // Bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbxFilters);
            this.Name = "Bitacora";
            this.Text = "Bitacora";
            this.Load += new System.EventHandler(this.Bitacora_Load);
            this.gbxFilters.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFilters;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblFilterDates;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLogsCreationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLogsUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLogsMessage;
    }
}