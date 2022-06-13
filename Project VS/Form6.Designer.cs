
namespace Project_VS
{
    partial class FormCheckStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheckStock));
            this.labelStockLampu = new System.Windows.Forms.Label();
            this.labelStockBan = new System.Windows.Forms.Label();
            this.labelStockSpion = new System.Windows.Forms.Label();
            this.labelStockWiper = new System.Windows.Forms.Label();
            this.labelStockBumper = new System.Windows.Forms.Label();
            this.labelStockVelg = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelStockLampu
            // 
            this.labelStockLampu.AutoSize = true;
            this.labelStockLampu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStockLampu.Location = new System.Drawing.Point(316, 382);
            this.labelStockLampu.Name = "labelStockLampu";
            this.labelStockLampu.Size = new System.Drawing.Size(99, 20);
            this.labelStockLampu.TabIndex = 11;
            this.labelStockLampu.Text = "[....................]";
            // 
            // labelStockBan
            // 
            this.labelStockBan.AutoSize = true;
            this.labelStockBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStockBan.Location = new System.Drawing.Point(316, 334);
            this.labelStockBan.Name = "labelStockBan";
            this.labelStockBan.Size = new System.Drawing.Size(99, 20);
            this.labelStockBan.TabIndex = 10;
            this.labelStockBan.Text = "[....................]";
            // 
            // labelStockSpion
            // 
            this.labelStockSpion.AutoSize = true;
            this.labelStockSpion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStockSpion.Location = new System.Drawing.Point(316, 288);
            this.labelStockSpion.Name = "labelStockSpion";
            this.labelStockSpion.Size = new System.Drawing.Size(99, 20);
            this.labelStockSpion.TabIndex = 9;
            this.labelStockSpion.Text = "[....................]";
            // 
            // labelStockWiper
            // 
            this.labelStockWiper.AutoSize = true;
            this.labelStockWiper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStockWiper.Location = new System.Drawing.Point(316, 243);
            this.labelStockWiper.Name = "labelStockWiper";
            this.labelStockWiper.Size = new System.Drawing.Size(99, 20);
            this.labelStockWiper.TabIndex = 8;
            this.labelStockWiper.Text = "[....................]";
            // 
            // labelStockBumper
            // 
            this.labelStockBumper.AutoSize = true;
            this.labelStockBumper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStockBumper.Location = new System.Drawing.Point(316, 192);
            this.labelStockBumper.Name = "labelStockBumper";
            this.labelStockBumper.Size = new System.Drawing.Size(99, 20);
            this.labelStockBumper.TabIndex = 7;
            this.labelStockBumper.Text = "[....................]";
            // 
            // labelStockVelg
            // 
            this.labelStockVelg.AutoSize = true;
            this.labelStockVelg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStockVelg.Location = new System.Drawing.Point(316, 144);
            this.labelStockVelg.Name = "labelStockVelg";
            this.labelStockVelg.Size = new System.Drawing.Size(99, 20);
            this.labelStockVelg.TabIndex = 6;
            this.labelStockVelg.Text = "[....................]";
            // 
            // buttonOK
            // 
            this.buttonOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOK.BackgroundImage")));
            this.buttonOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonOK.Location = new System.Drawing.Point(547, 478);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(145, 37);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormCheckStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelStockLampu);
            this.Controls.Add(this.labelStockBan);
            this.Controls.Add(this.labelStockSpion);
            this.Controls.Add(this.labelStockWiper);
            this.Controls.Add(this.labelStockBumper);
            this.Controls.Add(this.labelStockVelg);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCheckStock";
            this.Text = "Stock Part";
            this.Load += new System.EventHandler(this.FormCheckStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelStockLampu;
        private System.Windows.Forms.Label labelStockBan;
        private System.Windows.Forms.Label labelStockSpion;
        private System.Windows.Forms.Label labelStockWiper;
        private System.Windows.Forms.Label labelStockBumper;
        private System.Windows.Forms.Label labelStockVelg;
        private System.Windows.Forms.Button buttonOK;
    }
}