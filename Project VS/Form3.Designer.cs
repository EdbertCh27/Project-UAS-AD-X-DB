
namespace Project_VS
{
    partial class FormCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheck));
            this.buttonBackToHome = new System.Windows.Forms.Button();
            this.buttonCheckCostNum = new System.Windows.Forms.Button();
            this.textBoxCheckCostNum = new System.Windows.Forms.TextBox();
            this.dataGridViewCheckCostumer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckCostumer)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBackToHome
            // 
            this.buttonBackToHome.BackColor = System.Drawing.Color.Transparent;
            this.buttonBackToHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBackToHome.BackgroundImage")));
            this.buttonBackToHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBackToHome.Location = new System.Drawing.Point(498, 452);
            this.buttonBackToHome.Name = "buttonBackToHome";
            this.buttonBackToHome.Size = new System.Drawing.Size(160, 63);
            this.buttonBackToHome.TabIndex = 3;
            this.buttonBackToHome.UseVisualStyleBackColor = false;
            this.buttonBackToHome.Click += new System.EventHandler(this.buttonBackToHome_Click);
            // 
            // buttonCheckCostNum
            // 
            this.buttonCheckCostNum.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCheckCostNum.BackgroundImage")));
            this.buttonCheckCostNum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCheckCostNum.Location = new System.Drawing.Point(205, 452);
            this.buttonCheckCostNum.Name = "buttonCheckCostNum";
            this.buttonCheckCostNum.Size = new System.Drawing.Size(161, 63);
            this.buttonCheckCostNum.TabIndex = 2;
            this.buttonCheckCostNum.UseVisualStyleBackColor = true;
            this.buttonCheckCostNum.Click += new System.EventHandler(this.buttonCheckCostNum_Click);
            // 
            // textBoxCheckCostNum
            // 
            this.textBoxCheckCostNum.Location = new System.Drawing.Point(260, 159);
            this.textBoxCheckCostNum.Name = "textBoxCheckCostNum";
            this.textBoxCheckCostNum.Size = new System.Drawing.Size(356, 22);
            this.textBoxCheckCostNum.TabIndex = 1;
            // 
            // dataGridViewCheckCostumer
            // 
            this.dataGridViewCheckCostumer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCheckCostumer.Location = new System.Drawing.Point(93, 280);
            this.dataGridViewCheckCostumer.Name = "dataGridViewCheckCostumer";
            this.dataGridViewCheckCostumer.RowHeadersWidth = 51;
            this.dataGridViewCheckCostumer.RowTemplate.Height = 24;
            this.dataGridViewCheckCostumer.Size = new System.Drawing.Size(708, 108);
            this.dataGridViewCheckCostumer.TabIndex = 5;
            // 
            // FormCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.dataGridViewCheckCostumer);
            this.Controls.Add(this.buttonBackToHome);
            this.Controls.Add(this.buttonCheckCostNum);
            this.Controls.Add(this.textBoxCheckCostNum);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCheck";
            this.Text = "Check Your Service";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCheck_FormClosing);
            this.Load += new System.EventHandler(this.FormCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckCostumer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCheckCostNum;
        private System.Windows.Forms.Button buttonBackToHome;
        private System.Windows.Forms.TextBox textBoxCheckCostNum;
        private System.Windows.Forms.DataGridView dataGridViewCheckCostumer;
    }
}