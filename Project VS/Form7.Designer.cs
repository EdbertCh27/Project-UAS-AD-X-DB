
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReStock));
            this.DGVStock = new System.Windows.Forms.DataGridView();
            this.buttonAddStock = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.NUDQtyPart = new System.Windows.Forms.NumericUpDown();
            this.labelSTOCKSEKARANG = new System.Windows.Forms.Label();
            this.buttonListHargaPart = new System.Windows.Forms.Button();
            this.buttonCheckStockSkrg = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.comboBoxPilihPart = new System.Windows.Forms.ComboBox();
            this.labelHarga = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTabelHarga = new System.Windows.Forms.Label();
            this.labelHistory = new System.Windows.Forms.Label();
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
            this.DGVStock.Location = new System.Drawing.Point(93, 99);
            this.DGVStock.Name = "DGVStock";
            this.DGVStock.ReadOnly = true;
            this.DGVStock.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DGVStock.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVStock.RowTemplate.Height = 24;
            this.DGVStock.Size = new System.Drawing.Size(709, 171);
            this.DGVStock.TabIndex = 0;
            // 
            // buttonAddStock
            // 
            this.buttonAddStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddStock.BackgroundImage")));
            this.buttonAddStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddStock.Location = new System.Drawing.Point(517, 473);
            this.buttonAddStock.Name = "buttonAddStock";
            this.buttonAddStock.Size = new System.Drawing.Size(110, 53);
            this.buttonAddStock.TabIndex = 1;
            this.buttonAddStock.UseVisualStyleBackColor = true;
            this.buttonAddStock.Click += new System.EventHandler(this.buttonAddStock_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(692, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 53);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NUDQtyPart
            // 
            this.NUDQtyPart.Enabled = false;
            this.NUDQtyPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDQtyPart.Location = new System.Drawing.Point(644, 347);
            this.NUDQtyPart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDQtyPart.Name = "NUDQtyPart";
            this.NUDQtyPart.Size = new System.Drawing.Size(120, 27);
            this.NUDQtyPart.TabIndex = 3;
            this.NUDQtyPart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDQtyPart.ValueChanged += new System.EventHandler(this.NUDQtyPart_ValueChanged);
            // 
            // labelSTOCKSEKARANG
            // 
            this.labelSTOCKSEKARANG.AutoSize = true;
            this.labelSTOCKSEKARANG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSTOCKSEKARANG.Location = new System.Drawing.Point(91, 62);
            this.labelSTOCKSEKARANG.Name = "labelSTOCKSEKARANG";
            this.labelSTOCKSEKARANG.Size = new System.Drawing.Size(214, 25);
            this.labelSTOCKSEKARANG.TabIndex = 5;
            this.labelSTOCKSEKARANG.Text = "STOCK SEKARANG";
            // 
            // buttonListHargaPart
            // 
            this.buttonListHargaPart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonListHargaPart.BackgroundImage")));
            this.buttonListHargaPart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonListHargaPart.Location = new System.Drawing.Point(588, 276);
            this.buttonListHargaPart.Name = "buttonListHargaPart";
            this.buttonListHargaPart.Size = new System.Drawing.Size(98, 36);
            this.buttonListHargaPart.TabIndex = 9;
            this.buttonListHargaPart.UseVisualStyleBackColor = true;
            this.buttonListHargaPart.Click += new System.EventHandler(this.buttonListHargaPart_Click);
            // 
            // buttonCheckStockSkrg
            // 
            this.buttonCheckStockSkrg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCheckStockSkrg.BackgroundImage")));
            this.buttonCheckStockSkrg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCheckStockSkrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckStockSkrg.Location = new System.Drawing.Point(472, 276);
            this.buttonCheckStockSkrg.Name = "buttonCheckStockSkrg";
            this.buttonCheckStockSkrg.Size = new System.Drawing.Size(98, 36);
            this.buttonCheckStockSkrg.TabIndex = 8;
            this.buttonCheckStockSkrg.UseVisualStyleBackColor = true;
            this.buttonCheckStockSkrg.Click += new System.EventHandler(this.buttonCheckStockSkrg_Click);
            // 
            // buttonHistory
            // 
            this.buttonHistory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHistory.BackgroundImage")));
            this.buttonHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHistory.Location = new System.Drawing.Point(704, 276);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(98, 36);
            this.buttonHistory.TabIndex = 10;
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // comboBoxPilihPart
            // 
            this.comboBoxPilihPart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPilihPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPilihPart.FormattingEnabled = true;
            this.comboBoxPilihPart.Items.AddRange(new object[] {
            "Velg",
            "Bumper",
            "Wiper Blade",
            "Spion",
            "Ban",
            "Lampu"});
            this.comboBoxPilihPart.Location = new System.Drawing.Point(287, 346);
            this.comboBoxPilihPart.Name = "comboBoxPilihPart";
            this.comboBoxPilihPart.Size = new System.Drawing.Size(121, 28);
            this.comboBoxPilihPart.TabIndex = 11;
            this.comboBoxPilihPart.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Location = new System.Drawing.Point(289, 405);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(56, 17);
            this.labelHarga.TabIndex = 14;
            this.labelHarga.Text = "[..........]";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(645, 403);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(56, 17);
            this.labelTotal.TabIndex = 15;
            this.labelTotal.Text = "[..........]";
            // 
            // labelTabelHarga
            // 
            this.labelTabelHarga.AutoSize = true;
            this.labelTabelHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTabelHarga.Location = new System.Drawing.Point(91, 62);
            this.labelTabelHarga.Name = "labelTabelHarga";
            this.labelTabelHarga.Size = new System.Drawing.Size(131, 25);
            this.labelTabelHarga.TabIndex = 17;
            this.labelTabelHarga.Text = "Tabel Harga";
            this.labelTabelHarga.Visible = false;
            // 
            // labelHistory
            // 
            this.labelHistory.AutoSize = true;
            this.labelHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHistory.Location = new System.Drawing.Point(91, 62);
            this.labelHistory.Name = "labelHistory";
            this.labelHistory.Size = new System.Drawing.Size(107, 25);
            this.labelHistory.TabIndex = 18;
            this.labelHistory.Text = "HISTORY";
            this.labelHistory.Visible = false;
            // 
            // FormReStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.labelHistory);
            this.Controls.Add(this.labelTabelHarga);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.comboBoxPilihPart);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.buttonListHargaPart);
            this.Controls.Add(this.buttonCheckStockSkrg);
            this.Controls.Add(this.labelSTOCKSEKARANG);
            this.Controls.Add(this.NUDQtyPart);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAddStock);
            this.Controls.Add(this.DGVStock);
            this.DoubleBuffered = true;
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
        private System.Windows.Forms.Label labelSTOCKSEKARANG;
        private System.Windows.Forms.Button buttonListHargaPart;
        private System.Windows.Forms.Button buttonCheckStockSkrg;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.ComboBox comboBoxPilihPart;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTabelHarga;
        private System.Windows.Forms.Label labelHistory;
    }
}