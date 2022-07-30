namespace SistemaGestorEventos.GUI.Home
{
    partial class FrmHome
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
            this.gbxCustomers = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAttendNew = new System.Windows.Forms.Button();
            this.btnFindCx = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTaxId = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxCxMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTaxId = new System.Windows.Forms.Label();
            this.gbxEvents = new System.Windows.Forms.GroupBox();
            this.txtEventId = new System.Windows.Forms.TextBox();
            this.lblFilterEventId = new System.Windows.Forms.Label();
            this.btnEventsSearch = new System.Windows.Forms.Button();
            this.btnNewEvent = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbxEventStatus = new System.Windows.Forms.ComboBox();
            this.btnOpenEvent = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.txtEventRoom = new System.Windows.Forms.TextBox();
            this.txtEventTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.dgvcEventId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcEventTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcEventFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.gbxEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCustomers
            // 
            this.gbxCustomers.Controls.Add(this.btnEditar);
            this.gbxCustomers.Controls.Add(this.btnAttendNew);
            this.gbxCustomers.Controls.Add(this.btnFindCx);
            this.gbxCustomers.Controls.Add(this.txtMail);
            this.gbxCustomers.Controls.Add(this.txtName);
            this.gbxCustomers.Controls.Add(this.txtTaxId);
            this.gbxCustomers.Controls.Add(this.lblMail);
            this.gbxCustomers.Controls.Add(this.lblName);
            this.gbxCustomers.Controls.Add(this.dgvCustomers);
            this.gbxCustomers.Controls.Add(this.lblTaxId);
            this.gbxCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxCustomers.Location = new System.Drawing.Point(0, 0);
            this.gbxCustomers.Margin = new System.Windows.Forms.Padding(10);
            this.gbxCustomers.Name = "gbxCustomers";
            this.gbxCustomers.Size = new System.Drawing.Size(800, 251);
            this.gbxCustomers.TabIndex = 0;
            this.gbxCustomers.TabStop = false;
            this.gbxCustomers.Tag = "customers";
            this.gbxCustomers.Text = "Clientes";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(681, 139);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(94, 29);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Tag = "btn.edit";
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAttendNew
            // 
            this.btnAttendNew.Location = new System.Drawing.Point(681, 104);
            this.btnAttendNew.Name = "btnAttendNew";
            this.btnAttendNew.Size = new System.Drawing.Size(94, 29);
            this.btnAttendNew.TabIndex = 3;
            this.btnAttendNew.Text = "Nuevo";
            this.btnAttendNew.UseVisualStyleBackColor = true;
            this.btnAttendNew.Click += new System.EventHandler(this.btnAttendNew_Click);
            // 
            // btnFindCx
            // 
            this.btnFindCx.Location = new System.Drawing.Point(681, 57);
            this.btnFindCx.Name = "btnFindCx";
            this.btnFindCx.Size = new System.Drawing.Size(94, 29);
            this.btnFindCx.TabIndex = 11;
            this.btnFindCx.Tag = "btn.search";
            this.btnFindCx.Text = "Buscar";
            this.btnFindCx.UseVisualStyleBackColor = true;
            this.btnFindCx.Click += new System.EventHandler(this.btnFindCx_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(380, 57);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(149, 27);
            this.txtMail.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(191, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(149, 27);
            this.txtName.TabIndex = 9;
            // 
            // txtTaxId
            // 
            this.txtTaxId.Location = new System.Drawing.Point(12, 57);
            this.txtTaxId.Name = "txtTaxId";
            this.txtTaxId.Size = new System.Drawing.Size(149, 27);
            this.txtTaxId.TabIndex = 8;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(380, 23);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(38, 20);
            this.lblMail.TabIndex = 7;
            this.lblMail.Tag = "mail.title";
            this.lblMail.Text = "Mail";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(191, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 20);
            this.lblName.TabIndex = 6;
            this.lblName.Tag = "name.title";
            this.lblName.Text = "Nombre";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CUIT,
            this.tbxcName,
            this.tbxCxMail});
            this.dgvCustomers.Location = new System.Drawing.Point(12, 104);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 29;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(663, 112);
            this.dgvCustomers.TabIndex = 5;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 51;
            // 
            // CUIT
            // 
            this.CUIT.HeaderText = "CUIT";
            this.CUIT.MinimumWidth = 6;
            this.CUIT.Name = "CUIT";
            this.CUIT.ReadOnly = true;
            this.CUIT.Width = 125;
            // 
            // tbxcName
            // 
            this.tbxcName.HeaderText = "Nombre";
            this.tbxcName.MinimumWidth = 6;
            this.tbxcName.Name = "tbxcName";
            this.tbxcName.ReadOnly = true;
            this.tbxcName.Width = 125;
            // 
            // tbxCxMail
            // 
            this.tbxCxMail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tbxCxMail.HeaderText = "Mail";
            this.tbxCxMail.MinimumWidth = 6;
            this.tbxCxMail.Name = "tbxCxMail";
            this.tbxCxMail.ReadOnly = true;
            // 
            // lblTaxId
            // 
            this.lblTaxId.AutoSize = true;
            this.lblTaxId.Location = new System.Drawing.Point(12, 23);
            this.lblTaxId.Name = "lblTaxId";
            this.lblTaxId.Size = new System.Drawing.Size(76, 20);
            this.lblTaxId.TabIndex = 4;
            this.lblTaxId.Tag = "taxpayertype.tittle";
            this.lblTaxId.Text = "CUIT/CUIL";
            // 
            // gbxEvents
            // 
            this.gbxEvents.Controls.Add(this.txtEventId);
            this.gbxEvents.Controls.Add(this.lblFilterEventId);
            this.gbxEvents.Controls.Add(this.btnEventsSearch);
            this.gbxEvents.Controls.Add(this.btnNewEvent);
            this.gbxEvents.Controls.Add(this.lblEstado);
            this.gbxEvents.Controls.Add(this.cbxEventStatus);
            this.gbxEvents.Controls.Add(this.btnOpenEvent);
            this.gbxEvents.Controls.Add(this.dtpTo);
            this.gbxEvents.Controls.Add(this.dtpFrom);
            this.gbxEvents.Controls.Add(this.txtEventRoom);
            this.gbxEvents.Controls.Add(this.txtEventTitle);
            this.gbxEvents.Controls.Add(this.label3);
            this.gbxEvents.Controls.Add(this.label2);
            this.gbxEvents.Controls.Add(this.label1);
            this.gbxEvents.Controls.Add(this.dgvEvents);
            this.gbxEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxEvents.Location = new System.Drawing.Point(0, 251);
            this.gbxEvents.Name = "gbxEvents";
            this.gbxEvents.Size = new System.Drawing.Size(800, 200);
            this.gbxEvents.TabIndex = 1;
            this.gbxEvents.TabStop = false;
            this.gbxEvents.Tag = "events.title";
            this.gbxEvents.Text = "Eventos";
            // 
            // txtEventId
            // 
            this.txtEventId.Location = new System.Drawing.Point(7, 44);
            this.txtEventId.Name = "txtEventId";
            this.txtEventId.Size = new System.Drawing.Size(75, 27);
            this.txtEventId.TabIndex = 14;
            this.txtEventId.TextChanged += new System.EventHandler(this.txtEventId_TextChanged);
            // 
            // lblFilterEventId
            // 
            this.lblFilterEventId.AutoSize = true;
            this.lblFilterEventId.Location = new System.Drawing.Point(12, 23);
            this.lblFilterEventId.Name = "lblFilterEventId";
            this.lblFilterEventId.Size = new System.Drawing.Size(22, 20);
            this.lblFilterEventId.TabIndex = 13;
            this.lblFilterEventId.Text = "Id";
            // 
            // btnEventsSearch
            // 
            this.btnEventsSearch.Location = new System.Drawing.Point(673, 95);
            this.btnEventsSearch.Name = "btnEventsSearch";
            this.btnEventsSearch.Size = new System.Drawing.Size(94, 29);
            this.btnEventsSearch.TabIndex = 12;
            this.btnEventsSearch.Tag = "btn.search";
            this.btnEventsSearch.Text = "Buscar";
            this.btnEventsSearch.UseVisualStyleBackColor = true;
            this.btnEventsSearch.Click += new System.EventHandler(this.btnEventsSearch_Click);
            // 
            // btnNewEvent
            // 
            this.btnNewEvent.Location = new System.Drawing.Point(672, 165);
            this.btnNewEvent.Name = "btnNewEvent";
            this.btnNewEvent.Size = new System.Drawing.Size(94, 29);
            this.btnNewEvent.TabIndex = 11;
            this.btnNewEvent.Tag = "newevent.Tittle";
            this.btnNewEvent.Text = "Nuevo";
            this.btnNewEvent.UseVisualStyleBackColor = true;
            this.btnNewEvent.Click += new System.EventHandler(this.btnNewEvent_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(634, 20);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(54, 20);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Tag = "status.title";
            this.lblEstado.Text = "Estado";
            // 
            // cbxEventStatus
            // 
            this.cbxEventStatus.FormattingEnabled = true;
            this.cbxEventStatus.Location = new System.Drawing.Point(634, 43);
            this.cbxEventStatus.Name = "cbxEventStatus";
            this.cbxEventStatus.Size = new System.Drawing.Size(132, 28);
            this.cbxEventStatus.TabIndex = 9;
            // 
            // btnOpenEvent
            // 
            this.btnOpenEvent.Location = new System.Drawing.Point(672, 130);
            this.btnOpenEvent.Name = "btnOpenEvent";
            this.btnOpenEvent.Size = new System.Drawing.Size(94, 29);
            this.btnOpenEvent.TabIndex = 8;
            this.btnOpenEvent.Tag = "open.title";
            this.btnOpenEvent.Text = "Abrir";
            this.btnOpenEvent.UseVisualStyleBackColor = true;
            this.btnOpenEvent.Click += new System.EventHandler(this.btnOpenEvent_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd/MM/yy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(545, 44);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(83, 27);
            this.dtpTo.TabIndex = 7;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd/MM/yy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(456, 44);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(83, 27);
            this.dtpFrom.TabIndex = 6;
            // 
            // txtEventRoom
            // 
            this.txtEventRoom.Location = new System.Drawing.Point(267, 44);
            this.txtEventRoom.Name = "txtEventRoom";
            this.txtEventRoom.Size = new System.Drawing.Size(167, 27);
            this.txtEventRoom.TabIndex = 5;
            // 
            // txtEventTitle
            // 
            this.txtEventTitle.Location = new System.Drawing.Point(88, 44);
            this.txtEventTitle.Name = "txtEventTitle";
            this.txtEventTitle.Size = new System.Drawing.Size(167, 27);
            this.txtEventTitle.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 3;
            this.label3.Tag = "date.between";
            this.label3.Text = "Fecha (Desde-Hasta)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 2;
            this.label2.Tag = "eventroom.title";
            this.label2.Text = "Salon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 1;
            this.label1.Tag = "eventtitle.tittle";
            this.label1.Text = "Titulo";
            // 
            // dgvEvents
            // 
            this.dgvEvents.AllowUserToAddRows = false;
            this.dgvEvents.AllowUserToDeleteRows = false;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcEventId,
            this.dgvcEventTitle,
            this.dgvcEventFrom,
            this.dgvcStatus});
            this.dgvEvents.Location = new System.Drawing.Point(12, 92);
            this.dgvEvents.MultiSelect = false;
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.ReadOnly = true;
            this.dgvEvents.RowHeadersWidth = 51;
            this.dgvEvents.RowTemplate.Height = 29;
            this.dgvEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvents.Size = new System.Drawing.Size(654, 102);
            this.dgvEvents.TabIndex = 0;
            // 
            // dgvcEventId
            // 
            this.dgvcEventId.DataPropertyName = "Id";
            this.dgvcEventId.HeaderText = "Id";
            this.dgvcEventId.MinimumWidth = 6;
            this.dgvcEventId.Name = "dgvcEventId";
            this.dgvcEventId.ReadOnly = true;
            this.dgvcEventId.Width = 60;
            // 
            // dgvcEventTitle
            // 
            this.dgvcEventTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcEventTitle.DataPropertyName = "Title";
            this.dgvcEventTitle.HeaderText = "Titulo";
            this.dgvcEventTitle.MinimumWidth = 6;
            this.dgvcEventTitle.Name = "dgvcEventTitle";
            this.dgvcEventTitle.ReadOnly = true;
            // 
            // dgvcEventFrom
            // 
            this.dgvcEventFrom.DataPropertyName = "DateFrom";
            this.dgvcEventFrom.HeaderText = "Fecha";
            this.dgvcEventFrom.MinimumWidth = 6;
            this.dgvcEventFrom.Name = "dgvcEventFrom";
            this.dgvcEventFrom.ReadOnly = true;
            this.dgvcEventFrom.Width = 125;
            // 
            // dgvcStatus
            // 
            this.dgvcStatus.DataPropertyName = "Status";
            this.dgvcStatus.HeaderText = "Estado";
            this.dgvcStatus.MinimumWidth = 6;
            this.dgvcStatus.Name = "dgvcStatus";
            this.dgvcStatus.ReadOnly = true;
            this.dgvcStatus.Width = 125;
            // 
            // FrmHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.gbxEvents);
            this.Controls.Add(this.gbxCustomers);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbxCustomers.ResumeLayout(false);
            this.gbxCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.gbxEvents.ResumeLayout(false);
            this.gbxEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCustomers;
        private System.Windows.Forms.Button btnAttendNew;
        private System.Windows.Forms.Button btnFindCx;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTaxId;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Label lblTaxId;
        private System.Windows.Forms.GroupBox gbxEvents;
        private System.Windows.Forms.Button btnOpenEvent;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.TextBox txtEventRoom;
        private System.Windows.Forms.TextBox txtEventTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbxEventStatus;
        private System.Windows.Forms.Button btnNewEvent;
        private System.Windows.Forms.Button btnEventsSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbxcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbxCxMail;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtEventId;
        private System.Windows.Forms.Label lblFilterEventId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcEventId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcEventTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcEventFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcStatus;
    }
}