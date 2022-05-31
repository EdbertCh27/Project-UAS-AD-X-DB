
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
            this.labelInvoice.Location = new System.Drawing.Point(300, 27);
            this.labelInvoice.Name = "labelInvoice";
            this.labelInvoice.Size = new System.Drawing.Size(117, 29);
            this.labelInvoice.TabIndex = 0;
            this.labelInvoice.Text = "INVOICE";
            // 
            // labelKodeCost
            // 
            this.labelKodeCost.AutoSize = true;
            this.labelKodeCost.Location = new System.Drawing.Point(253, 97);
            this.labelKodeCost.Name = "labelKodeCost";
            this.labelKodeCost.Size = new System.Drawing.Size(105, 17);
            this.labelKodeCost.TabIndex = 1;
            this.labelKodeCost.Text = "Costumer Code";
            // 
            // labelServiceCost
            // 
            this.labelServiceCost.AutoSize = true;
            this.labelServiceCost.Location = new System.Drawing.Point(253, 137);
            this.labelServiceCost.Name = "labelServiceCost";
            this.labelServiceCost.Size = new System.Drawing.Size(55, 17);
            this.labelServiceCost.TabIndex = 2;
            this.labelServiceCost.Text = "Service";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(253, 179);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(40, 17);
            this.labelTotal.TabIndex = 3;
            this.labelTotal.Text = "Total";
            // 
            // labelPerintah
            // 
            this.labelPerintah.AutoSize = true;
            this.labelPerintah.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerintah.Location = new System.Drawing.Point(159, 257);
            this.labelPerintah.Name = "labelPerintah";
            this.labelPerintah.Size = new System.Drawing.Size(383, 58);
            this.labelPerintah.TabIndex = 4;
            this.labelPerintah.Text = "Silahkan Disimpan / Screenshot\r\nPembayaran ke Cashier";
            this.labelPerintah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalHarga
            // 
            this.labelTotalHarga.AutoSize = true;
            this.labelTotalHarga.Location = new System.Drawing.Point(405, 179);
            this.labelTotalHarga.Name = "labelTotalHarga";
            this.labelTotalHarga.Size = new System.Drawing.Size(40, 17);
            this.labelTotalHarga.TabIndex = 7;
            this.labelTotalHarga.Text = "[......]";
            // 
            // labelIsiService
            // 
            this.labelIsiService.AutoSize = true;
            this.labelIsiService.Location = new System.Drawing.Point(405, 137);
            this.labelIsiService.Name = "labelIsiService";
            this.labelIsiService.Size = new System.Drawing.Size(40, 17);
            this.labelIsiService.TabIndex = 6;
            this.labelIsiService.Text = "[......]";
            // 
            // labelIsiCodeCost
            // 
            this.labelIsiCodeCost.AutoSize = true;
            this.labelIsiCodeCost.Location = new System.Drawing.Point(405, 97);
            this.labelIsiCodeCost.Name = "labelIsiCodeCost";
            this.labelIsiCodeCost.Size = new System.Drawing.Size(40, 17);
            this.labelIsiCodeCost.TabIndex = 5;
            this.labelIsiCodeCost.Text = "[......]";
            // 
            // FormInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTotalHarga);
            this.Controls.Add(this.labelIsiService);
            this.Controls.Add(this.labelIsiCodeCost);
            this.Controls.Add(this.labelPerintah);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelServiceCost);
            this.Controls.Add(this.labelKodeCost);
            this.Controls.Add(this.labelInvoice);
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