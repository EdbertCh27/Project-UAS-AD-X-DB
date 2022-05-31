
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
            this.labelCheckCost = new System.Windows.Forms.Label();
            this.textBoxCheckCostNum = new System.Windows.Forms.TextBox();
            this.buttonCheckCostNum = new System.Windows.Forms.Button();
            this.buttonBackToHome = new System.Windows.Forms.Button();
            this.textBoxSelesai = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelCheckCost
            // 
            this.labelCheckCost.AutoSize = true;
            this.labelCheckCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckCost.Location = new System.Drawing.Point(163, 53);
            this.labelCheckCost.Name = "labelCheckCost";
            this.labelCheckCost.Size = new System.Drawing.Size(351, 29);
            this.labelCheckCost.TabIndex = 0;
            this.labelCheckCost.Text = "Input Your Costumer Number";
            // 
            // textBoxCheckCostNum
            // 
            this.textBoxCheckCostNum.Location = new System.Drawing.Point(168, 101);
            this.textBoxCheckCostNum.Name = "textBoxCheckCostNum";
            this.textBoxCheckCostNum.Size = new System.Drawing.Size(346, 22);
            this.textBoxCheckCostNum.TabIndex = 1;
            // 
            // buttonCheckCostNum
            // 
            this.buttonCheckCostNum.Location = new System.Drawing.Point(168, 176);
            this.buttonCheckCostNum.Name = "buttonCheckCostNum";
            this.buttonCheckCostNum.Size = new System.Drawing.Size(125, 50);
            this.buttonCheckCostNum.TabIndex = 2;
            this.buttonCheckCostNum.Text = "CHECK";
            this.buttonCheckCostNum.UseVisualStyleBackColor = true;
            this.buttonCheckCostNum.Click += new System.EventHandler(this.buttonCheckCostNum_Click);
            // 
            // buttonBackToHome
            // 
            this.buttonBackToHome.Location = new System.Drawing.Point(389, 176);
            this.buttonBackToHome.Name = "buttonBackToHome";
            this.buttonBackToHome.Size = new System.Drawing.Size(125, 50);
            this.buttonBackToHome.TabIndex = 3;
            this.buttonBackToHome.Text = "Back To Home";
            this.buttonBackToHome.UseVisualStyleBackColor = true;
            this.buttonBackToHome.Click += new System.EventHandler(this.buttonBackToHome_Click);
            // 
            // textBoxSelesai
            // 
            this.textBoxSelesai.Location = new System.Drawing.Point(257, 328);
            this.textBoxSelesai.Name = "textBoxSelesai";
            this.textBoxSelesai.Size = new System.Drawing.Size(100, 22);
            this.textBoxSelesai.TabIndex = 4;
            // 
            // FormCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxSelesai);
            this.Controls.Add(this.buttonBackToHome);
            this.Controls.Add(this.buttonCheckCostNum);
            this.Controls.Add(this.textBoxCheckCostNum);
            this.Controls.Add(this.labelCheckCost);
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