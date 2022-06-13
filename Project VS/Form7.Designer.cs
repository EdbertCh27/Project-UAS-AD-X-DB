
namespace Project_VS
{
    partial class FormReStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReStock));
            this.DGVStock = new System.Windows.Forms.DataGridView();
            this.buttonAddStock = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.NUDQtyPart = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonListHargaPart = new System.Windows.Forms.Button();
            this.buttonCheckStockSkrg = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.comboBoxPilihPart = new System.Windows.Forms.ComboBox();
            this.labelHargaPart = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDQtyPart)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVStock
            // 
            this.DGVStock.AllowUserToAddRows = false;
            this.DGVStock.AllowUserToDeleteRows = false;
            this.DGVStock.AllowUserToResizeColumns = false;
            this.DGVStock.AllowUserToResizeRows = false;
            this.DGVStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVStock.Location = new System.Drawing.Point(93, 55);
            this.DGVStock.Name = "DGVStock";
            this.DGVStock.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DGVStock.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVStock.RowTemplate.Height = 24;
            this.DGVStock.Size = new System.Drawing.Size(709, 171);
            this.DGVStock.TabIndex = 0;
            // 
            // buttonAddStock
            // 
            this.buttonAddStock.Location = new System.Drawing.Point(576, 454);
            this.buttonAddStock.Name = "buttonAddStock";
            this.buttonAddStock.Size = new System.Drawing.Size(110, 72);
            this.buttonAddStock.TabIndex = 1;
            this.buttonAddStock.Text = "Buy";
            this.buttonAddStock.UseVisualStyleBackColor = true;
            this.buttonAddStock.Click += new System.EventHandler(this.buttonAddStock_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(692, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 72);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NUDQtyPart
            // 
            this.NUDQtyPart.Enabled = false;
            this.NUDQtyPart.Location = new System.Drawing.Point(611, 291);
            this.NUDQtyPart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDQtyPart.Name = "NUDQtyPart";
            this.NUDQtyPart.Size = new System.Drawing.Size(120, 22);
            this.NUDQtyPart.TabIndex = 3;
            this.NUDQtyPart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDQtyPart.ValueChanged += new System.EventHandler(this.NUDQtyPart_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "STOCK SEKARANG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pilih Part";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantity";
            // 
            // buttonListHargaPart
            // 
            this.buttonListHargaPart.Location = new System.Drawing.Point(602, 232);
            this.buttonListHargaPart.Name = "buttonListHargaPart";
            this.buttonListHargaPart.Size = new System.Drawing.Size(84, 30);
            this.buttonListHargaPart.TabIndex = 9;
            this.buttonListHargaPart.Text = "LIST";
            this.buttonListHargaPart.UseVisualStyleBackColor = true;
            this.buttonListHargaPart.Click += new System.EventHandler(this.buttonListHargaPart_Click);
            // 
            // buttonCheckStockSkrg
            // 
            this.buttonCheckStockSkrg.Location = new System.Drawing.Point(486, 232);
            this.buttonCheckStockSkrg.Name = "buttonCheckStockSkrg";
            this.buttonCheckStockSkrg.Size = new System.Drawing.Size(84, 30);
            this.buttonCheckStockSkrg.TabIndex = 8;
            this.buttonCheckStockSkrg.Text = "Inventory";
            this.buttonCheckStockSkrg.UseVisualStyleBackColor = true;
            this.buttonCheckStockSkrg.Click += new System.EventHandler(this.buttonCheckStockSkrg_Click);
            // 
            // buttonHistory
            // 
            this.buttonHistory.Location = new System.Drawing.Point(718, 232);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(84, 30);
            this.buttonHistory.TabIndex = 10;
            this.buttonHistory.Text = "History";
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // comboBoxPilihPart
            // 
            this.comboBoxPilihPart.FormattingEnabled = true;
            this.comboBoxPilihPart.Items.AddRange(new object[] {
            "Velg",
            "Bumper",
            "Wiper Blade",
            "Spion",
            "Ban",
            "Lampu"});
            this.comboBoxPilihPart.Location = new System.Drawing.Point(219, 286);
            this.comboBoxPilihPart.Name = "comboBoxPilihPart";
            this.comboBoxPilihPart.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPilihPart.TabIndex = 11;
            this.comboBoxPilihPart.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelHargaPart
            // 
            this.labelHargaPart.AutoSize = true;
            this.labelHargaPart.Location = new System.Drawing.Point(93, 330);
            this.labelHargaPart.Name = "labelHargaPart";
            this.labelHargaPart.Size = new System.Drawing.Size(74, 17);
            this.labelHargaPart.TabIndex = 12;
            this.labelHargaPart.Text = "Harga/Pcs";
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Location = new System.Drawing.Point(216, 330);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(56, 17);
            this.labelHarga.TabIndex = 14;
            this.labelHarga.Text = "[..........]";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(608, 330);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(56, 17);
            this.labelTotal.TabIndex = 15;
            this.labelTotal.Text = "[..........]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Total";
            // 
            // FormReStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.labelHargaPart);
            this.Controls.Add(this.comboBoxPilihPart);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.buttonListHargaPart);
            this.Controls.Add(this.buttonCheckStockSkrg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NUDQtyPart);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAddStock);
            this.Controls.Add(this.DGVStock);
            this.Name = "FormReStock";
            this.Text = "Re-Stock";
            this.Load += new System.EventHandler(this.FormReStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDQtyPart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVStock;
        private System.Windows.Forms.Button buttonAddStock;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown NUDQtyPart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonListHargaPart;
        private System.Windows.Forms.Button buttonCheckStockSkrg;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.ComboBox comboBoxPilihPart;
        private System.Windows.Forms.Label labelHargaPart;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label4;
    }
}