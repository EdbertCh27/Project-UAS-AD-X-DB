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
    public partial class FormCheck : Form
    {
        public FormCheck()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=servicehonda");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtCustomerData = new DataTable();

        private void FormCheck_Load(object sender, EventArgs e)
        {
            
        }

        private void FormCheck_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            FormWelcome BukaFormWelcome = new FormWelcome();
            BukaFormWelcome.ShowDialog();
        }

        private void buttonBackToHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormWelcome BukaFormWelcome = new FormWelcome();
            BukaFormWelcome.ShowDialog();
        }

        private void buttonCheckCostNum_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtCustomerData = new DataTable();
                sqlQuery = "SELECT C.CUSTOMER_ID AS 'ID', C.CUSTOMER_NAME AS'NAMA', C.CUSTOMER_MERK_MOBIL AS 'TYPE MOBIL', C.CUSTOMER_NOPOL_MOBIL AS 'NOPOL', L.LAYANAN_NAMA AS 'JENIS SERVICE',DS.SELESAI_KERJA AS 'TANGGAL PENGAMBILAN', TS.SERVICE_TOTAL AS 'TOTAL' FROM CUSTOMER C, TRANS_SERVICE TS, DETAIL_SERVICE DS, LAYANAN L WHERE C.CUSTOMER_ID = TS.CUSTOMER_ID AND TS.SERVICE_ID = DS.SERVICE_ID AND L.LAYANAN_ID = DS.LAYANAN_ID AND C.customer_ID = '" + textBoxCheckCostNum.Text + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtCustomerData);
                dataGridViewCheckCostumer.DataSource = dtCustomerData;
            }
            catch (Exception)
            {

                
            }

            
        }

        
    }
}
