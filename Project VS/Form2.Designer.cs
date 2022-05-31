﻿
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
            this.labelWhatKind = new System.Windows.Forms.Label();
            this.comboBoxPilihanService = new System.Windows.Forms.ComboBox();
            this.comboBoxServiceBerkala = new System.Windows.Forms.ComboBox();
            this.textBoxKeluhan = new System.Windows.Forms.TextBox();
            this.labelKeluhan = new System.Windows.Forms.Label();
            this.comboBoxKeluhan = new System.Windows.Forms.ComboBox();
            this.comboBoxGantiPart = new System.Windows.Forms.ComboBox();
            this.buttonBackToHome = new System.Windows.Forms.Button();
            this.comboBoxGantiFilter = new System.Windows.Forms.ComboBox();
            this.comboBoxRepaint = new System.Windows.Forms.ComboBox();
            this.comboBoxOli = new System.Windows.Forms.ComboBox();
            this.buttonInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWhatKind
            // 
            this.labelWhatKind.AutoSize = true;
            this.labelWhatKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWhatKind.Location = new System.Drawing.Point(97, 54);
            this.labelWhatKind.Name = "labelWhatKind";
            this.labelWhatKind.Size = new System.Drawing.Size(463, 32);
            this.labelWhatKind.TabIndex = 0;
            this.labelWhatKind.Text = "What Kind of Service You Want ?";
            // 
            // comboBoxPilihanService
            // 
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
            this.comboBoxPilihanService.Location = new System.Drawing.Point(102, 105);
            this.comboBoxPilihanService.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxPilihanService.Name = "comboBoxPilihanService";
            this.comboBoxPilihanService.Size = new System.Drawing.Size(188, 28);
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
            this.comboBoxServiceBerkala.Location = new System.Drawing.Point(298, 105);
            this.comboBoxServiceBerkala.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxServiceBerkala.Name = "comboBoxServiceBerkala";
            this.comboBoxServiceBerkala.Size = new System.Drawing.Size(136, 28);
            this.comboBoxServiceBerkala.TabIndex = 3;
            this.comboBoxServiceBerkala.Visible = false;
            // 
            // textBoxKeluhan
            // 
            this.textBoxKeluhan.Location = new System.Drawing.Point(102, 345);
            this.textBoxKeluhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxKeluhan.Name = "textBoxKeluhan";
            this.textBoxKeluhan.Size = new System.Drawing.Size(436, 26);
            this.textBoxKeluhan.TabIndex = 4;
            this.textBoxKeluhan.Visible = false;
            // 
            // labelKeluhan
            // 
            this.labelKeluhan.AutoSize = true;
            this.labelKeluhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKeluhan.Location = new System.Drawing.Point(97, 265);
            this.labelKeluhan.Name = "labelKeluhan";
            this.labelKeluhan.Size = new System.Drawing.Size(370, 32);
            this.labelKeluhan.TabIndex = 5;
            this.labelKeluhan.Text = "Apakah memiliki keluhan?";
            // 
            // comboBoxKeluhan
            // 
            this.comboBoxKeluhan.FormattingEnabled = true;
            this.comboBoxKeluhan.Items.AddRange(new object[] {
            "Ya",
            "Tidak"});
            this.comboBoxKeluhan.Location = new System.Drawing.Point(102, 308);
            this.comboBoxKeluhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxKeluhan.Name = "comboBoxKeluhan";
            this.comboBoxKeluhan.Size = new System.Drawing.Size(136, 28);
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
            this.comboBoxGantiPart.Location = new System.Drawing.Point(298, 105);
            this.comboBoxGantiPart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxGantiPart.Name = "comboBoxGantiPart";
            this.comboBoxGantiPart.Size = new System.Drawing.Size(136, 28);
            this.comboBoxGantiPart.TabIndex = 7;
            this.comboBoxGantiPart.Visible = false;
            // 
            // buttonBackToHome
            // 
            this.buttonBackToHome.Image = global::Project_VS.Properties.Resources.Back;
            this.buttonBackToHome.Location = new System.Drawing.Point(359, 411);
            this.buttonBackToHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBackToHome.Name = "buttonBackToHome";
            this.buttonBackToHome.Size = new System.Drawing.Size(141, 72);
            this.buttonBackToHome.TabIndex = 8;
            this.buttonBackToHome.UseVisualStyleBackColor = true;
            this.buttonBackToHome.Click += new System.EventHandler(this.buttonBackToHome_Click);
            // 
            // comboBoxGantiFilter
            // 
            this.comboBoxGantiFilter.FormattingEnabled = true;
            this.comboBoxGantiFilter.Items.AddRange(new object[] {
            "AC",
            "Bensin",
            "Udara"});
            this.comboBoxGantiFilter.Location = new System.Drawing.Point(298, 105);
            this.comboBoxGantiFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxGantiFilter.Name = "comboBoxGantiFilter";
            this.comboBoxGantiFilter.Size = new System.Drawing.Size(136, 28);
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
            this.comboBoxRepaint.Location = new System.Drawing.Point(298, 105);
            this.comboBoxRepaint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxRepaint.Name = "comboBoxRepaint";
            this.comboBoxRepaint.Size = new System.Drawing.Size(136, 28);
            this.comboBoxRepaint.TabIndex = 11;
            this.comboBoxRepaint.Visible = false;
            // 
            // comboBoxOli
            // 
            this.comboBoxOli.FormattingEnabled = true;
            this.comboBoxOli.Items.AddRange(new object[] {
            "Oli Mesin",
            "Oli Gardan"});
            this.comboBoxOli.Location = new System.Drawing.Point(298, 105);
            this.comboBoxOli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxOli.Name = "comboBoxOli";
            this.comboBoxOli.Size = new System.Drawing.Size(136, 28);
            this.comboBoxOli.TabIndex = 12;
            this.comboBoxOli.Visible = false;
            // 
            // buttonInput
            // 
            this.buttonInput.Image = global::Project_VS.Properties.Resources.Input;
            this.buttonInput.Location = new System.Drawing.Point(102, 411);
            this.buttonInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(136, 72);
            this.buttonInput.TabIndex = 2;
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // FormService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 578);
            this.Controls.Add(this.comboBoxOli);
            this.Controls.Add(this.comboBoxRepaint);
            this.Controls.Add(this.comboBoxGantiFilter);
            this.Controls.Add(this.buttonBackToHome);
            this.Controls.Add(this.comboBoxGantiPart);
            this.Controls.Add(this.comboBoxKeluhan);
            this.Controls.Add(this.labelKeluhan);
            this.Controls.Add(this.textBoxKeluhan);
            this.Controls.Add(this.comboBoxServiceBerkala);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.comboBoxPilihanService);
            this.Controls.Add(this.labelWhatKind);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormService";
            this.Text = "Service Center";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormService_FormClosing);
            this.Load += new System.EventHandler(this.FormService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWhatKind;
        private System.Windows.Forms.ComboBox comboBoxPilihanService;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.ComboBox comboBoxServiceBerkala;
        private System.Windows.Forms.TextBox textBoxKeluhan;
        private System.Windows.Forms.Label labelKeluhan;
        private System.Windows.Forms.ComboBox comboBoxKeluhan;
        private System.Windows.Forms.ComboBox comboBoxGantiPart;
        private System.Windows.Forms.Button buttonBackToHome;
        private System.Windows.Forms.ComboBox comboBoxGantiFilter;
        private System.Windows.Forms.ComboBox comboBoxRepaint;
        private System.Windows.Forms.ComboBox comboBoxOli;
    }
}