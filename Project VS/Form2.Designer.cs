
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
            this.comboBoxGantiPart = new System.Windows.Forms.ComboBox();
            this.comboBoxGantiFilter = new System.Windows.Forms.ComboBox();
            this.comboBoxRepaint = new System.Windows.Forms.ComboBox();
            this.comboBoxOli = new System.Windows.Forms.ComboBox();
            this.buttonBackToHome = new System.Windows.Forms.Button();
            this.buttonInput = new System.Windows.Forms.Button();
            this.dgvTabelLayanan = new System.Windows.Forms.DataGridView();
            this.comboBoxPegawai = new System.Windows.Forms.ComboBox();
            this.textBoxKiloMeterMobil = new System.Windows.Forms.TextBox();
            this.textBoxMobilKeteranganWarna = new System.Windows.Forms.TextBox();
            this.labelCurrDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelLayanan)).BeginInit();
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
            this.comboBoxPilihanService.Location = new System.Drawing.Point(89, 168);
            this.comboBoxPilihanService.Name = "comboBoxPilihanService";
            this.comboBoxPilihanService.Size = new System.Drawing.Size(168, 28);
            this.comboBoxPilihanService.TabIndex = 1;
            this.comboBoxPilihanService.SelectedIndexChanged += new System.EventHandler(this.comboBoxPilihanService_SelectedIndexChanged);
            // 
            // comboBoxGantiPart
            // 
            this.comboBoxGantiPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGantiPart.FormattingEnabled = true;
            this.comboBoxGantiPart.Items.AddRange(new object[] {
            "Velg",
            "Bumper",
            "Wiper Blade",
            "Spion",
            "Ban",
            "Lampu"});
            this.comboBoxGantiPart.Location = new System.Drawing.Point(275, 168);
            this.comboBoxGantiPart.Name = "comboBoxGantiPart";
            this.comboBoxGantiPart.Size = new System.Drawing.Size(139, 28);
            this.comboBoxGantiPart.TabIndex = 7;
            this.comboBoxGantiPart.Visible = false;
            this.comboBoxGantiPart.SelectedIndexChanged += new System.EventHandler(this.comboBoxGantiPart_SelectedIndexChanged);
            // 
            // comboBoxGantiFilter
            // 
            this.comboBoxGantiFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGantiFilter.FormattingEnabled = true;
            this.comboBoxGantiFilter.Items.AddRange(new object[] {
            "AC",
            "Bensin",
            "Udara"});
            this.comboBoxGantiFilter.Location = new System.Drawing.Point(275, 169);
            this.comboBoxGantiFilter.Name = "comboBoxGantiFilter";
            this.comboBoxGantiFilter.Size = new System.Drawing.Size(139, 28);
            this.comboBoxGantiFilter.TabIndex = 10;
            this.comboBoxGantiFilter.Visible = false;
            this.comboBoxGantiFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxGantiFilter_SelectedIndexChanged);
            // 
            // comboBoxRepaint
            // 
            this.comboBoxRepaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRepaint.FormattingEnabled = true;
            this.comboBoxRepaint.Items.AddRange(new object[] {
            "Merah",
            "Biru",
            "Putih",
            "Kuning",
            "Hitam",
            "Silver"});
            this.comboBoxRepaint.Location = new System.Drawing.Point(275, 169);
            this.comboBoxRepaint.Name = "comboBoxRepaint";
            this.comboBoxRepaint.Size = new System.Drawing.Size(139, 28);
            this.comboBoxRepaint.TabIndex = 11;
            this.comboBoxRepaint.Visible = false;
            this.comboBoxRepaint.SelectedIndexChanged += new System.EventHandler(this.comboBoxRepaint_SelectedIndexChanged);
            // 
            // comboBoxOli
            // 
            this.comboBoxOli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOli.FormattingEnabled = true;
            this.comboBoxOli.Items.AddRange(new object[] {
            "Oli Mesin",
            "Oli Gardan"});
            this.comboBoxOli.Location = new System.Drawing.Point(275, 168);
            this.comboBoxOli.Name = "comboBoxOli";
            this.comboBoxOli.Size = new System.Drawing.Size(139, 28);
            this.comboBoxOli.TabIndex = 12;
            this.comboBoxOli.Visible = false;
            this.comboBoxOli.SelectedIndexChanged += new System.EventHandler(this.comboBoxOli_SelectedIndexChanged);
            // 
            // buttonBackToHome
            // 
            this.buttonBackToHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBackToHome.BackgroundImage")));
            this.buttonBackToHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBackToHome.Location = new System.Drawing.Point(672, 478);
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
            this.buttonInput.Location = new System.Drawing.Point(444, 478);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(147, 49);
            this.buttonInput.TabIndex = 2;
            this.buttonInput.UseVisualStyleBackColor = false;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // dgvTabelLayanan
            // 
            this.dgvTabelLayanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelLayanan.Location = new System.Drawing.Point(117, 263);
            this.dgvTabelLayanan.Name = "dgvTabelLayanan";
            this.dgvTabelLayanan.RowHeadersWidth = 51;
            this.dgvTabelLayanan.RowTemplate.Height = 24;
            this.dgvTabelLayanan.Size = new System.Drawing.Size(622, 194);
            this.dgvTabelLayanan.TabIndex = 13;
            // 
            // comboBoxPegawai
            // 
            this.comboBoxPegawai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPegawai.FormattingEnabled = true;
            this.comboBoxPegawai.Location = new System.Drawing.Point(420, 168);
            this.comboBoxPegawai.Name = "comboBoxPegawai";
            this.comboBoxPegawai.Size = new System.Drawing.Size(143, 28);
            this.comboBoxPegawai.TabIndex = 14;
            // 
            // textBoxKiloMeterMobil
            // 
            this.textBoxKiloMeterMobil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKiloMeterMobil.Location = new System.Drawing.Point(571, 168);
            this.textBoxKiloMeterMobil.Name = "textBoxKiloMeterMobil";
            this.textBoxKiloMeterMobil.Size = new System.Drawing.Size(108, 28);
            this.textBoxKiloMeterMobil.TabIndex = 15;
            this.textBoxKiloMeterMobil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKiloMeterMobil_KeyPress);
            // 
            // textBoxMobilKeteranganWarna
            // 
            this.textBoxMobilKeteranganWarna.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMobilKeteranganWarna.Location = new System.Drawing.Point(693, 168);
            this.textBoxMobilKeteranganWarna.Name = "textBoxMobilKeteranganWarna";
            this.textBoxMobilKeteranganWarna.Size = new System.Drawing.Size(104, 27);
            this.textBoxMobilKeteranganWarna.TabIndex = 16;
            // 
            // labelCurrDate
            // 
            this.labelCurrDate.AutoSize = true;
            this.labelCurrDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrDate.Location = new System.Drawing.Point(112, 39);
            this.labelCurrDate.Name = "labelCurrDate";
            this.labelCurrDate.Size = new System.Drawing.Size(99, 25);
            this.labelCurrDate.TabIndex = 17;
            this.labelCurrDate.Text = "CurrDate";
            // 
            // FormService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.labelCurrDate);
            this.Controls.Add(this.textBoxMobilKeteranganWarna);
            this.Controls.Add(this.textBoxKiloMeterMobil);
            this.Controls.Add(this.comboBoxPegawai);
            this.Controls.Add(this.dgvTabelLayanan);
            this.Controls.Add(this.comboBoxOli);
            this.Controls.Add(this.comboBoxRepaint);
            this.Controls.Add(this.comboBoxGantiFilter);
            this.Controls.Add(this.buttonBackToHome);
            this.Controls.Add(this.comboBoxGantiPart);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.comboBoxPilihanService);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormService";
            this.Text = "Service Center";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormService_FormClosing);
            this.Load += new System.EventHandler(this.FormService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelLayanan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxPilihanService;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.ComboBox comboBoxGantiPart;
        private System.Windows.Forms.Button buttonBackToHome;
        private System.Windows.Forms.ComboBox comboBoxGantiFilter;
        private System.Windows.Forms.ComboBox comboBoxRepaint;
        private System.Windows.Forms.ComboBox comboBoxOli;
        private System.Windows.Forms.DataGridView dgvTabelLayanan;
        private System.Windows.Forms.ComboBox comboBoxPegawai;
        private System.Windows.Forms.TextBox textBoxKiloMeterMobil;
        private System.Windows.Forms.TextBox textBoxMobilKeteranganWarna;
        private System.Windows.Forms.Label labelCurrDate;
    }
}