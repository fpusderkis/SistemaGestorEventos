namespace SistemaGestorEventos.GUI.Events
{
    partial class FrmAditionalService
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
            this.gbxServiceRO = new System.Windows.Forms.GroupBox();
            this.gbxServiceSelled = new System.Windows.Forms.GroupBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtServiceCost = new System.Windows.Forms.TextBox();
            this.lblServiceCost = new System.Windows.Forms.Label();
            this.txtASPrice = new System.Windows.Forms.TextBox();
            this.lblServicePrice = new System.Windows.Forms.Label();
            this.txtServiceQty = new System.Windows.Forms.TextBox();
            this.lblServiceQty = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.gbxServiceSelled.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxServiceRO
            // 
            this.gbxServiceRO.Location = new System.Drawing.Point(15, 12);
            this.gbxServiceRO.Name = "gbxServiceRO";
            this.gbxServiceRO.Size = new System.Drawing.Size(397, 184);
            this.gbxServiceRO.TabIndex = 0;
            this.gbxServiceRO.TabStop = false;
            this.gbxServiceRO.Text = "Servicio";
            // 
            // gbxServiceSelled
            // 
            this.gbxServiceSelled.Controls.Add(this.lblTotalCost);
            this.gbxServiceSelled.Controls.Add(this.lblTotalPrice);
            this.gbxServiceSelled.Controls.Add(this.txtServiceCost);
            this.gbxServiceSelled.Controls.Add(this.lblServiceCost);
            this.gbxServiceSelled.Controls.Add(this.txtASPrice);
            this.gbxServiceSelled.Controls.Add(this.lblServicePrice);
            this.gbxServiceSelled.Controls.Add(this.txtServiceQty);
            this.gbxServiceSelled.Controls.Add(this.lblServiceQty);
            this.gbxServiceSelled.Location = new System.Drawing.Point(12, 211);
            this.gbxServiceSelled.Name = "gbxServiceSelled";
            this.gbxServiceSelled.Size = new System.Drawing.Size(400, 184);
            this.gbxServiceSelled.TabIndex = 1;
            this.gbxServiceSelled.TabStop = false;
            this.gbxServiceSelled.Text = "Servicio vendido";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(249, 132);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(0, 20);
            this.lblTotalCost.TabIndex = 9;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(249, 95);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(0, 20);
            this.lblTotalPrice.TabIndex = 8;
            // 
            // txtServiceCost
            // 
            this.txtServiceCost.Location = new System.Drawing.Point(118, 125);
            this.txtServiceCost.Name = "txtServiceCost";
            this.txtServiceCost.Size = new System.Drawing.Size(125, 27);
            this.txtServiceCost.TabIndex = 7;
            this.txtServiceCost.TextChanged += new System.EventHandler(this.txtServiceCost_TextChanged);
            // 
            // lblServiceCost
            // 
            this.lblServiceCost.AutoSize = true;
            this.lblServiceCost.Location = new System.Drawing.Point(3, 126);
            this.lblServiceCost.Name = "lblServiceCost";
            this.lblServiceCost.Size = new System.Drawing.Size(47, 20);
            this.lblServiceCost.TabIndex = 6;
            this.lblServiceCost.Tag = "serviceCost.title";
            this.lblServiceCost.Text = "Costo";
            // 
            // txtASPrice
            // 
            this.txtASPrice.Location = new System.Drawing.Point(118, 92);
            this.txtASPrice.Name = "txtASPrice";
            this.txtASPrice.Size = new System.Drawing.Size(125, 27);
            this.txtASPrice.TabIndex = 5;
            this.txtASPrice.TextChanged += new System.EventHandler(this.txtASPrice_TextChanged);
            // 
            // lblServicePrice
            // 
            this.lblServicePrice.AutoSize = true;
            this.lblServicePrice.Location = new System.Drawing.Point(3, 93);
            this.lblServicePrice.Name = "lblServicePrice";
            this.lblServicePrice.Size = new System.Drawing.Size(50, 20);
            this.lblServicePrice.TabIndex = 4;
            this.lblServicePrice.Tag = "serviceprice.title";
            this.lblServicePrice.Text = "Precio";
            // 
            // txtServiceQty
            // 
            this.txtServiceQty.Location = new System.Drawing.Point(118, 57);
            this.txtServiceQty.Name = "txtServiceQty";
            this.txtServiceQty.Size = new System.Drawing.Size(125, 27);
            this.txtServiceQty.TabIndex = 3;
            this.txtServiceQty.Tag = "serviceqty.title";
            this.txtServiceQty.TextChanged += new System.EventHandler(this.txtServiceQty_TextChanged);
            // 
            // lblServiceQty
            // 
            this.lblServiceQty.AutoSize = true;
            this.lblServiceQty.Location = new System.Drawing.Point(3, 58);
            this.lblServiceQty.Name = "lblServiceQty";
            this.lblServiceQty.Size = new System.Drawing.Size(69, 20);
            this.lblServiceQty.TabIndex = 2;
            this.lblServiceQty.Tag = "quantity.title";
            this.lblServiceQty.Text = "Cantidad";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(431, 67);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(330, 328);
            this.txtObs.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 3;
            this.label1.Tag = "observations.title";
            this.label1.Text = "Observaciones";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(16, 410);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(330, 29);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Tag = "provider.cancel.btn";
            this.btnCancelar.Text = "Proveedor no dipsonible";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(431, 410);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(330, 29);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Tag = "confirm.title";
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // FrmAditionalService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.gbxServiceSelled);
            this.Controls.Add(this.gbxServiceRO);
            this.Name = "FrmAditionalService";
            this.Text = "Servicio adicional";
            this.Load += new System.EventHandler(this.FrmAditionalService_Load);
            this.gbxServiceSelled.ResumeLayout(false);
            this.gbxServiceSelled.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxServiceRO;
        private System.Windows.Forms.GroupBox gbxServiceSelled;
        private System.Windows.Forms.TextBox txtServiceCost;
        private System.Windows.Forms.Label lblServiceCost;
        private System.Windows.Forms.TextBox txtASPrice;
        private System.Windows.Forms.Label lblServicePrice;
        private System.Windows.Forms.TextBox txtServiceQty;
        private System.Windows.Forms.Label lblServiceQty;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblTotalPrice;
    }
}