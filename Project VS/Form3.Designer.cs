
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
            this.buttonPickUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckCostumer)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBackToHome
            // 
            this.buttonBackToHome.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonBackToHome, "buttonBackToHome");
            this.buttonBackToHome.Name = "buttonBackToHome";
            this.buttonBackToHome.UseVisualStyleBackColor = false;
            this.buttonBackToHome.Click += new System.EventHandler(this.buttonBackToHome_Click);
            // 
            // buttonCheckCostNum
            // 
            resources.ApplyResources(this.buttonCheckCostNum, "buttonCheckCostNum");
            this.buttonCheckCostNum.Name = "buttonCheckCostNum";
            this.buttonCheckCostNum.UseVisualStyleBackColor = true;
            this.buttonCheckCostNum.Click += new System.EventHandler(this.buttonCheckCostNum_Click);
            // 
            // textBoxCheckCostNum
            // 
            resources.ApplyResources(this.textBoxCheckCostNum, "textBoxCheckCostNum");
            this.textBoxCheckCostNum.Name = "textBoxCheckCostNum";
            // 
            // dataGridViewCheckCostumer
            // 
            this.dataGridViewCheckCostumer.AllowUserToAddRows = false;
            this.dataGridViewCheckCostumer.AllowUserToDeleteRows = false;
            this.dataGridViewCheckCostumer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridViewCheckCostumer, "dataGridViewCheckCostumer");
            this.dataGridViewCheckCostumer.Name = "dataGridViewCheckCostumer";
            this.dataGridViewCheckCostumer.ReadOnly = true;
            this.dataGridViewCheckCostumer.RowTemplate.Height = 24;
            // 
            // buttonPickUp
            // 
            resources.ApplyResources(this.buttonPickUp, "buttonPickUp");
            this.buttonPickUp.Name = "buttonPickUp";
            this.buttonPickUp.UseVisualStyleBackColor = true;
            this.buttonPickUp.Click += new System.EventHandler(this.buttonPickUp_Click);
            // 
            // FormCheck
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonPickUp);
            this.Controls.Add(this.dataGridViewCheckCostumer);
            this.Controls.Add(this.buttonBackToHome);
            this.Controls.Add(this.buttonCheckCostNum);
            this.Controls.Add(this.textBoxCheckCostNum);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCheck";
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
        private System.Windows.Forms.Button buttonPickUp;
    }
}