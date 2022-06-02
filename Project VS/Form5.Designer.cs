
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
            this.labelPerintah = new System.Windows.Forms.Label();
            this.labelTotalHarga = new System.Windows.Forms.Label();
            this.labelIsiService = new System.Windows.Forms.Label();
            this.labelIsiCodeCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPerintah
            // 
            this.labelPerintah.AutoSize = true;
            this.labelPerintah.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerintah.Location = new System.Drawing.Point(235, 386);
            this.labelPerintah.Name = "labelPerintah";
            this.labelPerintah.Size = new System.Drawing.Size(383, 58);
            this.labelPerintah.TabIndex = 4;
            this.labelPerintah.Text = "Silahkan Disimpan / Screenshot\r\nPembayaran ke Cashier";
            this.labelPerintah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalHarga
            // 
            this.labelTotalHarga.AutoSize = true;
            this.labelTotalHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalHarga.Location = new System.Drawing.Point(319, 287);
            this.labelTotalHarga.Name = "labelTotalHarga";
            this.labelTotalHarga.Size = new System.Drawing.Size(114, 25);
            this.labelTotalHarga.TabIndex = 7;
            this.labelTotalHarga.Text = "[..................]";
            // 
            // labelIsiService
            // 
            this.labelIsiService.AutoSize = true;
            this.labelIsiService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIsiService.Location = new System.Drawing.Point(319, 231);
            this.labelIsiService.Name = "labelIsiService";
            this.labelIsiService.Size = new System.Drawing.Size(114, 25);
            this.labelIsiService.TabIndex = 6;
            this.labelIsiService.Text = "[..................]";
            // 
            // labelIsiCodeCost
            // 
            this.labelIsiCodeCost.AutoSize = true;
            this.labelIsiCodeCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIsiCodeCost.Location = new System.Drawing.Point(319, 170);
            this.labelIsiCodeCost.Name = "labelIsiCodeCost";
            this.labelIsiCodeCost.Size = new System.Drawing.Size(114, 25);
            this.labelIsiCodeCost.TabIndex = 5;
            this.labelIsiCodeCost.Text = "[..................]";
            // 
            // FormInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.labelTotalHarga);
            this.Controls.Add(this.labelIsiService);
            this.Controls.Add(this.labelIsiCodeCost);
            this.Controls.Add(this.labelPerintah);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInvoice";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.FormInvoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPerintah;
        private System.Windows.Forms.Label labelTotalHarga;
        private System.Windows.Forms.Label labelIsiService;
        private System.Windows.Forms.Label labelIsiCodeCost;
    }
}