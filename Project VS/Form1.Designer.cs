
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
            this.buttonCheck.Image = global::Project_VS.Properties.Resources.Check_home;
            this.buttonCheck.Location = new System.Drawing.Point(482, 220);
            this.buttonCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(283, 106);
            this.buttonCheck.TabIndex = 1;
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // buttonService
            // 
            this.buttonService.Image = global::Project_VS.Properties.Resources.Service;
            this.buttonService.Location = new System.Drawing.Point(124, 220);
            this.buttonService.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonService.Name = "buttonService";
            this.buttonService.Size = new System.Drawing.Size(283, 106);
            this.buttonService.TabIndex = 0;
            this.buttonService.UseVisualStyleBackColor = true;
            this.buttonService.Click += new System.EventHandler(this.buttonService_Click);
            // 
            // FormWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonService);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormWelcome";
            this.Text = "Welcome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonService;
        private System.Windows.Forms.Button buttonCheck;
    }
}

