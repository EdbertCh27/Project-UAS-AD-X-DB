using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_VS
{
    public partial class FormCheckStock : Form
    {
        public FormCheckStock()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=servicehonda");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtStokBarang = new DataTable();

        private void FormCheckStock_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT concat(STOCK, ' Buah') FROM SPAREPARTS;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtStokBarang);

            labelStockVelg.Text = dtStokBarang.Rows[0][0].ToString();
            labelStockBumper.Text = dtStokBarang.Rows[1][0].ToString();
            labelStockWiper.Text = dtStokBarang.Rows[2][0].ToString();
            labelStockSpion.Text = dtStokBarang.Rows[3][0].ToString();
            labelStockBan.Text = dtStokBarang.Rows[4][0].ToString();
            labelStockLampu.Text = dtStokBarang.Rows[5][0].ToString();
            
            
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("INVOICE");
            this.Hide();

            FormInvoice bukaFormInvoice = new FormInvoice();
            bukaFormInvoice.ShowDialog();

        }
    }
}
