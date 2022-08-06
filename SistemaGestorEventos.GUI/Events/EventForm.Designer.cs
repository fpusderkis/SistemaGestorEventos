namespace SistemaGestorEventos.GUI.Events
{
    partial class EventForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabEventDetails = new System.Windows.Forms.TabControl();
            this.tabCharacteristics = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSpecialRequest = new System.Windows.Forms.TextBox();
            this.txtEventDescription = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblGuess = new System.Windows.Forms.Label();
            this.lblEventType = new System.Windows.Forms.Label();
            this.lblSpecialRequests = new System.Windows.Forms.Label();
            this.txtEventTitle = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMinus = new System.Windows.Forms.Label();
            this.txtBudgetMax = new System.Windows.Forms.NumericUpDown();
            this.txtBudgetMin = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.txtGuessQty = new System.Windows.Forms.NumericUpDown();
            this.cmbEventType = new System.Windows.Forms.ComboBox();
            this.tabLugares = new System.Windows.Forms.TabPage();
            this.gbxEventroomsDetails = new System.Windows.Forms.GroupBox();
            this.tblEventroomsMainDetail = new System.Windows.Forms.TableLayoutPanel();
            this.tlpEventroomsDetails = new System.Windows.Forms.TableLayoutPanel();
            this.lblEventroomsDetails = new System.Windows.Forms.Label();
            this.txtEventroomDetailsValue = new System.Windows.Forms.TextBox();
            this.lblSelectedEventroomDetailValue = new System.Windows.Forms.Label();
            this.tlpSearchResultEventrooms = new System.Windows.Forms.TableLayoutPanel();
            this.dgvEventrooms = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventRoomColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvERCCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvERCBucket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvERCPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.gbxEventroomsFilters = new System.Windows.Forms.GroupBox();
            this.btnSearchEventroom = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtFilterEventroomName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFilterPlaceName = new System.Windows.Forms.Label();
            this.txtFilterEventroomId = new System.Windows.Forms.TextBox();
            this.tabAditionalServices = new System.Windows.Forms.TabPage();
            this.tlpASDetails = new System.Windows.Forms.TableLayoutPanel();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.txtASDetails = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtASQty = new System.Windows.Forms.NumericUpDown();
            this.lblASQty = new System.Windows.Forms.Label();
            this.tlpAditionalServicesFilters = new System.Windows.Forms.TableLayoutPanel();
            this.panelFilterASName = new System.Windows.Forms.Panel();
            this.txtFilterASName = new System.Windows.Forms.TextBox();
            this.lblFilterASName = new System.Windows.Forms.Label();
            this.btnSearchAS = new System.Windows.Forms.Button();
            this.btnAddAS = new System.Windows.Forms.Button();
            this.dgvSearchAS = new System.Windows.Forms.DataGridView();
            this.dgvASFilterCId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvASFilterCName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvASFilterCPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAddedServices = new System.Windows.Forms.DataGridView();
            this.dgvASCId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvASCName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvASCQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvASCPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvASCTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnASRemove = new System.Windows.Forms.Button();
            this.lblASAdded = new System.Windows.Forms.Label();
            this.tabPagos = new System.Windows.Forms.TabPage();
            this.tlpPayments = new System.Windows.Forms.TableLayoutPanel();
            this.lblPayments = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tlpListOfPayments = new System.Windows.Forms.TableLayoutPanel();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.dgvPaymentsCId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPaymentsCType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPaymentsCDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPaymentsCConciliationKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPaymentsCAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpNewPayment = new System.Windows.Forms.TableLayoutPanel();
            this.lblType = new System.Windows.Forms.Label();
            this.lblPaymentAmount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.cbxNewPaymentType = new System.Windows.Forms.ComboBox();
            this.txtNewPaymentAmount = new System.Windows.Forms.NumericUpDown();
            this.txtConciliationKey = new System.Windows.Forms.TextBox();
            this.dtpNewPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddNewPayment = new System.Windows.Forms.Button();
            this.btnDeleteSelectedPayment = new System.Windows.Forms.Button();
            this.totalAmountsLP = new System.Windows.Forms.TableLayoutPanel();
            this.lblPaidValue = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.lblPendingPayment = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblPendingPayValue = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnApproveEvent = new System.Windows.Forms.Button();
            this.btnMakeBudget = new System.Windows.Forms.Button();
            this.tabEventDetails.SuspendLayout();
            this.tabCharacteristics.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBudgetMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBudgetMin)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGuessQty)).BeginInit();
            this.tabLugares.SuspendLayout();
            this.gbxEventroomsDetails.SuspendLayout();
            this.tblEventroomsMainDetail.SuspendLayout();
            this.tlpEventroomsDetails.SuspendLayout();
            this.tlpSearchResultEventrooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventrooms)).BeginInit();
            this.gbxEventroomsFilters.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabAditionalServices.SuspendLayout();
            this.tlpASDetails.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtASQty)).BeginInit();
            this.tlpAditionalServicesFilters.SuspendLayout();
            this.panelFilterASName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddedServices)).BeginInit();
            this.tabPagos.SuspendLayout();
            this.tlpPayments.SuspendLayout();
            this.tlpListOfPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.tlpNewPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPaymentAmount)).BeginInit();
            this.totalAmountsLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabEventDetails
            // 
            this.tabEventDetails.AllowDrop = true;
            this.tabEventDetails.Controls.Add(this.tabCharacteristics);
            this.tabEventDetails.Controls.Add(this.tabLugares);
            this.tabEventDetails.Controls.Add(this.tabAditionalServices);
            this.tabEventDetails.Controls.Add(this.tabPagos);
            this.tabEventDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabEventDetails.Location = new System.Drawing.Point(0, 0);
            this.tabEventDetails.Name = "tabEventDetails";
            this.tabEventDetails.SelectedIndex = 0;
            this.tabEventDetails.Size = new System.Drawing.Size(800, 458);
            this.tabEventDetails.TabIndex = 0;
            // 
            // tabCharacteristics
            // 
            this.tabCharacteristics.Controls.Add(this.tableLayoutPanel1);
            this.tabCharacteristics.Location = new System.Drawing.Point(4, 29);
            this.tabCharacteristics.Name = "tabCharacteristics";
            this.tabCharacteristics.Padding = new System.Windows.Forms.Padding(3);
            this.tabCharacteristics.Size = new System.Drawing.Size(792, 425);
            this.tabCharacteristics.TabIndex = 0;
            this.tabCharacteristics.Tag = "tab.characteristics";
            this.tabCharacteristics.Text = "Caracteristicas";
            this.tabCharacteristics.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txtSpecialRequest, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtEventDescription, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDescription, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBudget, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblGuess, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblEventType, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSpecialRequests, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtEventTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbEventType, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 419);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtSpecialRequest
            // 
            this.txtSpecialRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSpecialRequest.Location = new System.Drawing.Point(192, 252);
            this.txtSpecialRequest.MaxLength = 1000;
            this.txtSpecialRequest.Multiline = true;
            this.txtSpecialRequest.Name = "txtSpecialRequest";
            this.txtSpecialRequest.Size = new System.Drawing.Size(587, 160);
            this.txtSpecialRequest.TabIndex = 8;
            // 
            // txtEventDescription
            // 
            this.txtEventDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEventDescription.Location = new System.Drawing.Point(192, 37);
            this.txtEventDescription.MaxLength = 255;
            this.txtEventDescription.Multiline = true;
            this.txtEventDescription.Name = "txtEventDescription";
            this.txtEventDescription.Size = new System.Drawing.Size(587, 119);
            this.txtEventDescription.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(139, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(47, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Tag = "title.Title";
            this.lblTitle.Text = "Titulo";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(99, 34);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(87, 20);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Tag = "description.title";
            this.lblDescription.Text = "Descripcion";
            // 
            // lblBudget
            // 
            this.lblBudget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(97, 159);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(89, 20);
            this.lblBudget.TabIndex = 2;
            this.lblBudget.Tag = "minus";
            this.lblBudget.Text = "Presupuesto";
            // 
            // lblGuess
            // 
            this.lblGuess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGuess.AutoSize = true;
            this.lblGuess.Location = new System.Drawing.Point(117, 189);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(69, 20);
            this.lblGuess.TabIndex = 3;
            this.lblGuess.Tag = "guess.title";
            this.lblGuess.Text = "Invitados";
            // 
            // lblEventType
            // 
            this.lblEventType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEventType.AutoSize = true;
            this.lblEventType.Location = new System.Drawing.Point(77, 219);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(109, 20);
            this.lblEventType.TabIndex = 4;
            this.lblEventType.Tag = "event.tyle.title";
            this.lblEventType.Text = "Tipo de evento";
            // 
            // lblSpecialRequests
            // 
            this.lblSpecialRequests.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpecialRequests.AutoSize = true;
            this.lblSpecialRequests.Location = new System.Drawing.Point(53, 249);
            this.lblSpecialRequests.Name = "lblSpecialRequests";
            this.lblSpecialRequests.Size = new System.Drawing.Size(133, 20);
            this.lblSpecialRequests.TabIndex = 5;
            this.lblSpecialRequests.Tag = "specialrequest.title";
            this.lblSpecialRequests.Text = "Pedidos especiales";
            // 
            // txtEventTitle
            // 
            this.txtEventTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEventTitle.Location = new System.Drawing.Point(192, 7);
            this.txtEventTitle.MaxLength = 255;
            this.txtEventTitle.Name = "txtEventTitle";
            this.txtEventTitle.Size = new System.Drawing.Size(587, 27);
            this.txtEventTitle.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblMinus);
            this.panel1.Controls.Add(this.txtBudgetMax);
            this.panel1.Controls.Add(this.txtBudgetMin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(192, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 24);
            this.panel1.TabIndex = 9;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd/MM/yy HH:mm";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(324, 0);
            this.dtpFecha.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(260, 27);
            this.dtpFecha.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha";
            // 
            // lblMinus
            // 
            this.lblMinus.AutoSize = true;
            this.lblMinus.Location = new System.Drawing.Point(130, 2);
            this.lblMinus.Name = "lblMinus";
            this.lblMinus.Size = new System.Drawing.Size(23, 20);
            this.lblMinus.TabIndex = 2;
            this.lblMinus.Tag = "";
            this.lblMinus.Text = " - ";
            // 
            // txtBudgetMax
            // 
            this.txtBudgetMax.DecimalPlaces = 2;
            this.txtBudgetMax.Location = new System.Drawing.Point(159, -3);
            this.txtBudgetMax.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtBudgetMax.Name = "txtBudgetMax";
            this.txtBudgetMax.Size = new System.Drawing.Size(101, 27);
            this.txtBudgetMax.TabIndex = 1;
            // 
            // txtBudgetMin
            // 
            this.txtBudgetMin.DecimalPlaces = 2;
            this.txtBudgetMin.Location = new System.Drawing.Point(3, 0);
            this.txtBudgetMin.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtBudgetMin.Name = "txtBudgetMin";
            this.txtBudgetMin.Size = new System.Drawing.Size(121, 27);
            this.txtBudgetMin.TabIndex = 0;
            this.txtBudgetMin.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtpToDate);
            this.panel2.Controls.Add(this.txtGuessQty);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(192, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 24);
            this.panel2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta";
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd/MM/yy HH:mm";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(324, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(260, 27);
            this.dtpToDate.TabIndex = 1;
            // 
            // txtGuessQty
            // 
            this.txtGuessQty.Location = new System.Drawing.Point(5, 1);
            this.txtGuessQty.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtGuessQty.Name = "txtGuessQty";
            this.txtGuessQty.Size = new System.Drawing.Size(150, 27);
            this.txtGuessQty.TabIndex = 0;
            this.txtGuessQty.ValueChanged += new System.EventHandler(this.txtGuessQty_ValueChanged);
            // 
            // cmbEventType
            // 
            this.cmbEventType.DisplayMember = "Text";
            this.cmbEventType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbEventType.FormattingEnabled = true;
            this.cmbEventType.Location = new System.Drawing.Point(192, 222);
            this.cmbEventType.Name = "cmbEventType";
            this.cmbEventType.Size = new System.Drawing.Size(587, 28);
            this.cmbEventType.TabIndex = 11;
            this.cmbEventType.ValueMember = "Value";
            this.cmbEventType.SelectedIndexChanged += new System.EventHandler(this.cmbEventType_SelectedIndexChanged);
            // 
            // tabLugares
            // 
            this.tabLugares.Controls.Add(this.gbxEventroomsDetails);
            this.tabLugares.Controls.Add(this.tlpSearchResultEventrooms);
            this.tabLugares.Controls.Add(this.gbxEventroomsFilters);
            this.tabLugares.Location = new System.Drawing.Point(4, 29);
            this.tabLugares.Name = "tabLugares";
            this.tabLugares.Padding = new System.Windows.Forms.Padding(3);
            this.tabLugares.Size = new System.Drawing.Size(792, 425);
            this.tabLugares.TabIndex = 1;
            this.tabLugares.Tag = "tab.eventrooms";
            this.tabLugares.Text = "Lugares";
            this.tabLugares.UseVisualStyleBackColor = true;
            // 
            // gbxEventroomsDetails
            // 
            this.gbxEventroomsDetails.Controls.Add(this.tblEventroomsMainDetail);
            this.gbxEventroomsDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxEventroomsDetails.Location = new System.Drawing.Point(3, 214);
            this.gbxEventroomsDetails.Name = "gbxEventroomsDetails";
            this.gbxEventroomsDetails.Size = new System.Drawing.Size(786, 157);
            this.gbxEventroomsDetails.TabIndex = 3;
            this.gbxEventroomsDetails.TabStop = false;
            this.gbxEventroomsDetails.Tag = "eventroom.details.title";
            this.gbxEventroomsDetails.Text = "Detalle";
            // 
            // tblEventroomsMainDetail
            // 
            this.tblEventroomsMainDetail.ColumnCount = 1;
            this.tblEventroomsMainDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblEventroomsMainDetail.Controls.Add(this.tlpEventroomsDetails, 0, 1);
            this.tblEventroomsMainDetail.Controls.Add(this.lblSelectedEventroomDetailValue, 0, 0);
            this.tblEventroomsMainDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblEventroomsMainDetail.Location = new System.Drawing.Point(3, 23);
            this.tblEventroomsMainDetail.Name = "tblEventroomsMainDetail";
            this.tblEventroomsMainDetail.RowCount = 2;
            this.tblEventroomsMainDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblEventroomsMainDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblEventroomsMainDetail.Size = new System.Drawing.Size(780, 131);
            this.tblEventroomsMainDetail.TabIndex = 0;
            // 
            // tlpEventroomsDetails
            // 
            this.tlpEventroomsDetails.ColumnCount = 2;
            this.tlpEventroomsDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpEventroomsDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpEventroomsDetails.Controls.Add(this.lblEventroomsDetails, 0, 0);
            this.tlpEventroomsDetails.Controls.Add(this.txtEventroomDetailsValue, 1, 0);
            this.tlpEventroomsDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpEventroomsDetails.Location = new System.Drawing.Point(3, 38);
            this.tlpEventroomsDetails.Name = "tlpEventroomsDetails";
            this.tlpEventroomsDetails.RowCount = 1;
            this.tlpEventroomsDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEventroomsDetails.Size = new System.Drawing.Size(774, 96);
            this.tlpEventroomsDetails.TabIndex = 0;
            // 
            // lblEventroomsDetails
            // 
            this.lblEventroomsDetails.AutoSize = true;
            this.lblEventroomsDetails.Location = new System.Drawing.Point(3, 0);
            this.lblEventroomsDetails.Name = "lblEventroomsDetails";
            this.lblEventroomsDetails.Size = new System.Drawing.Size(63, 20);
            this.lblEventroomsDetails.TabIndex = 0;
            this.lblEventroomsDetails.Text = "Detalles";
            // 
            // txtEventroomDetailsValue
            // 
            this.txtEventroomDetailsValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEventroomDetailsValue.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtEventroomDetailsValue.Location = new System.Drawing.Point(83, 3);
            this.txtEventroomDetailsValue.MaxLength = 1000;
            this.txtEventroomDetailsValue.Multiline = true;
            this.txtEventroomDetailsValue.Name = "txtEventroomDetailsValue";
            this.txtEventroomDetailsValue.Size = new System.Drawing.Size(688, 90);
            this.txtEventroomDetailsValue.TabIndex = 1;
            // 
            // lblSelectedEventroomDetailValue
            // 
            this.lblSelectedEventroomDetailValue.AutoSize = true;
            this.lblSelectedEventroomDetailValue.Location = new System.Drawing.Point(3, 0);
            this.lblSelectedEventroomDetailValue.Name = "lblSelectedEventroomDetailValue";
            this.lblSelectedEventroomDetailValue.Size = new System.Drawing.Size(231, 20);
            this.lblSelectedEventroomDetailValue.TabIndex = 1;
            this.lblSelectedEventroomDetailValue.Text = "lblSelectedEventroomDetailValue";
            // 
            // tlpSearchResultEventrooms
            // 
            this.tlpSearchResultEventrooms.ColumnCount = 2;
            this.tlpSearchResultEventrooms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.67939F));
            this.tlpSearchResultEventrooms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.32061F));
            this.tlpSearchResultEventrooms.Controls.Add(this.dgvEventrooms, 0, 0);
            this.tlpSearchResultEventrooms.Controls.Add(this.button1, 1, 0);
            this.tlpSearchResultEventrooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpSearchResultEventrooms.Location = new System.Drawing.Point(3, 89);
            this.tlpSearchResultEventrooms.Name = "tlpSearchResultEventrooms";
            this.tlpSearchResultEventrooms.RowCount = 1;
            this.tlpSearchResultEventrooms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSearchResultEventrooms.Size = new System.Drawing.Size(786, 125);
            this.tlpSearchResultEventrooms.TabIndex = 2;
            // 
            // dgvEventrooms
            // 
            this.dgvEventrooms.AllowUserToAddRows = false;
            this.dgvEventrooms.AllowUserToDeleteRows = false;
            this.dgvEventrooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventrooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.EventRoomColumnName,
            this.dgvERCCapacity,
            this.dgvERCBucket,
            this.dgvERCPrice});
            this.dgvEventrooms.Location = new System.Drawing.Point(3, 3);
            this.dgvEventrooms.MultiSelect = false;
            this.dgvEventrooms.Name = "dgvEventrooms";
            this.dgvEventrooms.ReadOnly = true;
            this.dgvEventrooms.RowHeadersWidth = 51;
            this.dgvEventrooms.RowTemplate.Height = 29;
            this.dgvEventrooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEventrooms.Size = new System.Drawing.Size(636, 119);
            this.dgvEventrooms.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 70;
            // 
            // EventRoomColumnName
            // 
            this.EventRoomColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EventRoomColumnName.DataPropertyName = "Name";
            this.EventRoomColumnName.HeaderText = "Nombre";
            this.EventRoomColumnName.MinimumWidth = 6;
            this.EventRoomColumnName.Name = "EventRoomColumnName";
            this.EventRoomColumnName.ReadOnly = true;
            // 
            // dgvERCCapacity
            // 
            this.dgvERCCapacity.DataPropertyName = "Capacity";
            this.dgvERCCapacity.HeaderText = "Capacidad";
            this.dgvERCCapacity.MinimumWidth = 6;
            this.dgvERCCapacity.Name = "dgvERCCapacity";
            this.dgvERCCapacity.ReadOnly = true;
            this.dgvERCCapacity.Width = 85;
            // 
            // dgvERCBucket
            // 
            this.dgvERCBucket.DataPropertyName = "BucketSize";
            this.dgvERCBucket.HeaderText = "Tiempo (hs)";
            this.dgvERCBucket.MinimumWidth = 6;
            this.dgvERCBucket.Name = "dgvERCBucket";
            this.dgvERCBucket.ReadOnly = true;
            this.dgvERCBucket.Width = 85;
            // 
            // dgvERCPrice
            // 
            this.dgvERCPrice.DataPropertyName = "Price";
            this.dgvERCPrice.HeaderText = "Precio";
            this.dgvERCPrice.MinimumWidth = 6;
            this.dgvERCPrice.Name = "dgvERCPrice";
            this.dgvERCPrice.ReadOnly = true;
            this.dgvERCPrice.Width = 85;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(645, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 119);
            this.button1.TabIndex = 2;
            this.button1.Tag = "btn.select";
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbxEventroomsFilters
            // 
            this.gbxEventroomsFilters.Controls.Add(this.btnSearchEventroom);
            this.gbxEventroomsFilters.Controls.Add(this.tableLayoutPanel3);
            this.gbxEventroomsFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxEventroomsFilters.Location = new System.Drawing.Point(3, 3);
            this.gbxEventroomsFilters.Name = "gbxEventroomsFilters";
            this.gbxEventroomsFilters.Size = new System.Drawing.Size(786, 86);
            this.gbxEventroomsFilters.TabIndex = 0;
            this.gbxEventroomsFilters.TabStop = false;
            this.gbxEventroomsFilters.Text = "Filtros";
            // 
            // btnSearchEventroom
            // 
            this.btnSearchEventroom.Location = new System.Drawing.Point(645, 20);
            this.btnSearchEventroom.Name = "btnSearchEventroom";
            this.btnSearchEventroom.Size = new System.Drawing.Size(135, 60);
            this.btnSearchEventroom.TabIndex = 3;
            this.btnSearchEventroom.Tag = "btn.search";
            this.btnSearchEventroom.Text = "Buscar";
            this.btnSearchEventroom.UseVisualStyleBackColor = true;
            this.btnSearchEventroom.Click += new System.EventHandler(this.btnSearchEventroom_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.95812F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.04188F));
            this.tableLayoutPanel3.Controls.Add(this.txtFilterEventroomName, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblFilterPlaceName, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtFilterEventroomId, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(13, 19);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(626, 61);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // txtFilterEventroomName
            // 
            this.txtFilterEventroomName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFilterEventroomName.Location = new System.Drawing.Point(159, 33);
            this.txtFilterEventroomName.Name = "txtFilterEventroomName";
            this.txtFilterEventroomName.Size = new System.Drawing.Size(464, 27);
            this.txtFilterEventroomName.TabIndex = 2;
            this.txtFilterEventroomName.Tag = "eventroom.name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Codigo lugar";
            // 
            // lblFilterPlaceName
            // 
            this.lblFilterPlaceName.AutoSize = true;
            this.lblFilterPlaceName.Location = new System.Drawing.Point(159, 0);
            this.lblFilterPlaceName.Name = "lblFilterPlaceName";
            this.lblFilterPlaceName.Size = new System.Drawing.Size(64, 20);
            this.lblFilterPlaceName.TabIndex = 1;
            this.lblFilterPlaceName.Text = "Nombre";
            // 
            // txtFilterEventroomId
            // 
            this.txtFilterEventroomId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFilterEventroomId.Location = new System.Drawing.Point(3, 33);
            this.txtFilterEventroomId.Name = "txtFilterEventroomId";
            this.txtFilterEventroomId.Size = new System.Drawing.Size(150, 27);
            this.txtFilterEventroomId.TabIndex = 1;
            // 
            // tabAditionalServices
            // 
            this.tabAditionalServices.Controls.Add(this.tlpASDetails);
            this.tabAditionalServices.Controls.Add(this.tlpAditionalServicesFilters);
            this.tabAditionalServices.Location = new System.Drawing.Point(4, 29);
            this.tabAditionalServices.Name = "tabAditionalServices";
            this.tabAditionalServices.Padding = new System.Windows.Forms.Padding(3);
            this.tabAditionalServices.Size = new System.Drawing.Size(792, 425);
            this.tabAditionalServices.TabIndex = 2;
            this.tabAditionalServices.Tag = "tab.aditionalServices";
            this.tabAditionalServices.Text = "Servicios adicionales";
            this.tabAditionalServices.UseVisualStyleBackColor = true;
            // 
            // tlpASDetails
            // 
            this.tlpASDetails.ColumnCount = 4;
            this.tlpASDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tlpASDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 419F));
            this.tlpASDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tlpASDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tlpASDetails.Controls.Add(this.lblDetalle, 0, 0);
            this.tlpASDetails.Controls.Add(this.txtASDetails, 1, 0);
            this.tlpASDetails.Controls.Add(this.tableLayoutPanel4, 3, 0);
            this.tlpASDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpASDetails.Location = new System.Drawing.Point(3, 338);
            this.tlpASDetails.Name = "tlpASDetails";
            this.tlpASDetails.RowCount = 1;
            this.tlpASDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpASDetails.Size = new System.Drawing.Size(786, 82);
            this.tlpASDetails.TabIndex = 1;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(3, 0);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(57, 20);
            this.lblDetalle.TabIndex = 0;
            this.lblDetalle.Tag = "detail.title";
            this.lblDetalle.Text = "Detalle";
            // 
            // txtASDetails
            // 
            this.txtASDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtASDetails.Location = new System.Drawing.Point(74, 3);
            this.txtASDetails.Multiline = true;
            this.txtASDetails.Name = "txtASDetails";
            this.txtASDetails.Size = new System.Drawing.Size(413, 76);
            this.txtASDetails.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.txtASQty, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblASQty, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(569, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(214, 76);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // txtASQty
            // 
            this.txtASQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtASQty.Location = new System.Drawing.Point(3, 33);
            this.txtASQty.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.txtASQty.Name = "txtASQty";
            this.txtASQty.Size = new System.Drawing.Size(208, 27);
            this.txtASQty.TabIndex = 3;
            this.txtASQty.ValueChanged += new System.EventHandler(this.txtASQty_ValueChanged);
            // 
            // lblASQty
            // 
            this.lblASQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblASQty.AutoSize = true;
            this.lblASQty.Location = new System.Drawing.Point(3, 10);
            this.lblASQty.Name = "lblASQty";
            this.lblASQty.Size = new System.Drawing.Size(69, 20);
            this.lblASQty.TabIndex = 4;
            this.lblASQty.Tag = "quantity.title";
            this.lblASQty.Text = "Cantidad";
            // 
            // tlpAditionalServicesFilters
            // 
            this.tlpAditionalServicesFilters.ColumnCount = 2;
            this.tlpAditionalServicesFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.15267F));
            this.tlpAditionalServicesFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.84733F));
            this.tlpAditionalServicesFilters.Controls.Add(this.panelFilterASName, 0, 0);
            this.tlpAditionalServicesFilters.Controls.Add(this.btnSearchAS, 1, 0);
            this.tlpAditionalServicesFilters.Controls.Add(this.btnAddAS, 1, 1);
            this.tlpAditionalServicesFilters.Controls.Add(this.dgvSearchAS, 0, 1);
            this.tlpAditionalServicesFilters.Controls.Add(this.dgvAddedServices, 0, 4);
            this.tlpAditionalServicesFilters.Controls.Add(this.btnASRemove, 1, 4);
            this.tlpAditionalServicesFilters.Controls.Add(this.lblASAdded, 0, 3);
            this.tlpAditionalServicesFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpAditionalServicesFilters.Location = new System.Drawing.Point(3, 3);
            this.tlpAditionalServicesFilters.Name = "tlpAditionalServicesFilters";
            this.tlpAditionalServicesFilters.RowCount = 5;
            this.tlpAditionalServicesFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpAditionalServicesFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tlpAditionalServicesFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpAditionalServicesFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAditionalServicesFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAditionalServicesFilters.Size = new System.Drawing.Size(786, 335);
            this.tlpAditionalServicesFilters.TabIndex = 0;
            // 
            // panelFilterASName
            // 
            this.panelFilterASName.Controls.Add(this.txtFilterASName);
            this.panelFilterASName.Controls.Add(this.lblFilterASName);
            this.panelFilterASName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFilterASName.Location = new System.Drawing.Point(3, 3);
            this.panelFilterASName.Name = "panelFilterASName";
            this.panelFilterASName.Size = new System.Drawing.Size(624, 24);
            this.panelFilterASName.TabIndex = 0;
            // 
            // txtFilterASName
            // 
            this.txtFilterASName.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtFilterASName.Location = new System.Drawing.Point(99, 0);
            this.txtFilterASName.Name = "txtFilterASName";
            this.txtFilterASName.Size = new System.Drawing.Size(525, 27);
            this.txtFilterASName.TabIndex = 1;
            // 
            // lblFilterASName
            // 
            this.lblFilterASName.AutoSize = true;
            this.lblFilterASName.Location = new System.Drawing.Point(5, 6);
            this.lblFilterASName.Name = "lblFilterASName";
            this.lblFilterASName.Size = new System.Drawing.Size(64, 20);
            this.lblFilterASName.TabIndex = 0;
            this.lblFilterASName.Tag = "aditionalservice.name.Title";
            this.lblFilterASName.Text = "Nombre";
            // 
            // btnSearchAS
            // 
            this.btnSearchAS.Location = new System.Drawing.Point(633, 3);
            this.btnSearchAS.Name = "btnSearchAS";
            this.btnSearchAS.Size = new System.Drawing.Size(148, 24);
            this.btnSearchAS.TabIndex = 1;
            this.btnSearchAS.Tag = "btn.search";
            this.btnSearchAS.Text = "Buscar";
            this.btnSearchAS.UseVisualStyleBackColor = true;
            this.btnSearchAS.Click += new System.EventHandler(this.btnSearchAS_Click);
            // 
            // btnAddAS
            // 
            this.btnAddAS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAS.Location = new System.Drawing.Point(633, 123);
            this.btnAddAS.Name = "btnAddAS";
            this.btnAddAS.Size = new System.Drawing.Size(150, 29);
            this.btnAddAS.TabIndex = 3;
            this.btnAddAS.Tag = "btn.add";
            this.btnAddAS.Text = "Agregar";
            this.btnAddAS.UseVisualStyleBackColor = true;
            this.btnAddAS.Click += new System.EventHandler(this.btnAddAS_Click);
            // 
            // dgvSearchAS
            // 
            this.dgvSearchAS.AllowUserToAddRows = false;
            this.dgvSearchAS.AllowUserToDeleteRows = false;
            this.dgvSearchAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchAS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvASFilterCId,
            this.dgvASFilterCName,
            this.dgvASFilterCPrice});
            this.dgvSearchAS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSearchAS.Location = new System.Drawing.Point(3, 33);
            this.dgvSearchAS.MultiSelect = false;
            this.dgvSearchAS.Name = "dgvSearchAS";
            this.dgvSearchAS.ReadOnly = true;
            this.dgvSearchAS.RowHeadersWidth = 51;
            this.dgvSearchAS.RowTemplate.Height = 29;
            this.dgvSearchAS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchAS.Size = new System.Drawing.Size(624, 119);
            this.dgvSearchAS.TabIndex = 2;
            // 
            // dgvASFilterCId
            // 
            this.dgvASFilterCId.DataPropertyName = "Id";
            this.dgvASFilterCId.HeaderText = "Id";
            this.dgvASFilterCId.MinimumWidth = 6;
            this.dgvASFilterCId.Name = "dgvASFilterCId";
            this.dgvASFilterCId.ReadOnly = true;
            this.dgvASFilterCId.Width = 80;
            // 
            // dgvASFilterCName
            // 
            this.dgvASFilterCName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvASFilterCName.DataPropertyName = "Name";
            this.dgvASFilterCName.HeaderText = "Nombre";
            this.dgvASFilterCName.MinimumWidth = 6;
            this.dgvASFilterCName.Name = "dgvASFilterCName";
            this.dgvASFilterCName.ReadOnly = true;
            // 
            // dgvASFilterCPrice
            // 
            this.dgvASFilterCPrice.DataPropertyName = "Price";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dgvASFilterCPrice.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvASFilterCPrice.HeaderText = "Precio";
            this.dgvASFilterCPrice.MinimumWidth = 6;
            this.dgvASFilterCPrice.Name = "dgvASFilterCPrice";
            this.dgvASFilterCPrice.ReadOnly = true;
            this.dgvASFilterCPrice.Width = 125;
            // 
            // dgvAddedServices
            // 
            this.dgvAddedServices.AllowUserToAddRows = false;
            this.dgvAddedServices.AllowUserToDeleteRows = false;
            this.dgvAddedServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddedServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvASCId,
            this.dgvASCName,
            this.dgvASCQty,
            this.dgvASCPrice,
            this.dgvASCTotal});
            this.dgvAddedServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAddedServices.Location = new System.Drawing.Point(3, 188);
            this.dgvAddedServices.Name = "dgvAddedServices";
            this.dgvAddedServices.ReadOnly = true;
            this.dgvAddedServices.RowHeadersWidth = 51;
            this.dgvAddedServices.RowTemplate.Height = 29;
            this.dgvAddedServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddedServices.Size = new System.Drawing.Size(624, 144);
            this.dgvAddedServices.TabIndex = 4;
            this.dgvAddedServices.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAddedServices_CellFormatting);
            this.dgvAddedServices.SelectionChanged += new System.EventHandler(this.dgvAddedServices_SelectionChanged);
            // 
            // dgvASCId
            // 
            this.dgvASCId.DataPropertyName = "Service.Id";
            this.dgvASCId.HeaderText = "Id";
            this.dgvASCId.MinimumWidth = 6;
            this.dgvASCId.Name = "dgvASCId";
            this.dgvASCId.ReadOnly = true;
            this.dgvASCId.Width = 80;
            // 
            // dgvASCName
            // 
            this.dgvASCName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvASCName.DataPropertyName = "Service.Name";
            this.dgvASCName.HeaderText = "Nombre";
            this.dgvASCName.MinimumWidth = 6;
            this.dgvASCName.Name = "dgvASCName";
            this.dgvASCName.ReadOnly = true;
            // 
            // dgvASCQty
            // 
            this.dgvASCQty.DataPropertyName = "Quantity";
            this.dgvASCQty.HeaderText = "Cantidad";
            this.dgvASCQty.MinimumWidth = 6;
            this.dgvASCQty.Name = "dgvASCQty";
            this.dgvASCQty.ReadOnly = true;
            this.dgvASCQty.Width = 40;
            // 
            // dgvASCPrice
            // 
            this.dgvASCPrice.DataPropertyName = "Price";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.dgvASCPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvASCPrice.HeaderText = "Price";
            this.dgvASCPrice.MinimumWidth = 6;
            this.dgvASCPrice.Name = "dgvASCPrice";
            this.dgvASCPrice.ReadOnly = true;
            this.dgvASCPrice.Width = 80;
            // 
            // dgvASCTotal
            // 
            this.dgvASCTotal.DataPropertyName = "Status";
            this.dgvASCTotal.HeaderText = "Estado";
            this.dgvASCTotal.MinimumWidth = 6;
            this.dgvASCTotal.Name = "dgvASCTotal";
            this.dgvASCTotal.ReadOnly = true;
            this.dgvASCTotal.Width = 125;
            // 
            // btnASRemove
            // 
            this.btnASRemove.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnASRemove.Location = new System.Drawing.Point(633, 303);
            this.btnASRemove.Name = "btnASRemove";
            this.btnASRemove.Size = new System.Drawing.Size(150, 29);
            this.btnASRemove.TabIndex = 5;
            this.btnASRemove.Tag = "btn.remove";
            this.btnASRemove.Text = "Eliminar";
            this.btnASRemove.UseVisualStyleBackColor = true;
            this.btnASRemove.Click += new System.EventHandler(this.btnASRemove_Click);
            // 
            // lblASAdded
            // 
            this.lblASAdded.AutoSize = true;
            this.lblASAdded.Location = new System.Drawing.Point(3, 165);
            this.lblASAdded.Name = "lblASAdded";
            this.lblASAdded.Size = new System.Drawing.Size(150, 20);
            this.lblASAdded.TabIndex = 6;
            this.lblASAdded.Tag = "as.addedservices";
            this.lblASAdded.Text = "Servicios contratados";
            // 
            // tabPagos
            // 
            this.tabPagos.Controls.Add(this.tlpPayments);
            this.tabPagos.Location = new System.Drawing.Point(4, 29);
            this.tabPagos.Name = "tabPagos";
            this.tabPagos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagos.Size = new System.Drawing.Size(792, 425);
            this.tabPagos.TabIndex = 3;
            this.tabPagos.Tag = "payments.title";
            this.tabPagos.Text = "Pagos";
            this.tabPagos.UseVisualStyleBackColor = true;
            // 
            // tlpPayments
            // 
            this.tlpPayments.ColumnCount = 1;
            this.tlpPayments.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPayments.Controls.Add(this.lblPayments, 0, 0);
            this.tlpPayments.Controls.Add(this.label4, 0, 3);
            this.tlpPayments.Controls.Add(this.tlpListOfPayments, 0, 1);
            this.tlpPayments.Controls.Add(this.tlpNewPayment, 0, 4);
            this.tlpPayments.Controls.Add(this.btnDeleteSelectedPayment, 0, 2);
            this.tlpPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPayments.Location = new System.Drawing.Point(3, 3);
            this.tlpPayments.Name = "tlpPayments";
            this.tlpPayments.RowCount = 5;
            this.tlpPayments.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPayments.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tlpPayments.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpPayments.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tlpPayments.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tlpPayments.Size = new System.Drawing.Size(786, 419);
            this.tlpPayments.TabIndex = 0;
            // 
            // lblPayments
            // 
            this.lblPayments.AutoSize = true;
            this.lblPayments.Location = new System.Drawing.Point(3, 0);
            this.lblPayments.Name = "lblPayments";
            this.lblPayments.Size = new System.Drawing.Size(124, 20);
            this.lblPayments.TabIndex = 0;
            this.lblPayments.Tag = "payments.registered";
            this.lblPayments.Text = "Pagos Realizados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Registrar nuevo pago";
            // 
            // tlpListOfPayments
            // 
            this.tlpListOfPayments.ColumnCount = 1;
            this.tlpListOfPayments.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.97436F));
            this.tlpListOfPayments.Controls.Add(this.dgvPayments, 0, 0);
            this.tlpListOfPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpListOfPayments.Location = new System.Drawing.Point(3, 33);
            this.tlpListOfPayments.Name = "tlpListOfPayments";
            this.tlpListOfPayments.RowCount = 1;
            this.tlpListOfPayments.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpListOfPayments.Size = new System.Drawing.Size(780, 104);
            this.tlpListOfPayments.TabIndex = 4;
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvPaymentsCId,
            this.dgvPaymentsCType,
            this.dgvPaymentsCDate,
            this.dgvPaymentsCConciliationKey,
            this.dgvPaymentsCAmount});
            this.dgvPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPayments.Location = new System.Drawing.Point(3, 3);
            this.dgvPayments.MultiSelect = false;
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowHeadersWidth = 51;
            this.dgvPayments.RowTemplate.Height = 29;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(774, 98);
            this.dgvPayments.TabIndex = 0;
            this.dgvPayments.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPayments_CellFormatting);
            this.dgvPayments.SelectionChanged += new System.EventHandler(this.dgvPayments_SelectionChanged);
            // 
            // dgvPaymentsCId
            // 
            this.dgvPaymentsCId.HeaderText = "#";
            this.dgvPaymentsCId.MinimumWidth = 6;
            this.dgvPaymentsCId.Name = "dgvPaymentsCId";
            this.dgvPaymentsCId.ReadOnly = true;
            this.dgvPaymentsCId.Width = 45;
            // 
            // dgvPaymentsCType
            // 
            this.dgvPaymentsCType.HeaderText = "Tipo";
            this.dgvPaymentsCType.MinimumWidth = 6;
            this.dgvPaymentsCType.Name = "dgvPaymentsCType";
            this.dgvPaymentsCType.ReadOnly = true;
            this.dgvPaymentsCType.Width = 60;
            // 
            // dgvPaymentsCDate
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dgvPaymentsCDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPaymentsCDate.HeaderText = "Fecha";
            this.dgvPaymentsCDate.MinimumWidth = 6;
            this.dgvPaymentsCDate.Name = "dgvPaymentsCDate";
            this.dgvPaymentsCDate.ReadOnly = true;
            this.dgvPaymentsCDate.Width = 80;
            // 
            // dgvPaymentsCConciliationKey
            // 
            this.dgvPaymentsCConciliationKey.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvPaymentsCConciliationKey.HeaderText = "Conciliación";
            this.dgvPaymentsCConciliationKey.MinimumWidth = 6;
            this.dgvPaymentsCConciliationKey.Name = "dgvPaymentsCConciliationKey";
            this.dgvPaymentsCConciliationKey.ReadOnly = true;
            // 
            // dgvPaymentsCAmount
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.dgvPaymentsCAmount.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPaymentsCAmount.HeaderText = "Amount";
            this.dgvPaymentsCAmount.MinimumWidth = 6;
            this.dgvPaymentsCAmount.Name = "dgvPaymentsCAmount";
            this.dgvPaymentsCAmount.ReadOnly = true;
            this.dgvPaymentsCAmount.Width = 80;
            // 
            // tlpNewPayment
            // 
            this.tlpNewPayment.ColumnCount = 5;
            this.tlpNewPayment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tlpNewPayment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tlpNewPayment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 297F));
            this.tlpNewPayment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tlpNewPayment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tlpNewPayment.Controls.Add(this.lblType, 0, 0);
            this.tlpNewPayment.Controls.Add(this.lblPaymentAmount, 1, 0);
            this.tlpNewPayment.Controls.Add(this.label5, 2, 0);
            this.tlpNewPayment.Controls.Add(this.lblPaymentDate, 3, 0);
            this.tlpNewPayment.Controls.Add(this.cbxNewPaymentType, 0, 1);
            this.tlpNewPayment.Controls.Add(this.txtNewPaymentAmount, 1, 1);
            this.tlpNewPayment.Controls.Add(this.txtConciliationKey, 2, 1);
            this.tlpNewPayment.Controls.Add(this.dtpNewPaymentDate, 3, 1);
            this.tlpNewPayment.Controls.Add(this.btnAddNewPayment, 4, 1);
            this.tlpNewPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNewPayment.Location = new System.Drawing.Point(3, 197);
            this.tlpNewPayment.Name = "tlpNewPayment";
            this.tlpNewPayment.RowCount = 2;
            this.tlpNewPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.03297F));
            this.tlpNewPayment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.96703F));
            this.tlpNewPayment.Size = new System.Drawing.Size(780, 219);
            this.tlpNewPayment.TabIndex = 5;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(3, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(39, 20);
            this.lblType.TabIndex = 0;
            this.lblType.Tag = "type.title";
            this.lblType.Text = "Tipo";
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.AutoSize = true;
            this.lblPaymentAmount.Location = new System.Drawing.Point(137, 0);
            this.lblPaymentAmount.Name = "lblPaymentAmount";
            this.lblPaymentAmount.Size = new System.Drawing.Size(53, 20);
            this.lblPaymentAmount.TabIndex = 1;
            this.lblPaymentAmount.Text = "Monto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Conciliación";
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Location = new System.Drawing.Point(539, 0);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(109, 20);
            this.lblPaymentDate.TabIndex = 3;
            this.lblPaymentDate.Tag = "payment.date";
            this.lblPaymentDate.Text = "Fecha del Pago";
            // 
            // cbxNewPaymentType
            // 
            this.cbxNewPaymentType.DisplayMember = "Text";
            this.cbxNewPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNewPaymentType.ForeColor = System.Drawing.SystemColors.Window;
            this.cbxNewPaymentType.Location = new System.Drawing.Point(3, 40);
            this.cbxNewPaymentType.Name = "cbxNewPaymentType";
            this.cbxNewPaymentType.Size = new System.Drawing.Size(128, 28);
            this.cbxNewPaymentType.TabIndex = 4;
            this.cbxNewPaymentType.ValueMember = "Value";
            // 
            // txtNewPaymentAmount
            // 
            this.txtNewPaymentAmount.Location = new System.Drawing.Point(137, 40);
            this.txtNewPaymentAmount.Maximum = new decimal(new int[] {
            600000,
            0,
            0,
            0});
            this.txtNewPaymentAmount.Name = "txtNewPaymentAmount";
            this.txtNewPaymentAmount.Size = new System.Drawing.Size(99, 27);
            this.txtNewPaymentAmount.TabIndex = 5;
            this.txtNewPaymentAmount.ValueChanged += new System.EventHandler(this.txtNewPaymentAmount_ValueChanged);
            // 
            // txtConciliationKey
            // 
            this.txtConciliationKey.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtConciliationKey.Location = new System.Drawing.Point(242, 40);
            this.txtConciliationKey.MaxLength = 255;
            this.txtConciliationKey.Name = "txtConciliationKey";
            this.txtConciliationKey.Size = new System.Drawing.Size(291, 27);
            this.txtConciliationKey.TabIndex = 6;
            this.txtConciliationKey.Tag = "conciliation";
            // 
            // dtpNewPaymentDate
            // 
            this.dtpNewPaymentDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpNewPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNewPaymentDate.Location = new System.Drawing.Point(539, 40);
            this.dtpNewPaymentDate.Name = "dtpNewPaymentDate";
            this.dtpNewPaymentDate.Size = new System.Drawing.Size(159, 27);
            this.dtpNewPaymentDate.TabIndex = 7;
            // 
            // btnAddNewPayment
            // 
            this.btnAddNewPayment.Enabled = false;
            this.btnAddNewPayment.Location = new System.Drawing.Point(704, 40);
            this.btnAddNewPayment.Name = "btnAddNewPayment";
            this.btnAddNewPayment.Size = new System.Drawing.Size(73, 29);
            this.btnAddNewPayment.TabIndex = 8;
            this.btnAddNewPayment.Tag = "btn.add";
            this.btnAddNewPayment.Text = "Agregar";
            this.btnAddNewPayment.UseVisualStyleBackColor = true;
            this.btnAddNewPayment.Click += new System.EventHandler(this.btnAddNewPayment_Click);
            // 
            // btnDeleteSelectedPayment
            // 
            this.btnDeleteSelectedPayment.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDeleteSelectedPayment.Location = new System.Drawing.Point(594, 143);
            this.btnDeleteSelectedPayment.Name = "btnDeleteSelectedPayment";
            this.btnDeleteSelectedPayment.Size = new System.Drawing.Size(189, 29);
            this.btnDeleteSelectedPayment.TabIndex = 6;
            this.btnDeleteSelectedPayment.Text = "Borrar seleccionado";
            this.btnDeleteSelectedPayment.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedPayment.Click += new System.EventHandler(this.btnDeleteSelectedPayment_Click);
            // 
            // totalAmountsLP
            // 
            this.totalAmountsLP.ColumnCount = 2;
            this.totalAmountsLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.totalAmountsLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.totalAmountsLP.Controls.Add(this.lblPaidValue, 1, 1);
            this.totalAmountsLP.Controls.Add(this.lblTotal, 0, 0);
            this.totalAmountsLP.Controls.Add(this.lblPaid, 0, 1);
            this.totalAmountsLP.Controls.Add(this.lblPendingPayment, 0, 2);
            this.totalAmountsLP.Controls.Add(this.lblTotalValue, 1, 0);
            this.totalAmountsLP.Controls.Add(this.lblPendingPayValue, 1, 2);
            this.totalAmountsLP.Location = new System.Drawing.Point(550, 509);
            this.totalAmountsLP.Name = "totalAmountsLP";
            this.totalAmountsLP.RowCount = 3;
            this.totalAmountsLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.totalAmountsLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.totalAmountsLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.totalAmountsLP.Size = new System.Drawing.Size(250, 125);
            this.totalAmountsLP.TabIndex = 1;
            // 
            // lblPaidValue
            // 
            this.lblPaidValue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPaidValue.AutoSize = true;
            this.lblPaidValue.Location = new System.Drawing.Point(247, 51);
            this.lblPaidValue.Name = "lblPaidValue";
            this.lblPaidValue.Size = new System.Drawing.Size(0, 20);
            this.lblPaidValue.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(80, 10);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 20);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Tag = "total.title";
            this.lblTotal.Text = "Total";
            // 
            // lblPaid
            // 
            this.lblPaid.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPaid.AutoSize = true;
            this.lblPaid.Location = new System.Drawing.Point(51, 51);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(71, 20);
            this.lblPaid.TabIndex = 1;
            this.lblPaid.Tag = "paid.title";
            this.lblPaid.Text = "Abonado";
            // 
            // lblPendingPayment
            // 
            this.lblPendingPayment.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPendingPayment.AutoSize = true;
            this.lblPendingPayment.Location = new System.Drawing.Point(48, 93);
            this.lblPendingPayment.Name = "lblPendingPayment";
            this.lblPendingPayment.Size = new System.Drawing.Size(74, 20);
            this.lblPendingPayment.TabIndex = 2;
            this.lblPendingPayment.Tag = "pendingtopay.title";
            this.lblPendingPayment.Text = "Pendiente";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Location = new System.Drawing.Point(247, 10);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(0, 20);
            this.lblTotalValue.TabIndex = 3;
            // 
            // lblPendingPayValue
            // 
            this.lblPendingPayValue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPendingPayValue.AutoSize = true;
            this.lblPendingPayValue.Location = new System.Drawing.Point(247, 93);
            this.lblPendingPayValue.Name = "lblPendingPayValue";
            this.lblPendingPayValue.Size = new System.Drawing.Size(0, 20);
            this.lblPendingPayValue.TabIndex = 4;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(434, 509);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(111, 123);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Tag = "btn.save";
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(5, 511);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 123);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Tag = "btn.close";
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnApproveEvent
            // 
            this.btnApproveEvent.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnApproveEvent.Location = new System.Drawing.Point(199, 509);
            this.btnApproveEvent.Name = "btnApproveEvent";
            this.btnApproveEvent.Size = new System.Drawing.Size(111, 123);
            this.btnApproveEvent.TabIndex = 4;
            this.btnApproveEvent.Tag = "btn.approveevent";
            this.btnApproveEvent.Text = "Aprobar y Organizar";
            this.btnApproveEvent.UseVisualStyleBackColor = true;
            this.btnApproveEvent.Visible = false;
            this.btnApproveEvent.Click += new System.EventHandler(this.btnApproveEvent_Click);
            // 
            // btnMakeBudget
            // 
            this.btnMakeBudget.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMakeBudget.Location = new System.Drawing.Point(317, 509);
            this.btnMakeBudget.Name = "btnMakeBudget";
            this.btnMakeBudget.Size = new System.Drawing.Size(111, 123);
            this.btnMakeBudget.TabIndex = 5;
            this.btnMakeBudget.Tag = "btn.makebudget";
            this.btnMakeBudget.Text = "Presupuestar";
            this.btnMakeBudget.UseVisualStyleBackColor = true;
            this.btnMakeBudget.Visible = false;
            this.btnMakeBudget.Click += new System.EventHandler(this.btnMakeBudget_Click);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(800, 642);
            this.Controls.Add(this.btnMakeBudget);
            this.Controls.Add(this.btnApproveEvent);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.totalAmountsLP);
            this.Controls.Add(this.tabEventDetails);
            this.Name = "EventForm";
            this.Tag = "eventform.title";
            this.Text = "Evento";
            this.Load += new System.EventHandler(this.EventForm_Load);
            this.tabEventDetails.ResumeLayout(false);
            this.tabCharacteristics.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBudgetMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBudgetMin)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGuessQty)).EndInit();
            this.tabLugares.ResumeLayout(false);
            this.gbxEventroomsDetails.ResumeLayout(false);
            this.tblEventroomsMainDetail.ResumeLayout(false);
            this.tblEventroomsMainDetail.PerformLayout();
            this.tlpEventroomsDetails.ResumeLayout(false);
            this.tlpEventroomsDetails.PerformLayout();
            this.tlpSearchResultEventrooms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventrooms)).EndInit();
            this.gbxEventroomsFilters.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabAditionalServices.ResumeLayout(false);
            this.tlpASDetails.ResumeLayout(false);
            this.tlpASDetails.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtASQty)).EndInit();
            this.tlpAditionalServicesFilters.ResumeLayout(false);
            this.tlpAditionalServicesFilters.PerformLayout();
            this.panelFilterASName.ResumeLayout(false);
            this.panelFilterASName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddedServices)).EndInit();
            this.tabPagos.ResumeLayout(false);
            this.tlpPayments.ResumeLayout(false);
            this.tlpPayments.PerformLayout();
            this.tlpListOfPayments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.tlpNewPayment.ResumeLayout(false);
            this.tlpNewPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPaymentAmount)).EndInit();
            this.totalAmountsLP.ResumeLayout(false);
            this.totalAmountsLP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEventDetails;
        private System.Windows.Forms.TabPage tabCharacteristics;
        private System.Windows.Forms.TabPage tabLugares;
        private System.Windows.Forms.TabPage tabAditionalServices;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblSpecialRequests;
        private System.Windows.Forms.Label lblBudget;
        
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.Label lblEventType;
        private System.Windows.Forms.TextBox txtEventDescription;
        private System.Windows.Forms.TextBox txtEventTitle;
        private System.Windows.Forms.TextBox txtSpecialRequest;
        private System.Windows.Forms.NumericUpDown txtBudgetMax;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown txtBudgetMin;
        private System.Windows.Forms.Label lblMinus;
        private System.Windows.Forms.TableLayoutPanel totalAmountsLP;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPaidValue;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Label lblPendingPayment;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblPendingPayValue;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPagos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.NumericUpDown txtGuessQty;
        private System.Windows.Forms.GroupBox gbxEventroomsDetails;
        private System.Windows.Forms.TableLayoutPanel tlpSearchResultEventrooms;
        private System.Windows.Forms.DataGridView dgvEventrooms;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbxEventroomsFilters;
        private System.Windows.Forms.Button btnSearchEventroom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtFilterEventroomName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFilterPlaceName;
        private System.Windows.Forms.TextBox txtFilterEventroomId;
        private System.Windows.Forms.TableLayoutPanel tblEventroomsMainDetail;
        private System.Windows.Forms.TableLayoutPanel tlpEventroomsDetails;
        private System.Windows.Forms.Label lblEventroomsDetails;
        private System.Windows.Forms.TextBox txtEventroomDetailsValue;
        private System.Windows.Forms.Label lblSelectedEventroomDetailValue;
        private System.Windows.Forms.TableLayoutPanel tlpAditionalServicesFilters;
        private System.Windows.Forms.TableLayoutPanel tlpASDetails;
        private System.Windows.Forms.NumericUpDown txtASQty;
        private System.Windows.Forms.Panel panelFilterASName;
        private System.Windows.Forms.TextBox txtFilterASName;
        private System.Windows.Forms.Label lblFilterASName;
        private System.Windows.Forms.Button btnSearchAS;
        private System.Windows.Forms.DataGridView dgvSearchAS;
        private System.Windows.Forms.Button btnAddAS;
        private System.Windows.Forms.DataGridView dgvAddedServices;
        private System.Windows.Forms.Button btnASRemove;
        private System.Windows.Forms.Label lblASAdded;
        private System.Windows.Forms.TableLayoutPanel tlpPayments;
        private System.Windows.Forms.Label lblPayments;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tlpListOfPayments;
        private System.Windows.Forms.TableLayoutPanel tlpNewPayment;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblPaymentAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.ComboBox cbxNewPaymentType;
        private System.Windows.Forms.NumericUpDown txtNewPaymentAmount;
        private System.Windows.Forms.TextBox txtConciliationKey;
        private System.Windows.Forms.DateTimePicker dtpNewPaymentDate;
        private System.Windows.Forms.Button btnAddNewPayment;
        private System.Windows.Forms.ComboBox cmbEventType;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.TextBox txtASDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblASQty;
        private System.Windows.Forms.Button btnApproveEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventRoomColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvERCCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvERCBucket;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvERCPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvASFilterCId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvASFilterCName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvASFilterCPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvASCId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvASCName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvASCQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvASCPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvASCTotal;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPaymentsCId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPaymentsCType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPaymentsCDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPaymentsCConciliationKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPaymentsCAmount;
        private System.Windows.Forms.Button btnDeleteSelectedPayment;
        private System.Windows.Forms.Button btnMakeBudget;
    }
}