
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
            this.labelCheckCost = new System.Windows.Forms.Label();
            this.textBoxCheckCostNum = new System.Windows.Forms.TextBox();
            this.textBoxSelesai = new System.Windows.Forms.TextBox();
            this.buttonBackToHome = new System.Windows.Forms.Button();
            this.buttonCheckCostNum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCheckCost
            // 
            this.labelCheckCost.AutoSize = true;
            this.labelCheckCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckCost.Location = new System.Drawing.Point(227, 58);
            this.labelCheckCost.Name = "labelCheckCost";
            this.labelCheckCost.Size = new System.Drawing.Size(406, 32);
            this.labelCheckCost.TabIndex = 0;
            this.labelCheckCost.Text = "Input Your Costumer Number";
            // 
            // textBoxCheckCostNum
            // 
            this.textBoxCheckCostNum.Location = new System.Drawing.Point(233, 124);
            this.textBoxCheckCostNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCheckCostNum.Name = "textBoxCheckCostNum";
            this.textBoxCheckCostNum.Size = new System.Drawing.Size(400, 26);
            this.textBoxCheckCostNum.TabIndex = 1;
            // 
            // textBoxSelesai
            // 
            this.textBoxSelesai.Location = new System.Drawing.Point(329, 407);
            this.textBoxSelesai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSelesai.Name = "textBoxSelesai";
            this.textBoxSelesai.Size = new System.Drawing.Size(112, 26);
            this.textBoxSelesai.TabIndex = 4;
            // 
            // buttonBackToHome
            // 
            this.buttonBackToHome.Image = global::Project_VS.Properties.Resources.Back;
            this.buttonBackToHome.Location = new System.Drawing.Point(425, 220);
            this.buttonBackToHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBackToHome.Name = "buttonBackToHome";
            this.buttonBackToHome.Size = new System.Drawing.Size(237, 105);
            this.buttonBackToHome.TabIndex = 3;
            this.buttonBackToHome.UseVisualStyleBackColor = true;
            this.buttonBackToHome.Click += new System.EventHandler(this.buttonBackToHome_Click);
            // 
            // buttonCheckCostNum
            // 
            this.buttonCheckCostNum.Image = global::Project_VS.Properties.Resources.Check;
            this.buttonCheckCostNum.Location = new System.Drawing.Point(202, 220);
            this.buttonCheckCostNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCheckCostNum.Name = "buttonCheckCostNum";
            this.buttonCheckCostNum.Size = new System.Drawing.Size(181, 105);
            this.buttonCheckCostNum.TabIndex = 2;
            this.buttonCheckCostNum.UseVisualStyleBackColor = true;
            this.buttonCheckCostNum.Click += new System.EventHandler(this.buttonCheckCostNum_Click);
            // 
            // FormCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.textBoxSelesai);
            this.Controls.Add(this.buttonBackToHome);
            this.Controls.Add(this.buttonCheckCostNum);
            this.Controls.Add(this.textBoxCheckCostNum);
            this.Controls.Add(this.labelCheckCost);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCheck";
            this.Text = "Check Your Service";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCheck_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCheckCost;
        private System.Windows.Forms.TextBox textBoxCheckCostNum;
        private System.Windows.Forms.Button buttonCheckCostNum;
        private System.Windows.Forms.Button buttonBackToHome;
        private System.Windows.Forms.TextBox textBoxSelesai;
    }
}