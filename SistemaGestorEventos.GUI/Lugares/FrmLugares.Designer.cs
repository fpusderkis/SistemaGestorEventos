namespace SistemaGestorEventos.GUI.Lugares
{
    partial class FrmLugares
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
            this.dgvPlaces = new System.Windows.Forms.DataGridView();
            this.dgvcId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcBucket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPlaceActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbxFilter = new System.Windows.Forms.GroupBox();
            this.tlpFilter = new System.Windows.Forms.TableLayoutPanel();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPlaceId = new System.Windows.Forms.TextBox();
            this.txtPlaceName = new System.Windows.Forms.TextBox();
            this.btnPlaceSearch = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEditPlace = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnDvv = new System.Windows.Forms.Button();
            this.btnExportToJson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaces)).BeginInit();
            this.gbxFilter.SuspendLayout();
            this.tlpFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPlaces
            // 
            this.dgvPlaces.AllowUserToAddRows = false;
            this.dgvPlaces.AllowUserToDeleteRows = false;
            this.dgvPlaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcId,
            this.dgvcName,
            this.dgvcCapacity,
            this.dgvcBucket,
            this.dgvcPrice,
            this.dgvcPlaceActive});
            this.dgvPlaces.Location = new System.Drawing.Point(12, 156);
            this.dgvPlaces.MultiSelect = false;
            this.dgvPlaces.Name = "dgvPlaces";
            this.dgvPlaces.ReadOnly = true;
            this.dgvPlaces.RowHeadersWidth = 51;
            this.dgvPlaces.RowTemplate.Height = 29;
            this.dgvPlaces.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlaces.Size = new System.Drawing.Size(658, 282);
            this.dgvPlaces.TabIndex = 0;
            this.dgvPlaces.SelectionChanged += new System.EventHandler(this.dgvPlaces_SelectionChanged);
            // 
            // dgvcId
            // 
            this.dgvcId.DataPropertyName = "Id";
            this.dgvcId.Frozen = true;
            this.dgvcId.HeaderText = "Id";
            this.dgvcId.MinimumWidth = 6;
            this.dgvcId.Name = "dgvcId";
            this.dgvcId.ReadOnly = true;
            this.dgvcId.Width = 50;
            // 
            // dgvcName
            // 
            this.dgvcName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcName.DataPropertyName = "Name";
            this.dgvcName.HeaderText = "Nombre";
            this.dgvcName.MinimumWidth = 6;
            this.dgvcName.Name = "dgvcName";
            this.dgvcName.ReadOnly = true;
            this.dgvcName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvcCapacity
            // 
            this.dgvcCapacity.DataPropertyName = "Capacity";
            this.dgvcCapacity.FillWeight = 50F;
            this.dgvcCapacity.HeaderText = "Cant.";
            this.dgvcCapacity.MinimumWidth = 6;
            this.dgvcCapacity.Name = "dgvcCapacity";
            this.dgvcCapacity.ReadOnly = true;
            this.dgvcCapacity.Width = 70;
            // 
            // dgvcBucket
            // 
            this.dgvcBucket.DataPropertyName = "BucketSize";
            this.dgvcBucket.FillWeight = 50F;
            this.dgvcBucket.HeaderText = "Tiempo";
            this.dgvcBucket.MinimumWidth = 6;
            this.dgvcBucket.Name = "dgvcBucket";
            this.dgvcBucket.ReadOnly = true;
            this.dgvcBucket.Width = 70;
            // 
            // dgvcPrice
            // 
            this.dgvcPrice.DataPropertyName = "Price";
            this.dgvcPrice.HeaderText = "Precio";
            this.dgvcPrice.MinimumWidth = 6;
            this.dgvcPrice.Name = "dgvcPrice";
            this.dgvcPrice.ReadOnly = true;
            this.dgvcPrice.Width = 70;
            // 
            // dgvcPlaceActive
            // 
            this.dgvcPlaceActive.DataPropertyName = "Active";
            this.dgvcPlaceActive.HeaderText = "A";
            this.dgvcPlaceActive.MinimumWidth = 6;
            this.dgvcPlaceActive.Name = "dgvcPlaceActive";
            this.dgvcPlaceActive.ReadOnly = true;
            this.dgvcPlaceActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcPlaceActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvcPlaceActive.Width = 25;
            // 
            // gbxFilter
            // 
            this.gbxFilter.Controls.Add(this.tlpFilter);
            this.gbxFilter.Location = new System.Drawing.Point(12, 25);
            this.gbxFilter.Name = "gbxFilter";
            this.gbxFilter.Size = new System.Drawing.Size(774, 125);
            this.gbxFilter.TabIndex = 1;
            this.gbxFilter.TabStop = false;
            this.gbxFilter.Tag = "places.filter.title";
            this.gbxFilter.Text = "Filtrar";
            this.gbxFilter.Enter += new System.EventHandler(this.gbxFilter_Enter);
            // 
            // tlpFilter
            // 
            this.tlpFilter.ColumnCount = 3;
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.48193F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.51807F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tlpFilter.Controls.Add(this.btnReset, 2, 1);
            this.tlpFilter.Controls.Add(this.lblId, 0, 0);
            this.tlpFilter.Controls.Add(this.lblName, 1, 0);
            this.tlpFilter.Controls.Add(this.txtPlaceId, 0, 1);
            this.tlpFilter.Controls.Add(this.txtPlaceName, 1, 1);
            this.tlpFilter.Controls.Add(this.btnPlaceSearch, 2, 0);
            this.tlpFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFilter.Location = new System.Drawing.Point(3, 23);
            this.tlpFilter.Name = "tlpFilter";
            this.tlpFilter.RowCount = 2;
            this.tlpFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFilter.Size = new System.Drawing.Size(768, 99);
            this.tlpFilter.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.Location = new System.Drawing.Point(618, 52);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(147, 44);
            this.btnReset.TabIndex = 5;
            this.btnReset.Tag = "btn.reset";
            this.btnReset.Text = "Borrar filtros";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblId.Location = new System.Drawing.Point(3, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(120, 49);
            this.lblId.TabIndex = 0;
            this.lblId.Tag = "places.label.filter.id";
            this.lblId.Text = "Id";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(129, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Tag = "places.label.filter.name";
            this.lblName.Text = "Nombre";
            // 
            // txtPlaceId
            // 
            this.txtPlaceId.Location = new System.Drawing.Point(3, 52);
            this.txtPlaceId.Name = "txtPlaceId";
            this.txtPlaceId.Size = new System.Drawing.Size(120, 27);
            this.txtPlaceId.TabIndex = 2;
            // 
            // txtPlaceName
            // 
            this.txtPlaceName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPlaceName.Location = new System.Drawing.Point(129, 52);
            this.txtPlaceName.Name = "txtPlaceName";
            this.txtPlaceName.Size = new System.Drawing.Size(483, 27);
            this.txtPlaceName.TabIndex = 3;
            // 
            // btnPlaceSearch
            // 
            this.btnPlaceSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlaceSearch.Location = new System.Drawing.Point(618, 3);
            this.btnPlaceSearch.Name = "btnPlaceSearch";
            this.btnPlaceSearch.Size = new System.Drawing.Size(147, 43);
            this.btnPlaceSearch.TabIndex = 4;
            this.btnPlaceSearch.Tag = "btn.search";
            this.btnPlaceSearch.Text = "Buscar";
            this.btnPlaceSearch.UseVisualStyleBackColor = true;
            this.btnPlaceSearch.Click += new System.EventHandler(this.btnPlaceSearch_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(686, 195);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 29);
            this.btnNew.TabIndex = 2;
            this.btnNew.Tag = "btn.new";
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEditPlace
            // 
            this.btnEditPlace.Location = new System.Drawing.Point(686, 230);
            this.btnEditPlace.Name = "btnEditPlace";
            this.btnEditPlace.Size = new System.Drawing.Size(94, 29);
            this.btnEditPlace.TabIndex = 3;
            this.btnEditPlace.Tag = "btn.edit";
            this.btnEditPlace.Text = "Editar";
            this.btnEditPlace.UseVisualStyleBackColor = true;
            this.btnEditPlace.Click += new System.EventHandler(this.btnEditPlace_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(686, 265);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(94, 29);
            this.btnHistory.TabIndex = 4;
            this.btnHistory.Tag = "btn.history";
            this.btnHistory.Text = "Historial";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnDvv
            // 
            this.btnDvv.Location = new System.Drawing.Point(686, 409);
            this.btnDvv.Name = "btnDvv";
            this.btnDvv.Size = new System.Drawing.Size(94, 29);
            this.btnDvv.TabIndex = 5;
            this.btnDvv.Tag = "btn.dvv";
            this.btnDvv.Text = "DVV";
            this.btnDvv.UseVisualStyleBackColor = true;
            this.btnDvv.Click += new System.EventHandler(this.btnDvv_Click);
            // 
            // btnExportToJson
            // 
            this.btnExportToJson.Location = new System.Drawing.Point(686, 300);
            this.btnExportToJson.Name = "btnExportToJson";
            this.btnExportToJson.Size = new System.Drawing.Size(94, 68);
            this.btnExportToJson.TabIndex = 6;
            this.btnExportToJson.Tag = "btn.history.export";
            this.btnExportToJson.Text = "Exportar Historial";
            this.btnExportToJson.UseVisualStyleBackColor = true;
            this.btnExportToJson.Click += new System.EventHandler(this.btnExportToJson_Click);
            // 
            // FrmLugares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExportToJson);
            this.Controls.Add(this.btnDvv);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnEditPlace);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.gbxFilter);
            this.Controls.Add(this.dgvPlaces);
            this.Name = "FrmLugares";
            this.Text = "FrmLugares";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLugares_FormClosed);
            this.Load += new System.EventHandler(this.FrmLugares_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaces)).EndInit();
            this.gbxFilter.ResumeLayout(false);
            this.tlpFilter.ResumeLayout(false);
            this.tlpFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlaces;
        private System.Windows.Forms.GroupBox gbxFilter;
        private System.Windows.Forms.TableLayoutPanel tlpFilter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtPlaceId;
        private System.Windows.Forms.TextBox txtPlaceName;
        private System.Windows.Forms.Button btnPlaceSearch;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEditPlace;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcBucket;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPrice;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvcPlaceActive;
        private System.Windows.Forms.Button btnDvv;
        private System.Windows.Forms.Button btnExportToJson;
    }
}