
namespace Project_VS
{
    partial class FormInputCostumer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInputCostumer));
            this.textBoxNamaCust = new System.Windows.Forms.TextBox();
            this.textBoxAlamatCust = new System.Windows.Forms.TextBox();
            this.textBoxNoHpCust = new System.Windows.Forms.TextBox();
            this.textBoxTypeMobilCust = new System.Windows.Forms.TextBox();
            this.textBoxNomorPolisiCust = new System.Windows.Forms.TextBox();
            this.buttonInputDataCust = new System.Windows.Forms.Button();
            this.buttonBackToHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNamaCust
            // 
            this.textBoxNamaCust.Location = new System.Drawing.Point(279, 181);
            this.textBoxNamaCust.MaxLength = 50;
            this.textBoxNamaCust.Name = "textBoxNamaCust";
            this.textBoxNamaCust.Size = new System.Drawing.Size(286, 22);
            this.textBoxNamaCust.TabIndex = 5;
            // 
            // textBoxAlamatCust
            // 
            this.textBoxAlamatCust.Location = new System.Drawing.Point(279, 232);
            this.textBoxAlamatCust.MaxLength = 20;
            this.textBoxAlamatCust.Name = "textBoxAlamatCust";
            this.textBoxAlamatCust.Size = new System.Drawing.Size(286, 22);
            this.textBoxAlamatCust.TabIndex = 6;
            // 
            // textBoxNoHpCust
            // 
            this.textBoxNoHpCust.Location = new System.Drawing.Point(279, 279);
            this.textBoxNoHpCust.MaxLength = 15;
            this.textBoxNoHpCust.Name = "textBoxNoHpCust";
            this.textBoxNoHpCust.Size = new System.Drawing.Size(143, 22);
            this.textBoxNoHpCust.TabIndex = 7;
            this.textBoxNoHpCust.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNoHpCust_KeyPress);
            // 
            // textBoxTypeMobilCust
            // 
            this.textBoxTypeMobilCust.Location = new System.Drawing.Point(279, 330);
            this.textBoxTypeMobilCust.MaxLength = 15;
            this.textBoxTypeMobilCust.Name = "textBoxTypeMobilCust";
            this.textBoxTypeMobilCust.Size = new System.Drawing.Size(143, 22);
            this.textBoxTypeMobilCust.TabIndex = 8;
            // 
            // textBoxNomorPolisiCust
            // 
            this.textBoxNomorPolisiCust.Location = new System.Drawing.Point(279, 380);
            this.textBoxNomorPolisiCust.MaxLength = 10;
            this.textBoxNomorPolisiCust.Name = "textBoxNomorPolisiCust";
            this.textBoxNomorPolisiCust.Size = new System.Drawing.Size(143, 22);
            this.textBoxNomorPolisiCust.TabIndex = 9;
            // 
            // buttonInputDataCust
            // 
            this.buttonInputDataCust.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonInputDataCust.BackgroundImage")));
            this.buttonInputDataCust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonInputDataCust.Location = new System.Drawing.Point(464, 464);
            this.buttonInputDataCust.Name = "buttonInputDataCust";
            this.buttonInputDataCust.Size = new System.Drawing.Size(150, 51);
            this.buttonInputDataCust.TabIndex = 10;
            this.buttonInputDataCust.UseVisualStyleBackColor = true;
            this.buttonInputDataCust.Click += new System.EventHandler(this.buttonInputDataCust_Click);
            // 
            // buttonBackToHome
            // 
            this.buttonBackToHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBackToHome.BackgroundImage")));
            this.buttonBackToHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBackToHome.Location = new System.Drawing.Point(670, 464);
            this.buttonBackToHome.Name = "buttonBackToHome";
            this.buttonBackToHome.Size = new System.Drawing.Size(150, 51);
            this.buttonBackToHome.TabIndex = 11;
            this.buttonBackToHome.UseVisualStyleBackColor = true;
            this.buttonBackToHome.Click += new System.EventHandler(this.buttonBackToHome_Click);
            // 
            // FormInputCostumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.buttonBackToHome);
            this.Controls.Add(this.buttonInputDataCust);
            this.Controls.Add(this.textBoxNomorPolisiCust);
            this.Controls.Add(this.textBoxTypeMobilCust);
            this.Controls.Add(this.textBoxNoHpCust);
            this.Controls.Add(this.textBoxAlamatCust);
            this.Controls.Add(this.textBoxNamaCust);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormInputCostumer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Costumer Data";
            this.Load += new System.EventHandler(this.FormInputCostumer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNamaCust;
        private System.Windows.Forms.TextBox textBoxAlamatCust;
        private System.Windows.Forms.TextBox textBoxNoHpCust;
        private System.Windows.Forms.TextBox textBoxTypeMobilCust;
        private System.Windows.Forms.TextBox textBoxNomorPolisiCust;
        private System.Windows.Forms.Button buttonInputDataCust;
        private System.Windows.Forms.Button buttonBackToHome;
    }
}