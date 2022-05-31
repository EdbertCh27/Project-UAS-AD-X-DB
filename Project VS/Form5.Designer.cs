
namespace Project_VS
{
    partial class FormInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInvoice));
            this.labelInvoice = new System.Windows.Forms.Label();
            this.labelKodeCost = new System.Windows.Forms.Label();
            this.labelServiceCost = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelPerintah = new System.Windows.Forms.Label();
            this.labelTotalHarga = new System.Windows.Forms.Label();
            this.labelIsiService = new System.Windows.Forms.Label();
            this.labelIsiCodeCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInvoice
            // 
            this.labelInvoice.AutoSize = true;
            this.labelInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvoice.Location = new System.Drawing.Point(338, 34);
            this.labelInvoice.Name = "labelInvoice";
            this.labelInvoice.Size = new System.Drawing.Size(135, 32);
            this.labelInvoice.TabIndex = 0;
            this.labelInvoice.Text = "INVOICE";
            // 
            // labelKodeCost
            // 
            this.labelKodeCost.AutoSize = true;
            this.labelKodeCost.Location = new System.Drawing.Point(285, 121);
            this.labelKodeCost.Name = "labelKodeCost";
            this.labelKodeCost.Size = new System.Drawing.Size(120, 20);
            this.labelKodeCost.TabIndex = 1;
            this.labelKodeCost.Text = "Costumer Code";
            // 
            // labelServiceCost
            // 
            this.labelServiceCost.AutoSize = true;
            this.labelServiceCost.Location = new System.Drawing.Point(285, 171);
            this.labelServiceCost.Name = "labelServiceCost";
            this.labelServiceCost.Size = new System.Drawing.Size(61, 20);
            this.labelServiceCost.TabIndex = 2;
            this.labelServiceCost.Text = "Service";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(285, 224);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(44, 20);
            this.labelTotal.TabIndex = 3;
            this.labelTotal.Text = "Total";
            // 
            // labelPerintah
            // 
            this.labelPerintah.AutoSize = true;
            this.labelPerintah.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerintah.Location = new System.Drawing.Point(179, 321);
            this.labelPerintah.Name = "labelPerintah";
            this.labelPerintah.Size = new System.Drawing.Size(447, 64);
            this.labelPerintah.TabIndex = 4;
            this.labelPerintah.Text = "Silahkan Disimpan / Screenshot\r\nPembayaran ke Cashier";
            this.labelPerintah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalHarga
            // 
            this.labelTotalHarga.AutoSize = true;
            this.labelTotalHarga.Location = new System.Drawing.Point(456, 224);
            this.labelTotalHarga.Name = "labelTotalHarga";
            this.labelTotalHarga.Size = new System.Drawing.Size(41, 20);
            this.labelTotalHarga.TabIndex = 7;
            this.labelTotalHarga.Text = "[......]";
            // 
            // labelIsiService
            // 
            this.labelIsiService.AutoSize = true;
            this.labelIsiService.Location = new System.Drawing.Point(456, 171);
            this.labelIsiService.Name = "labelIsiService";
            this.labelIsiService.Size = new System.Drawing.Size(41, 20);
            this.labelIsiService.TabIndex = 6;
            this.labelIsiService.Text = "[......]";
            // 
            // labelIsiCodeCost
            // 
            this.labelIsiCodeCost.AutoSize = true;
            this.labelIsiCodeCost.Location = new System.Drawing.Point(456, 121);
            this.labelIsiCodeCost.Name = "labelIsiCodeCost";
            this.labelIsiCodeCost.Size = new System.Drawing.Size(41, 20);
            this.labelIsiCodeCost.TabIndex = 5;
            this.labelIsiCodeCost.Text = "[......]";
            // 
            // FormInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.labelTotalHarga);
            this.Controls.Add(this.labelIsiService);
            this.Controls.Add(this.labelIsiCodeCost);
            this.Controls.Add(this.labelPerintah);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelServiceCost);
            this.Controls.Add(this.labelKodeCost);
            this.Controls.Add(this.labelInvoice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormInvoice";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.FormInvoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInvoice;
        private System.Windows.Forms.Label labelKodeCost;
        private System.Windows.Forms.Label labelServiceCost;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelPerintah;
        private System.Windows.Forms.Label labelTotalHarga;
        private System.Windows.Forms.Label labelIsiService;
        private System.Windows.Forms.Label labelIsiCodeCost;
    }
}