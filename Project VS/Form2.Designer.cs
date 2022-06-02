
namespace Project_VS
{
    partial class FormService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormService));
            this.comboBoxPilihanService = new System.Windows.Forms.ComboBox();
            this.comboBoxServiceBerkala = new System.Windows.Forms.ComboBox();
            this.textBoxKeluhan = new System.Windows.Forms.TextBox();
            this.comboBoxKeluhan = new System.Windows.Forms.ComboBox();
            this.comboBoxGantiPart = new System.Windows.Forms.ComboBox();
            this.comboBoxGantiFilter = new System.Windows.Forms.ComboBox();
            this.comboBoxRepaint = new System.Windows.Forms.ComboBox();
            this.comboBoxOli = new System.Windows.Forms.ComboBox();
            this.buttonBackToHome = new System.Windows.Forms.Button();
            this.buttonInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxPilihanService
            // 
            this.comboBoxPilihanService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPilihanService.FormattingEnabled = true;
            this.comboBoxPilihanService.Items.AddRange(new object[] {
            "Service Berkala",
            "Service AC Mobil",
            "Ganti Oli",
            "Perbaiki Rem",
            "Body Repaint",
            "Body Repair",
            "Ganti Part",
            "Tune UP",
            "Spooring Balancing",
            "Ganti Aki",
            "Ganti Filter"});
            this.comboBoxPilihanService.Location = new System.Drawing.Point(168, 178);
            this.comboBoxPilihanService.Name = "comboBoxPilihanService";
            this.comboBoxPilihanService.Size = new System.Drawing.Size(168, 28);
            this.comboBoxPilihanService.TabIndex = 1;
            this.comboBoxPilihanService.SelectedIndexChanged += new System.EventHandler(this.comboBoxPilihanService_SelectedIndexChanged);
            // 
            // comboBoxServiceBerkala
            // 
            this.comboBoxServiceBerkala.FormattingEnabled = true;
            this.comboBoxServiceBerkala.Items.AddRange(new object[] {
            "1.000 km",
            "5.000 km",
            "10.000 km",
            "15.000 km",
            "20.000 km"});
            this.comboBoxServiceBerkala.Location = new System.Drawing.Point(385, 178);
            this.comboBoxServiceBerkala.Name = "comboBoxServiceBerkala";
            this.comboBoxServiceBerkala.Size = new System.Drawing.Size(121, 24);
            this.comboBoxServiceBerkala.TabIndex = 3;
            this.comboBoxServiceBerkala.Visible = false;
            // 
            // textBoxKeluhan
            // 
            this.textBoxKeluhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKeluhan.Location = new System.Drawing.Point(168, 363);
            this.textBoxKeluhan.Name = "textBoxKeluhan";
            this.textBoxKeluhan.Size = new System.Drawing.Size(388, 27);
            this.textBoxKeluhan.TabIndex = 4;
            this.textBoxKeluhan.Visible = false;
            // 
            // comboBoxKeluhan
            // 
            this.comboBoxKeluhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxKeluhan.FormattingEnabled = true;
            this.comboBoxKeluhan.Items.AddRange(new object[] {
            "Ya",
            "Tidak"});
            this.comboBoxKeluhan.Location = new System.Drawing.Point(168, 329);
            this.comboBoxKeluhan.Name = "comboBoxKeluhan";
            this.comboBoxKeluhan.Size = new System.Drawing.Size(121, 28);
            this.comboBoxKeluhan.TabIndex = 6;
            this.comboBoxKeluhan.SelectedIndexChanged += new System.EventHandler(this.comboBoxKeluhan_SelectedIndexChanged);
            // 
            // comboBoxGantiPart
            // 
            this.comboBoxGantiPart.FormattingEnabled = true;
            this.comboBoxGantiPart.Items.AddRange(new object[] {
            "Velg",
            "Bumper",
            "Wiper Blade",
            "Spion",
            "Ban",
            "Lampu"});
            this.comboBoxGantiPart.Location = new System.Drawing.Point(385, 178);
            this.comboBoxGantiPart.Name = "comboBoxGantiPart";
            this.comboBoxGantiPart.Size = new System.Drawing.Size(121, 24);
            this.comboBoxGantiPart.TabIndex = 7;
            this.comboBoxGantiPart.Visible = false;
            // 
            // comboBoxGantiFilter
            // 
            this.comboBoxGantiFilter.FormattingEnabled = true;
            this.comboBoxGantiFilter.Items.AddRange(new object[] {
            "AC",
            "Bensin",
            "Udara"});
            this.comboBoxGantiFilter.Location = new System.Drawing.Point(385, 178);
            this.comboBoxGantiFilter.Name = "comboBoxGantiFilter";
            this.comboBoxGantiFilter.Size = new System.Drawing.Size(121, 24);
            this.comboBoxGantiFilter.TabIndex = 10;
            this.comboBoxGantiFilter.Visible = false;
            // 
            // comboBoxRepaint
            // 
            this.comboBoxRepaint.FormattingEnabled = true;
            this.comboBoxRepaint.Items.AddRange(new object[] {
            "Merah",
            "Biru",
            "Putih",
            "Kuning",
            "Hitam",
            "Silver"});
            this.comboBoxRepaint.Location = new System.Drawing.Point(385, 178);
            this.comboBoxRepaint.Name = "comboBoxRepaint";
            this.comboBoxRepaint.Size = new System.Drawing.Size(121, 24);
            this.comboBoxRepaint.TabIndex = 11;
            this.comboBoxRepaint.Visible = false;
            // 
            // comboBoxOli
            // 
            this.comboBoxOli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOli.FormattingEnabled = true;
            this.comboBoxOli.Items.AddRange(new object[] {
            "Oli Mesin",
            "Oli Gardan"});
            this.comboBoxOli.Location = new System.Drawing.Point(385, 178);
            this.comboBoxOli.Name = "comboBoxOli";
            this.comboBoxOli.Size = new System.Drawing.Size(121, 28);
            this.comboBoxOli.TabIndex = 12;
            this.comboBoxOli.Visible = false;
            // 
            // buttonBackToHome
            // 
            this.buttonBackToHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBackToHome.BackgroundImage")));
            this.buttonBackToHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBackToHome.Location = new System.Drawing.Point(670, 453);
            this.buttonBackToHome.Name = "buttonBackToHome";
            this.buttonBackToHome.Size = new System.Drawing.Size(151, 49);
            this.buttonBackToHome.TabIndex = 8;
            this.buttonBackToHome.UseVisualStyleBackColor = true;
            this.buttonBackToHome.Click += new System.EventHandler(this.buttonBackToHome_Click);
            // 
            // buttonInput
            // 
            this.buttonInput.BackColor = System.Drawing.Color.Transparent;
            this.buttonInput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonInput.BackgroundImage")));
            this.buttonInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonInput.Location = new System.Drawing.Point(442, 453);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(147, 49);
            this.buttonInput.TabIndex = 2;
            this.buttonInput.UseVisualStyleBackColor = false;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // FormService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.comboBoxOli);
            this.Controls.Add(this.comboBoxRepaint);
            this.Controls.Add(this.comboBoxGantiFilter);
            this.Controls.Add(this.buttonBackToHome);
            this.Controls.Add(this.comboBoxGantiPart);
            this.Controls.Add(this.comboBoxKeluhan);
            this.Controls.Add(this.textBoxKeluhan);
            this.Controls.Add(this.comboBoxServiceBerkala);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.comboBoxPilihanService);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormService";
            this.Text = "Service Center";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormService_FormClosing);
            this.Load += new System.EventHandler(this.FormService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxPilihanService;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.ComboBox comboBoxServiceBerkala;
        private System.Windows.Forms.TextBox textBoxKeluhan;
        private System.Windows.Forms.ComboBox comboBoxKeluhan;
        private System.Windows.Forms.ComboBox comboBoxGantiPart;
        private System.Windows.Forms.Button buttonBackToHome;
        private System.Windows.Forms.ComboBox comboBoxGantiFilter;
        private System.Windows.Forms.ComboBox comboBoxRepaint;
        private System.Windows.Forms.ComboBox comboBoxOli;
    }
}