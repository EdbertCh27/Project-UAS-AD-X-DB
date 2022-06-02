
namespace Project_VS
{
    partial class FormWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWelcome));
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonService = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCheck.BackgroundImage")));
            this.buttonCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCheck.Location = new System.Drawing.Point(475, 306);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(290, 65);
            this.buttonCheck.TabIndex = 1;
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // buttonService
            // 
            this.buttonService.BackColor = System.Drawing.Color.Transparent;
            this.buttonService.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonService.BackgroundImage")));
            this.buttonService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonService.Location = new System.Drawing.Point(143, 306);
            this.buttonService.Name = "buttonService";
            this.buttonService.Size = new System.Drawing.Size(290, 65);
            this.buttonService.TabIndex = 0;
            this.buttonService.UseVisualStyleBackColor = false;
            this.buttonService.Click += new System.EventHandler(this.buttonService_Click);
            // 
            // FormWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonService);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormWelcome";
            this.Text = "Welcome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonService;
        private System.Windows.Forms.Button buttonCheck;
    }
}

