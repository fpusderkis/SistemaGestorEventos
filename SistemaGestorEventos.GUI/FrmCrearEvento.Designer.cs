
namespace SistemaGestorEventos.GUI
{
    partial class FrmCrearEvento
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
            this.gbxEvento = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.dpCuando = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbxParticpantes = new System.Windows.Forms.GroupBox();
            this.gvParticipantes = new System.Windows.Forms.DataGridView();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxLugar = new System.Windows.Forms.GroupBox();
            this.btnBuscarLugar = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtDescripcionLugar = new System.Windows.Forms.TextBox();
            this.lblPrecioLugar = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxServicios = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAgregarServicio = new System.Windows.Forms.Button();
            this.gvServicios = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbxEvento.SuspendLayout();
            this.gbxParticpantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvParticipantes)).BeginInit();
            this.gbxLugar.SuspendLayout();
            this.gbxServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxEvento
            // 
            this.gbxEvento.AutoSize = true;
            this.gbxEvento.Controls.Add(this.comboBox2);
            this.gbxEvento.Controls.Add(this.comboBox1);
            this.gbxEvento.Controls.Add(this.label7);
            this.gbxEvento.Controls.Add(this.label4);
            this.gbxEvento.Controls.Add(this.label1);
            this.gbxEvento.Controls.Add(this.lblDescripcion);
            this.gbxEvento.Controls.Add(this.dpCuando);
            this.gbxEvento.Controls.Add(this.textBox1);
            this.gbxEvento.Controls.Add(this.txtTitulo);
            this.gbxEvento.Controls.Add(this.lblTitulo);
            this.gbxEvento.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxEvento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbxEvento.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxEvento.Location = new System.Drawing.Point(10, 10);
            this.gbxEvento.Margin = new System.Windows.Forms.Padding(10);
            this.gbxEvento.Name = "gbxEvento";
            this.gbxEvento.Padding = new System.Windows.Forms.Padding(0);
            this.gbxEvento.Size = new System.Drawing.Size(702, 153);
            this.gbxEvento.TabIndex = 0;
            this.gbxEvento.TabStop = false;
            this.gbxEvento.Tag = "event";
            this.gbxEvento.Text = "Evento";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "00",
            "30"});
            this.comboBox2.Location = new System.Drawing.Point(644, 99);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(51, 29);
            this.comboBox2.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(587, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(51, 29);
            this.comboBox1.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(508, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 21);
            this.label7.TabIndex = 8;
            this.label7.Tag = "event.duration";
            this.label7.Text = "Duracion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 7;
            this.label4.Tag = "event.description";
            this.label4.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 5;
            this.label1.Tag = "event.date";
            this.label1.Text = "Fecha";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(3, 55);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(91, 21);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Tag = "event.description";
            this.lblDescripcion.Text = "Descripcion";
            // 
            // dpCuando
            // 
            this.dpCuando.Location = new System.Drawing.Point(104, 99);
            this.dpCuando.MaxDate = new System.DateTime(2089, 12, 31, 0, 0, 0, 0);
            this.dpCuando.MinDate = new System.DateTime(2021, 7, 11, 0, 0, 0, 0);
            this.dpCuando.Name = "dpCuando";
            this.dpCuando.Size = new System.Drawing.Size(392, 29);
            this.dpCuando.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox1.Location = new System.Drawing.Point(104, 58);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(592, 35);
            this.textBox1.TabIndex = 2;
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTitulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTitulo.Location = new System.Drawing.Point(104, 23);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(592, 29);
            this.txtTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(4, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(49, 21);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Tag = "event.title";
            this.lblTitulo.Text = "Titulo";
            // 
            // gbxParticpantes
            // 
            this.gbxParticpantes.Controls.Add(this.gvParticipantes);
            this.gbxParticpantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxParticpantes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbxParticpantes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxParticpantes.Location = new System.Drawing.Point(10, 163);
            this.gbxParticpantes.Name = "gbxParticpantes";
            this.gbxParticpantes.Size = new System.Drawing.Size(702, 113);
            this.gbxParticpantes.TabIndex = 1;
            this.gbxParticpantes.TabStop = false;
            this.gbxParticpantes.Tag = "event.participants";
            this.gbxParticpantes.Text = "Participantes";
            // 
            // gvParticipantes
            // 
            this.gvParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvParticipantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Email,
            this.Nombre,
            this.Telefono});
            this.gvParticipantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvParticipantes.Location = new System.Drawing.Point(3, 25);
            this.gvParticipantes.Name = "gvParticipantes";
            this.gvParticipantes.RowTemplate.Height = 25;
            this.gvParticipantes.Size = new System.Drawing.Size(696, 85);
            this.gvParticipantes.TabIndex = 2;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MaxInputLength = 255;
            this.Email.MinimumWidth = 200;
            this.Email.Name = "Email";
            this.Email.Width = 200;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // gbxLugar
            // 
            this.gbxLugar.Controls.Add(this.btnBuscarLugar);
            this.gbxLugar.Controls.Add(this.textBox4);
            this.gbxLugar.Controls.Add(this.label6);
            this.gbxLugar.Controls.Add(this.label5);
            this.gbxLugar.Controls.Add(this.textBox3);
            this.gbxLugar.Controls.Add(this.txtDescripcionLugar);
            this.gbxLugar.Controls.Add(this.lblPrecioLugar);
            this.gbxLugar.Controls.Add(this.textBox2);
            this.gbxLugar.Controls.Add(this.label2);
            this.gbxLugar.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxLugar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbxLugar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxLugar.Location = new System.Drawing.Point(10, 276);
            this.gbxLugar.Name = "gbxLugar";
            this.gbxLugar.Size = new System.Drawing.Size(702, 139);
            this.gbxLugar.TabIndex = 3;
            this.gbxLugar.TabStop = false;
            this.gbxLugar.Tag = "event.place";
            this.gbxLugar.Text = "Lugar";
            // 
            // btnBuscarLugar
            // 
            this.btnBuscarLugar.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnBuscarLugar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarLugar.FlatAppearance.BorderSize = 0;
            this.btnBuscarLugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarLugar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarLugar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarLugar.Location = new System.Drawing.Point(587, 19);
            this.btnBuscarLugar.Name = "btnBuscarLugar";
            this.btnBuscarLugar.Size = new System.Drawing.Size(91, 112);
            this.btnBuscarLugar.TabIndex = 7;
            this.btnBuscarLugar.Tag = "lugar.buscar";
            this.btnBuscarLugar.Text = "Buscar Lugar";
            this.btnBuscarLugar.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox4.Location = new System.Drawing.Point(104, 21);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(333, 29);
            this.textBox4.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 10;
            this.label6.Tag = "direccion";
            this.label6.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 9;
            this.label5.Tag = "event.description";
            this.label5.Text = "Descripcion";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox3.Location = new System.Drawing.Point(502, 21);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(72, 29);
            this.textBox3.TabIndex = 8;
            // 
            // txtDescripcionLugar
            // 
            this.txtDescripcionLugar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescripcionLugar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDescripcionLugar.Location = new System.Drawing.Point(104, 58);
            this.txtDescripcionLugar.Multiline = true;
            this.txtDescripcionLugar.Name = "txtDescripcionLugar";
            this.txtDescripcionLugar.ReadOnly = true;
            this.txtDescripcionLugar.Size = new System.Drawing.Size(470, 39);
            this.txtDescripcionLugar.TabIndex = 8;
            // 
            // lblPrecioLugar
            // 
            this.lblPrecioLugar.AutoSize = true;
            this.lblPrecioLugar.Location = new System.Drawing.Point(443, 24);
            this.lblPrecioLugar.Name = "lblPrecioLugar";
            this.lblPrecioLugar.Size = new System.Drawing.Size(53, 21);
            this.lblPrecioLugar.TabIndex = 7;
            this.lblPrecioLugar.Tag = "precio";
            this.lblPrecioLugar.Text = "Precio";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox2.Location = new System.Drawing.Point(104, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(470, 29);
            this.textBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 0;
            this.label2.Tag = "nombre";
            this.label2.Text = "Nombre";
            // 
            // gbxServicios
            // 
            this.gbxServicios.Controls.Add(this.button1);
            this.gbxServicios.Controls.Add(this.btnAgregarServicio);
            this.gbxServicios.Controls.Add(this.gvServicios);
            this.gbxServicios.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxServicios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbxServicios.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxServicios.Location = new System.Drawing.Point(10, 415);
            this.gbxServicios.Name = "gbxServicios";
            this.gbxServicios.Size = new System.Drawing.Size(702, 141);
            this.gbxServicios.TabIndex = 4;
            this.gbxServicios.TabStop = false;
            this.gbxServicios.Tag = "event.servicios";
            this.gbxServicios.Text = "Servicios adicionales";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(593, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 45);
            this.button1.TabIndex = 9;
            this.button1.Tag = "servicio.btn.agregar";
            this.button1.Text = "Quitar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnAgregarServicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarServicio.FlatAppearance.BorderSize = 0;
            this.btnAgregarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarServicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarServicio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarServicio.Location = new System.Drawing.Point(593, 28);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(91, 45);
            this.btnAgregarServicio.TabIndex = 8;
            this.btnAgregarServicio.Tag = "servicio.btn.agregar";
            this.btnAgregarServicio.Text = "Agregar";
            this.btnAgregarServicio.UseVisualStyleBackColor = false;
            // 
            // gvServicios
            // 
            this.gvServicios.AllowUserToAddRows = false;
            this.gvServicios.AllowUserToDeleteRows = false;
            this.gvServicios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.Precio});
            this.gvServicios.Location = new System.Drawing.Point(3, 28);
            this.gvServicios.Name = "gvServicios";
            this.gvServicios.ReadOnly = true;
            this.gvServicios.RowTemplate.Height = 25;
            this.gvServicios.Size = new System.Drawing.Size(584, 107);
            this.gvServicios.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrear.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCrear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCrear.Location = new System.Drawing.Point(506, 562);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(200, 36);
            this.btnCrear.TabIndex = 5;
            this.btnCrear.Tag = "event.create";
            this.btnCrear.Text = "Crear evento";
            this.btnCrear.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(10, 562);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(200, 36);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Tag = "cancel";
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmCrearEvento
            // 
            this.AcceptButton = this.btnCrear;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(722, 611);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.gbxServicios);
            this.Controls.Add(this.gbxLugar);
            this.Controls.Add(this.gbxParticpantes);
            this.Controls.Add(this.gbxEvento);
            this.MinimizeBox = false;
            this.Name = "FrmCrearEvento";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Si, Se Hace!";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCrearEvento_Load);
            this.gbxEvento.ResumeLayout(false);
            this.gbxEvento.PerformLayout();
            this.gbxParticpantes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvParticipantes)).EndInit();
            this.gbxLugar.ResumeLayout(false);
            this.gbxLugar.PerformLayout();
            this.gbxServicios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvServicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxEvento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.DateTimePicker dpCuando;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbxParticpantes;
        private System.Windows.Forms.DataGridView gvParticipantes;
        private System.Windows.Forms.GroupBox gbxLugar;
        private System.Windows.Forms.GroupBox gbxServicios;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtDescripcionLugar;
        private System.Windows.Forms.Label lblPrecioLugar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAgregarServicio;
        private System.Windows.Forms.DataGridView gvServicios;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Button btnBuscarLugar;
    }
}